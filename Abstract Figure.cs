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
        }
        abstract public void Draw();
        abstract public void MoveTo(int x, int y);

    }
}
