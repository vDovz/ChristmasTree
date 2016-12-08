using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
           // Square sqr = new Square(5);
            //sqr.Draw();
            Triangle trg = new Triangle(10);
            trg.Draw();
            Triangle trg1 = new Triangle(7);
            trg1.Draw();
            Triangle trg2 = new Triangle(3);
            trg2.Draw();
            SolidTriangle strg = new SolidTriangle(5);
            strg.Draw();

            Circle cr = new Circle(5);
            cr.Draw();

        }
    }
}
