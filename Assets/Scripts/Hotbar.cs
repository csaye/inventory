using UnityEngine;

namespace Inventory
{
    public class Hotbar : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private HotbarSlot[] slots = new HotbarSlot[10];

        private Color normalColor = Color.white;
        private Color selectedColor = new Color(0.8f, 0.8f, 0.8f);

        private HotbarSlot _selectedSlot = null;
        public HotbarSlot selectedSlot
        {
            get { return _selectedSlot; }
            set
            {
                if (selectedSlot != null) selectedSlot.SetSlotColor(normalColor);
                _selectedSlot = value;
                selectedSlot.SetSlotColor(selectedColor);
            }
        }

        // Initialize with slot zero selected
        private void Start()
        {
            selectedSlot = slots[0];
        }
    }
}
