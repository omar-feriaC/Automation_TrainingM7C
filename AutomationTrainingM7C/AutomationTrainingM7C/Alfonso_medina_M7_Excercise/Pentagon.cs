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
            String name = "Pentagon";
            Pentagon object2 = new Pentagon();
            object2.Area = 0;
            object2.Perimeter = 0;

        }

        public Pentagon(double valueA, double valueP)
        {
            String name = "Cone";
            Pentagon object2 = new Pentagon();
            object2.Area = valueA;
            object2.Perimeter = valueP;

        }

    }
}
