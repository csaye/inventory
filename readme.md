# Inventory
An advanced inventory system for Unity.

## Functionality
- Hotbar and toggleable inventory
- Click and drag inventory management
- Smart item stacking
- Scriptable object items
- Hotbar slot highlighting

## Scripts
### ItemScriptable
- Composed of `int itemID`, `Sprite itemIcon`, and `int maxStack` variables
### Slot
- Contains logic for `ItemScriptable item` and `int count` properties
### InventorySlot
- Inherits from Slot
- Contains logic for clicking on slot in inventory within `OnClick()`
### HotbarSlot
- Inherits from InventorySlot
- Contains logic for selecting hotbar slot within `HighlightSlot()`
### Inventory
- Contains logic for adding items to inventory slots within `AddItem()`
### Hotbar
- Contains logic for `selectedSlot` property
### CarrierSlot
- Contains logic for icon following mouse while managing items
### UIManager
- Contains logic for toggling inventory
