using System;
using System.Collections.Generic;

namespace WonderForge.TinyWorld.Core.Inventory
{
    /// <summary>
    /// A pure C# POCO that holds the serializable state of the player's inventory.
    /// Maps ResourceID string to integer quantity.
    /// </summary>
    [Serializable]
    public class InventoryData
    {
        // Unity's JsonUtility does not serialize Dictionaries natively, 
        // so we use two parallel lists to ensure it saves to disk properly.
        public List<string> ResourceIDs = new List<string>();
        public List<int> Quantities = new List<int>();

        public void SetResource(string id, int quantity)
        {
            int index = ResourceIDs.IndexOf(id);
            if (index >= 0)
            {
                Quantities[index] = quantity;
            }
            else
            {
                ResourceIDs.Add(id);
                Quantities.Add(quantity);
            }
        }

        public int GetResource(string id)
        {
            int index = ResourceIDs.IndexOf(id);
            return index >= 0 ? Quantities[index] : 0;
        }
    }
}
