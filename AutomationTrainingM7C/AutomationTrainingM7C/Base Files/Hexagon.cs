using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7C.Base_Files
{
    class Hexagon : 2D_Shape
    {
        public Area()
        {

            double perihexa = 5;
            double apo = 3;

            AHexagon = (perihexa * apo) / 2;
            Console.WriteLine("Area = " + AHexagon)
    }

        public void Perimeter()
        {
            double length = 1;
            
            PHexagon = length * 6;
            Console.WriteLine("Perimeter = " + PHexagon)
        }
    }
}
