namespace Inventory
{
    public class CarrierSlot : Slot
    {
        public bool carryingItem {get; private set;} = false;
        
        private InventorySlot slotTakenFrom = null;

        public void SetSlot(ItemScriptable _item, int _count, InventorySlot slot)
        {
            item = _item;
            count = _count;
            slotTakenFrom = slot;
        }

        private void ClearSlot()
        {
            item = null;
            count = 0;
            slotTakenFrom = null;
        }

        // Snap item back if menu closed
        private void OnCloseMenu()
        {
            if (carryingItem)
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
