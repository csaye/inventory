﻿using System;

namespace Inventory
{
    public class GameEvents
    {
        public static event Action onCloseMenu;
        public static void DispatchOnCloseMenu() => onCloseMenu?.Invoke();
    }
}
