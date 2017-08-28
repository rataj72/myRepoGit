using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using snake.buttons;
using snake.interfeces;
using ButtonBase = snake.buttons.ButtonBase;

namespace snake.factory
{
    public static class ButtonFactory
    {
        private static Form1 f1;
        private static int posX;
        private static int posY;

        private static Dictionary<WhatItem, Func<IItem<Button>>> ItemDictionary = new Dictionary<WhatItem, Func<IItem<Button>>>()
        {
            {WhatItem.SnakeHead, () => new SnakeHead(f1,posX,posY)  },
        };

        public static IItem<T> CreateItem<T>(Form1 f1, int posX, int posY, WhatItem whatItem)
        {
            ButtonFactory.posX = posX;
            ButtonFactory.posY = posY;
            ButtonFactory.f1 = f1;
            return (IItem<T>) (ItemDictionary.ContainsKey(whatItem) ? ItemDictionary[whatItem]() : null);
        }
    }
}