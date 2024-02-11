using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{
    public class Circle : Rectangle
    {
        public Circle(int x, int y, int d) : base(x, y, d, d)
        {
        }
    }
}
