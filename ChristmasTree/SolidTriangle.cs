using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class SolidTriangle : Triangle
    {
        public SolidTriangle(int a) : base(a)
        {
        }

        protected override void Output(int i, int j)
        {
            if (i <= 2*height && i >= height - j + 1 && j <= height + i - 1)
                Console.Write("*");
            else
                Console.Write(" ");
        }
    }
}
