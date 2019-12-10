using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTrainingM7C;

namespace AutomationTrainingM7C.Ivan_Rodriguez_M7_Exercise
{
    interface IShape
    {
        double Area { get; set; }
        double Perimeter { get; set; }
        string Name { get; set; }
        double Volume { get; set; }
        void DisplayInfo();
    }

}
