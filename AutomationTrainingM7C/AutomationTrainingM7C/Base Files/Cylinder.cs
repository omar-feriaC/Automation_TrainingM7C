using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7C.Base_Files
{
    class Cylinder : 3D_Shapes
    {

        private double pi1;
        private double radio1;
        private double high1;

        private double pi2;
        private double radio2;
        private double high2;
        
        private double pi3;
        private double radio3;
        private double high3;

        public override Area(double pi1, double radio1, double high1)
        { 

            double pi1=3.1416;
            double radio1=5;
            double high1 = 10;

            double ACylinder = pi1 * (radio1 * radio1);
            Console.WriteLine("Area = " + ACylinder);
        }


        public override void Perimeter(double radio2, double pi2)
        {
            double radio2 = 3;
            double pi2 = 3.1416;

            double PCylinder = radio2 * (2 * pi2);
            Console.WriteLine("Perimeter = " + PCylinder);
        }

        public void Volume(double pi3, double radio3, double high3)
        {
            double pi3 = 3.1416;
            double radio3 = 5;
            double high3 = 10;

            double VCylinder = pi3 * (radio3 * radio3) * high3;
            Console.WriteLine("Volume = " + VCylinder);
        }

    }
}
