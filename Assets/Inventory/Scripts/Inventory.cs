using UnityEngine;

namespace Inventory
{
    public class Inventory : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private Slot[] slots = new Slot[40];

        public void AddItem(ItemScriptable item, int count)
        {
            // Cycle through all slots
            for (int i = 0; i < slots.Length; i++)
            {
                // Get slot at index
                Slot slot = slots[i];

                // If slot empty
                if (slot.isEmpty)
                {
                    slot = new Slot(item, count);
                }
            }
        }
    }
}
