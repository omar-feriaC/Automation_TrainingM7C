using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTrainingM7C.M7Exercise.NugetPkg;

namespace AutomationTrainingM7C.Jose_Cruz_M7_Execise
{
    class _2D_Shape:IShape
    {
        IShape ishape;
        public Double Area;
        public Double Perimeter;

        public void DisplayInfo()
        { 
            
        }

        public _2D_Shape() {
            string Name = "";
            Area = 0;
            Perimeter = 0;
        }
        public void DisplayInfo(string strName)
        {
            throw new NotImplementedException();
        }
    }
}
