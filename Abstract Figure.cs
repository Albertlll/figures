using System;
using System.Collections.Generic;
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
        abstract public void Draw();
        abstract public void MoveTo(int x, int y);

    }
}
