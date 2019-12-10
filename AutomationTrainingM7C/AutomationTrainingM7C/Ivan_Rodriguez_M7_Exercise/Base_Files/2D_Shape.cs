using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTrainingM7C.Ivan_Rodriguez_M7_Exercise;

namespace AutomationTrainingM7C.Ivan_Rodriguez_M7_Exercise
{
    public class _2D_Shape : IShape
    {
        public double Area { get; set; }
        public double Perimeter { get; set; }
        public string StrName { get; set; }
        public _2D_Shape()
        {
            Area = 0;
            Perimeter = 0;
            StrName = null;
        }
        public void DisplayInfo()
        {
        }
    }
}
