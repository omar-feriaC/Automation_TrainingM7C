using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7C.Alfonso_medina_M7_Excercise
{
    class Cone : Shape3D
    {
        public Cone()
        {
            Cone object1 = new Cone();
            Name = "Cone";
            Area = 0;
            Perimeter = 0;
            Volume = 0;

        }

        public Cone(double valueA, double valueP, double valueV)
        {
            
            Name = "Cone";
            Area = valueA;
            Perimeter = valueP;
            Volume = valueV;

        }

        public double CalculateVolume(double radio, double height)
        {
            double pi = 3.1415;
            return (pi * (radio * radio) * height) / 3;
        }

    }
}

