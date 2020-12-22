using UnityEngine;
using UnityEngine.UI;

namespace Inventory
{
    public class HotbarSlot : InventorySlot
    {
        [Header("Hotbar Slot References")]
        [SerializeField] private Image panel = null;
        [SerializeField] private Hotbar hotbar = null;

        public void HighlightSlot() => hotbar.selectedSlot = this;

        public void SetSlotColor(Color color) => panel.color = color;
    }
}
