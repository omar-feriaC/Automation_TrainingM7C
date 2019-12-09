using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTrainingM7C;

namespace AutomationTrainingM7C.M7Exercise.NugetPkg
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
