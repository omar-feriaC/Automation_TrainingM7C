using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7C.Base_Files
{
    class Cylinder : 3D_Shape
    {
    
        public void Area()
    { 

            double pi=3.1416;
            double radio=5;

            ACylinder = pi * (5 * 5);
            Console.WriteLine("Area = " +ACylinder)
    }

        public void Perimeter()
        {
            double radio = 3;
            double pi = 3.1416;

            PCylinder = radio * (2 * pi);
            Console.WriteLine("Perimeter = " + PCylinder)
        }

        public void Volume()
        {
            double pi = 3.1416;
            double radio = 5;
            double high = 10;

            VCylinder = pi * (5 * 5) * high;
            Console.WriteLine("Volume = " + VCylinder)
        }

}
}
