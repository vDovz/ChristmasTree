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
            SolidTriangle trg = new SolidTriangle(5);
            trg.Draw();
            SolidTriangle trg1 = new SolidTriangle(5);
            trg1.Draw();
            SolidTriangle trg2 = new SolidTriangle(5);
            trg2.Draw();
            Console.WriteLine("   ***");
            Console.WriteLine("   ***");


        }
    }
}
