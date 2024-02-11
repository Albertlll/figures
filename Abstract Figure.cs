using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{
    abstract public class AbstractFigure
    {
        public int x;
        public int y;
        public int width;
        public int height;
        public int number;

        static int counter;
        public AbstractFigure()
        {
            number = counter;
            counter++;
            ShapeContainer.list.Add(this);
        }
        abstract public void Draw();

        public void MoveTo(int x, int y)
        
        {
            if (!(

                (x < 0)
                || (x > Init.picture_box.Width)
                || (this.width + x > Init.picture_box.Width)

                || (y < 0)
                || (y > Init.picture_box.Height)
                || (this.height + y > Init.picture_box.Height)
                ))
            {


                // Если корректно
                this.x = x;
                this.y = y;
                ShapeContainer.DelFigure(this, true);
                this.Draw();


            }
        }

    }
}
