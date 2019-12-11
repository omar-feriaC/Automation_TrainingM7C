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
            object1.Name = "Cone";
            object1.Area = 0;
            object1.Perimeter = 0;
            object1.Volume = 0;

        }

        public Cone(double valueA, double valueP, double valueV)
        {
            Cone object1 = new Cone();
            object1.Name = "Cone";
            object1.Area = valueA;
            object1.Perimeter = valueP;
            object1.Volume = valueV;

        }


    }
}

