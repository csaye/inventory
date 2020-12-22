using UnityEngine;

namespace Inventory
{
    public class CarrierSlot : Slot
    {
        public InventorySlot slotTakenFrom { get; private set; } = null;

        // Sets slot to given item and count with reference to slot taken from
        public void SetSlot(ItemScriptable _item, int _count, InventorySlot slot)
        {
            item = _item;
            count = _count;
            slotTakenFrom = slot;
        }

        // Clears slot of items
        public void ClearSlot()
        {
            item = null;
            count = 0;
            slotTakenFrom = null;
        }

        private void Update()
        {
            // If menu open and not empty
            if (UIManager.menuOpen && !isEmpty)
            {
                // Move to mouse position
                Vector3 mousePosition = Input.mousePosition;
                transform.position = new Vector3(mousePosition.x, mousePosition.y, transform.position.z);
            }
        }

        // Snap item back if menu closed
        private void OnDisable()
        {
            // If item being carried
            if (!isEmpty)
            {
                // Set slot taken from and clear slot
                slotTakenFrom.SetSlot(item, count);
                ClearSlot();
            }
        }
    }
}
