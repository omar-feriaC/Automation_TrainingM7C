using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AutomationTraining_M7.Jose_Pasos_M7_Excercise
{
    class _2D_Shape : IShape
    {
        public double Area;
        public double Perimeter;

        public string Name { get; set; }

        public void DisplayInfo()
        {
            
        }

        public _2D_Shape ()
        {
            Name = "undefined";
            Area = 0;
            Perimeter = 0;
        }

            



        

    }
}
