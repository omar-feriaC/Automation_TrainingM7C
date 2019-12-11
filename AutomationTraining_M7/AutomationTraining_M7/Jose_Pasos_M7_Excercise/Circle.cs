using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AutomationTraining_M7.Jose_Pasos_M7_Excercise
{
    class Circle : _3D_Shape
    {
        double Radio;

        //Constructors
        public Circle()
        {
            Name = "Undefined";
            Radio = 0;

        }

        public Circle(double r)
        {
            Radio = r;
        }

        //Methods
        public void GetPerimeter()
        {
            Perimeter = (Radio * 2) * 3.14;
        }

        public void GetArea()
        {
            Area = 3.14 * (Radio * Radio);
        }
    }
}
