using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Triangle : Shape
    {
        protected int height;


        public Triangle(int a)
        {
            height = a;

        }

        public override void Draw()
        {
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j < 2 * height; j++)
                {
                    Output(i,j);
                }
                Console.WriteLine();
            }
        }
        protected virtual void Output(int i, int j)
        {
            if (i == height || i == height - j + 1 || j == height + i - 1)
                Console.Write("*");
            else
                Console.Write(" ");
        }
    }
}
