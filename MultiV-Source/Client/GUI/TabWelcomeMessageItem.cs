﻿using System.Drawing;
using System.IO;
using GTA;
using NativeUI;
using NativeUI.PauseMenu;

namespace MultiV.GUI
{
    public class TabWelcomeMessageItem : TabTextItem
    {
        public TabWelcomeMessageItem(string defaultTitle, string defaultText) : base("Neuigkeiten", defaultTitle, defaultText)
        {
        }

        public string PromoPicturePath { get; set; }

        public override void Draw()
        {

            base.Draw();

            if (!string.IsNullOrEmpty(PromoPicturePath) && File.Exists(PromoPicturePath) && !Game.IsLoading)
            {
                WordWrap = BottomRight.X - TopLeft.X - 40 - 400 - 20;
                //Sprite.DrawTexture(PromoPicturePath, new Point(BottomRight.X - 400, TopLeft.Y), new Size(400, 600));
                Util.DxDrawTexture(0, PromoPicturePath, BottomRight.X - 400, TopLeft.Y, 400, 600, 0, 255, 255, 255, 255);
            }
        }
    }
}