using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Circle : Shape
    {
        private int radius;
        public Circle(int r)
        {
            radius = r;
        }

        public override void Draw()
        {
            for (int i = 1; i <= 2 * radius; i++)
            {
                for (int j = 1; j <= 2 * radius; j++)
                {
                    if (i == radius || j == radius || j == radius + 1 + i || j == radius - 1 - i || i == radius + 1 + j || i == radius + 1 + 2)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }


        }
    }
}
