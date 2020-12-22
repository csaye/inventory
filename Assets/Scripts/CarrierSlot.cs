using UnityEngine;

namespace Inventory
{
    public class CarrierSlot : Slot
    {
        [Header("Carrier Slot References")]
        [SerializeField] private Camera mainCamera = null;

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

        private void Update()
        {
            // If not empty, move to mouse position
            if (!isEmpty)
            {
                Vector3 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
                transform.position = new Vector3(mousePosition.x, mousePosition.y, transform.position.z);
            }
        }

        // Snap item back if menu closed
        private void OnDisable()
        {
            // If item being carried
            if (!isEmpty)
            {
                slotTakenFrom.SetSlot(item, count);
                ClearSlot();
            }
        }
    }
}
