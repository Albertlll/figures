﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{
    public class Rectangle : AbstractFigure
    {
        
        public Rectangle(int x, int y, int w, int h) : base()
        {
            
            this.x = x;
            this.y = y;
            this.width = w;
            this.height = h;
        }
        public override void Draw()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawRectangle(Init.pen, this.x, this.y, this.width, this.height);
            Init.picture_box.Image = Init.bitmap;
        }
    }
}
