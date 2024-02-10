using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{
    public class Square : Rectangle
    {
        static int sq_counter = 0;
        public Square(int x, int y, int side) : base(x, y, side, side){
        }
    }
}
