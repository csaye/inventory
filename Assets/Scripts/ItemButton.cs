using UnityEngine;

namespace Inventory
{
    public class ItemButton : MonoBehaviour
    {
        [Header("Attributes")]
        [SerializeField] private ItemScriptable itemScriptable = null;

        [Header("References")]
        [SerializeField] private Inventory inventory = null;

        public void OnClick()
        {
            inventory.AddItem(itemScriptable, 1);
        }
    }
}
