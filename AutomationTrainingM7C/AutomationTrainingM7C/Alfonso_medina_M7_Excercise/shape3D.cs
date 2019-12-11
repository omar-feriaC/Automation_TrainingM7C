using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7C.Alfonso_medina_M7_Excercise
{
    class Shape3D : Shape2D
    {
        protected double Volume { get; set; }

        public Shape3D()
        {
            Name = null;
            Area = 0;
            Perimeter = 0;
            Volume = 0;

        }

        public new void DisplayInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Area);
            Console.WriteLine(Perimeter);
            Console.WriteLine(Volume);
         
        }
    }
}