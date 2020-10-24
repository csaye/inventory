namespace Inventory
{
    public class CarrierSlot : Slot
    {   
        private InventorySlot slotTakenFrom = null;

        public void SetSlot(ItemScriptable _item, int _count, InventorySlot slot)
        {
            item = _item;
            count = _count;
            slotTakenFrom = slot;
        }

        public void ClearSlot()
        {
            item = null;
            count = 0;
            slotTakenFrom = null;
        }

        // Snap item back if menu closed
        private void OnCloseMenu()
        {
            // If item being carried
            if (!isEmpty)
            {
                slotTakenFrom.SetSlot(item, count);
                ClearSlot();
            }
        }

        private void OnEnable()
        {
            GameEvents.onCloseMenu += OnCloseMenu;
        }

        private void OnDisable()
        {
            GameEvents.onCloseMenu -= OnCloseMenu;
        }
    }
}
