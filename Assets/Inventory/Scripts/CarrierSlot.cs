using UnityEngine;

namespace Inventory
{
    public class CarrierSlot : MonoBehaviour
    {
        public bool carryingItem {get; private set;} = false;
        
        private Slot slotTakenFrom = null;
        
    }
}
