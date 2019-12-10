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
            String name = "Undefined";
            Shape3D poligon = new Shape3D();
            poligon.Volume = 0;

        }

        public void DisplayInfo()
        {
            Console.WriteLine(this.Area);
            Console.WriteLine(this.Perimeter);
            Console.WriteLine(this.Volume);
         
        }
    }
}