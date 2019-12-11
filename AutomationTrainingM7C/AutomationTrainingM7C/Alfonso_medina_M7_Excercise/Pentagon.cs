using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7C.Alfonso_medina_M7_Excercise
{
    class Pentagon : Shape2D
    {
        public Pentagon()
        {            
            
            Name = "Pentagon";
            Area = 0;
            Perimeter = 0;

        }

        public Pentagon(double valueA, double valueP)
        {            
            
            Name = "Cone";
            Area = valueA;
            Perimeter = valueP;

        }

        public double CalculateArea(double apotema)
        {
            return (Perimeter * apotema)/2;


        }

    }
}
