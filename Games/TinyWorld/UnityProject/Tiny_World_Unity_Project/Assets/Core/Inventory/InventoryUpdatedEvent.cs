namespace WonderForge.TinyWorld.Core.Inventory
{
    /// <summary>
    /// Fired whenever a resource quantity changes, so the UI can update automatically.
    /// This is a struct to prevent GC allocation on the EventBus.
    /// </summary>
    public struct InventoryUpdatedEvent
    {
        public string ResourceID;
        public int NewQuantity;
        public int AmountChanged;

        public InventoryUpdatedEvent(string resourceID, int newQuantity, int amountChanged)
        {
            ResourceID = resourceID;
            NewQuantity = newQuantity;
            AmountChanged = amountChanged;
        }
    }
}
