using UnityEngine;

namespace Inventory
{
    [CreateAssetMenu(menuName = "Scriptables/Item", fileName = "Item")]
    public class ItemScriptable : ScriptableObject
    {
        public int itemID;
        public Sprite itemIcon;
        public int maxStack;
    }
}
