using UnityEngine;

namespace Inventory
{
    public class Slot : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private CarrierSlot carrierSlot = null;

        public ItemScriptable item {get; private set;} = null;
        public int count {get; private set;} = 0;

        public Slot()
        {
            item = null;
            count = 0;
        }

        public Slot(ItemScriptable _item, int _count)
        {
            item = _item;
            count = _count;
        }

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

        // Returns whether slot is empty
        public bool IsEmpty()
        {
            return count == 0 || item == null;
        }
    }
}
