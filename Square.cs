using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{
    class Square : Rectangle
    {
        public Square(int x, int y, int side) : base(x, y, side, side){}
    }
}
