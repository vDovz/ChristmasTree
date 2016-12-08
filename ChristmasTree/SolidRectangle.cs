using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class SolidRectangle : Rectangle
    {
        public SolidRectangle(int a, int b) : base(a, b)
        {
        }
        protected override void Output(int i, int j)
        {
            Console.Write("*");
        }
    }
}
