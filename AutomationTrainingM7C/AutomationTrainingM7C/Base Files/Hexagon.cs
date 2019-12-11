using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7C.Base_Files
{

    class Hexagon : IShape
    {

        double perihexa;
        double apo;
        public override void Area(double perihexa,double apo)
        {

            double perihexa = 5;
            double apo = 3;

            double AHexagon = (perihexa * apo) / 2;
            Console.WriteLine("Area = " + AHexagon);
        }

        double length;
        public override void Perimeter(double length)
        {
            double length = 1;

            double PHexagon = length * 6;
            Console.WriteLine("Perimeter = " + PHexagon);
        }
        
    }
}