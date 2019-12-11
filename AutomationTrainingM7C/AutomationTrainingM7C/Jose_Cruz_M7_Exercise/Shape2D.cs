using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTrainingM7C.M7Exercise.NugetPkg;

namespace AutomationTrainingM7C.Jose_Cruz_M7_Execise
{
    class Shape2D:IShape
    {
        //IShape ishape;

        public double dblArea;
        public double dblPerimeter;

        public string strName { get ; set; }

        public void fnDisplayInfo()
        {
            Console.WriteLine("Name: " + strName);
            Console.WriteLine("Area: " + dblArea);
            Console.WriteLine("Perimeter: " + dblPerimeter);
            Console.WriteLine("");
        }

        public Shape2D() {
            strName = "";
            dblArea = 0;
            dblPerimeter = 0;
        }
    }
}
