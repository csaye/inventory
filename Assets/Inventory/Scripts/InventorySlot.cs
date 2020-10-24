using UnityEngine;

namespace Inventory
{
    public class InventorySlot : Slot
    {
        [Header("Inventory Slot References")]
        [SerializeField] private CarrierSlot carrierSlot = null;

        public void OnClick()
        {
            // If item being carried
            if (carrierSlot.carryingItem)
            {

            }
            // If no item being carried
            else
            {

            }
        }

        // Sets slot to given item and count
        public void SetSlot(ItemScriptable _item, int _count)
        {
            item = _item;
            count = _count;
        }

        // Clears slot of items
        public void ClearSlot()
        {
            item = null;
            count = 0;
        }
    }
}
