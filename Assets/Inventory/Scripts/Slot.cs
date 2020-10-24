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

        public Slot() {}

        public Slot(ItemScriptable _item, int _count)
        {
            item = _item;
            count = _count;
        }

        // Returns whether slot is empty
        public bool IsEmpty()
        {
            return count == 0 || item == null;
        }
    }
}
