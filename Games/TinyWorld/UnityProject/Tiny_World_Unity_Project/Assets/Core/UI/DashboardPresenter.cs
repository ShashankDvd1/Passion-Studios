using UnityEngine;
using TMPro;
using WonderForge.TinyWorld.Core.Events;
using WonderForge.TinyWorld.Core.Inventory;
using WonderForge.TinyWorld.Core.Runtime;
using WonderForge.TinyWorld.Core.Managers.Crafting;
using WonderForge.TinyWorld.Core.Managers.Expedition;

namespace WonderForge.TinyWorld.UI
{
    /// <summary>
    /// The Unity MonoBehaviour that acts as the View layer for the Dashboard.
    /// It listens to the pure C# EventBus to update TextMeshPro fields.
    /// </summary>
    public class DashboardPresenter : MonoBehaviour
    {
        [Header("Resource UI")]
        public TextMeshProUGUI AetherDustText;
        public TextMeshProUGUI RustedScrapText;
        public TextMeshProUGUI SparkCoreText;

        [Header("Notifications")]
        public TextMeshProUGUI NotificationText;

        [Header("Status UI")]
        public TextMeshProUGUI StatusText;

        private void OnEnable()
        {
            // Subscribe to EventBus
            if (GameRuntime.Instance != null && GameRuntime.Instance.TryGetService<IEventBus>(out var eventBus))
            {
                eventBus.Subscribe<InventoryUpdatedEvent>(OnInventoryUpdated);
                eventBus.Subscribe<CraftingCompletedEvent>(OnCraftingCompleted);
            }
        }

        private void OnDisable()
        {
            // Unsubscribe to prevent memory leaks
            if (GameRuntime.Instance != null && GameRuntime.Instance.TryGetService<IEventBus>(out var eventBus))
            {
                eventBus.Unsubscribe<InventoryUpdatedEvent>(OnInventoryUpdated);
                eventBus.Unsubscribe<CraftingCompletedEvent>(OnCraftingCompleted);
            }
        }

        private void Start()
        {
            // Initialize UI with current data
            if (GameRuntime.Instance != null && GameRuntime.Instance.TryGetService<IInventoryService>(out var inventoryService))
            {
                AetherDustText.text = $"Dust: {inventoryService.GetResourceAmount("AetherDust")}";
                RustedScrapText.text = $"Scrap: {inventoryService.GetResourceAmount("RustedScrap")}";
                SparkCoreText.text = $"Cores: {inventoryService.GetResourceAmount("SparkCore")}";
            }
        }

        private void OnInventoryUpdated(InventoryUpdatedEvent evt)
        {
            // Update the specific UI text based on what changed
            switch (evt.ResourceID)
            {
                case "AetherDust":
                    AetherDustText.text = $"Dust: {evt.NewQuantity}";
                    break;
                case "RustedScrap":
                    RustedScrapText.text = $"Scrap: {evt.NewQuantity}";
                    break;
                case "SparkCore":
                    SparkCoreText.text = $"Cores: {evt.NewQuantity}";
                    break;
            }
        }

        private void OnCraftingCompleted(CraftingCompletedEvent evt)
        {
            if (NotificationText != null)
            {
                NotificationText.text = $"Successfully crafted: {evt.Recipe.DisplayName}!";
                // TODO: Add simple animation to fade out text
            }
        }

        private void Update()
        {
            // Simple polling for the countdown timer
            if (GameRuntime.Instance != null && GameRuntime.Instance.TryGetService<IExpeditionService>(out var expService))
            {
                if (expService.IsExploring())
                {
                    int remaining = expService.GetRemainingSeconds();
                    if (remaining > 0)
                    {
                        if (StatusText != null) StatusText.text = $"Exploring: {remaining}s left";
                    }
                    else
                    {
                        if (StatusText != null) StatusText.text = "Expedition Complete! Checking in...";
                        expService.TryCompleteExpedition();
                    }
                }
                else
                {
                    if (StatusText != null) StatusText.text = "Status: Idle";
                }
            }
        }
    }
}
