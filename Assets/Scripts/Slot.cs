using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Inventory
{
    public class Slot : MonoBehaviour
    {
        [Header("Slot References")]
        [SerializeField] private Sprite placeholder = null;
        [SerializeField] private Image itemImage = null;
        [SerializeField] private TextMeshProUGUI countText = null;

        // Item property which automatically updates item image
        private ItemScriptable _item = null;
        public ItemScriptable item
        {
            get { return _item; }
            set
            {
                _item = value;
                itemImage.sprite = item != null ? item.itemIcon : placeholder;
            }
        }

        // Count property which automatically updates count text
        private int _count = 0;
        public int count
        {
            get { return _count; }
            set
            {
                _count = value;
                countText.text = count > 1 ? count.ToString() : "";
            }
        }

        // Whether slot is empty
        public bool isEmpty
        {
            get { return count == 0 || item == null; }
        }

        public Slot() {}

        public Slot(ItemScriptable _item, int _count)
        {
            item = _item;
            count = _count;
        }
    }
}
