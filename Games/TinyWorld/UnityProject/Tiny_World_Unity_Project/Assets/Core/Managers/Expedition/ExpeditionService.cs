using System;
using System.Threading.Tasks;
using UnityEngine;
using WonderForge.TinyWorld.Core.Runtime.Interfaces;
using WonderForge.TinyWorld.Core.Save;
using WonderForge.TinyWorld.Core.Managers.Time;
using WonderForge.TinyWorld.Core.Inventory;
using WonderForge.TinyWorld.Core.Utilities;

namespace WonderForge.TinyWorld.Core.Managers.Expedition
{
    public class ExpeditionService : IExpeditionService, IInitializable
    {
        private const string SAVE_KEY = "ExpeditionState";
        private readonly ISaveService _saveService;
        private readonly ITimeService _timeService;
        private readonly IInventoryService _inventoryService;

        private ExpeditionData _data;

        public ExpeditionService(ISaveService saveService, ITimeService timeService, IInventoryService inventoryService)
        {
            _saveService = saveService;
            _timeService = timeService;
            _inventoryService = inventoryService;
        }

        public async Task InitializeAsync()
        {
            _data = await _saveService.LoadAsync<ExpeditionData>(SAVE_KEY);
            if (_data == null)
            {
                _data = new ExpeditionData();
            }

            if (_data.IsExploring)
            {
                // If the app boots and we are exploring, check if it finished while offline
                if (GetRemainingSeconds() <= 0)
                {
                    TryCompleteExpedition();
                }
            }
            GameLogger.Log($"[Expedition] Initialized. Exploring: {_data.IsExploring}");
        }

        public bool IsExploring()
        {
            return _data.IsExploring;
        }

        public int GetRemainingSeconds()
        {
            if (!_data.IsExploring) return 0;
            
            DateTime startTime = DateTime.FromBinary(_data.StartTimeBinary);
            long secondsPassed = (long)(DateTime.UtcNow - startTime).TotalSeconds;
            
            int remaining = _data.DurationSeconds - (int)secondsPassed;
            return remaining > 0 ? remaining : 0;
        }

        public void StartExpedition(int durationSeconds)
        {
            if (_data.IsExploring) return;

            _data.IsExploring = true;
            _data.DurationSeconds = durationSeconds;
            _data.StartTimeBinary = DateTime.UtcNow.ToBinary();
            
            _ = _saveService.SaveAsync(SAVE_KEY, _data);
            GameLogger.Log($"[Expedition] Started for {durationSeconds} seconds.");
        }

        public bool TryCompleteExpedition()
        {
            if (!_data.IsExploring || GetRemainingSeconds() > 0) return false;

            _data.IsExploring = false;
            _ = _saveService.SaveAsync(SAVE_KEY, _data);

            // Grant rewards based on duration (1 resource per minute approx)
            int rewardAmount = Mathf.Max(1, _data.DurationSeconds / 60); 
            
            // Add Common Resource
            _inventoryService.AddResource("AetherDust", rewardAmount);
            
            // Add Uncommon Resource for longer trips
            if (_data.DurationSeconds >= 1800) // >= 30 mins
            {
                _inventoryService.AddResource("RustedScrap", Mathf.Max(1, rewardAmount / 5));
            }
            
            // Add Rare Resource for very long trips
            if (_data.DurationSeconds >= 14400) // >= 4 hours
            {
                // 10% chance
                if (UnityEngine.Random.value <= 0.1f)
                {
                    _inventoryService.AddResource("SparkCore", 1);
                }
            }

            GameLogger.Log($"[Expedition] Completed successfully. Rewards granted.");
            return true;
        }
    }
}
