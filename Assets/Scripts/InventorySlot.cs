using UnityEngine;

namespace Inventory
{
    public class InventorySlot : Slot
    {
        [Header("Inventory Slot References")]
        [SerializeField] private CarrierSlot carrierSlot = null;

        public void OnClick()
        {
            // If menu not open, return
            if (!UIManager.menuOpen) return;

            // If no item being carried
            if (carrierSlot.isEmpty)
            {
                // If slot empty, return
                if (isEmpty)
                {
                    return;
                }
                // Otherwise, transfer to carrier slot
                else
                {
                    carrierSlot.SetSlot(item, count, this);
                    ClearSlot();
                }
            }
            // If item being carried
            else
            {
                // If slot empty, set item and clear carrier
                if (isEmpty)
                {
                    SetSlot(carrierSlot.item, carrierSlot.count);
                    carrierSlot.ClearSlot();
                }
                // If stackable to slot
                else if (item == carrierSlot.item && count < item.maxStack)
                {
                    // If carrier items can stack fully, stack and clear carrier
                    if (count + carrierSlot.count <= item.maxStack)
                    {
                        count += carrierSlot.count;
                        carrierSlot.ClearSlot();
                    }
                    // If carrier items cannot stack fully, stack until maxed
                    else
                    {
                        carrierSlot.count -= item.maxStack - count;
                        count = item.maxStack;
                    }
                }
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
