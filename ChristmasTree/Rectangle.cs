using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Rectangle : Shape
    {
        private int width;
        private int height;

        public Rectangle(int a, int b)
        {
            width = a;
            height = b;
        }

        public override void Draw()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Output(i, j);
                }
                Console.WriteLine();
            }
        }
        protected virtual void Output(int i, int j)
        {
            if (i == 0 || j == 0)
            {
                Console.Write("*");
            }
        }
    }
}
