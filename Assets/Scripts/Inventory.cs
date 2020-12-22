using UnityEngine;

namespace Inventory
{
    public class Inventory : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private ItemScriptable[] itemScriptables = null;
        [SerializeField] private InventorySlot[] slots = new InventorySlot[40];

        public void AddItemTest()
        {
            AddItem(itemScriptables[1], 1);
        }

        // Returns whether items were added successfully
        public bool AddItem(ItemScriptable item, int count)
        {
            // If count exceeds max item stack, return false
            if (count > item.maxStack) return false;

            // Cycle through all slots
            for (int i = 0; i < slots.Length; i++)
            {
                // Get slot at index
                InventorySlot slot = slots[i];

                // If slot empty, add item and return true
                if (slot.isEmpty)
                {
                    slot.SetSlot(item, count);
                    return true;
                }
                // If same item as slot
                else if (item == slot.item)
                {
                    // If stackable, add items and return true
                    if (count + slot.count <= item.maxStack)
                    {
                        slot.count += count;
                        return true;
                    }
                }
            }

            // If not enough space, return false
            return false;
        }
    }
}
