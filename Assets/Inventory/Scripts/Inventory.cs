using UnityEngine;

namespace Inventory
{
    public class Inventory : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private Slot[] slots = new Slot[40];

        public void AddItem(ItemScriptable item, int count)
        {
            
        }
    }
}
