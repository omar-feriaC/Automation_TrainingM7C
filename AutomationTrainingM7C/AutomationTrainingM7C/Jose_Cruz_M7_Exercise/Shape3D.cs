using AutomationTrainingM7C.Jose_Cruz_M7_Execise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7C.Jose_Cruz_M7_Exercise
{
    class Shape3D:Shape2D
    {
        public double dblVolume;

        public void fnDisplayInfo3D()
        {
            Console.WriteLine("Name: "+strName);
            Console.WriteLine("Area: " + dblArea);
            Console.WriteLine("Perimeter: " + dblPerimeter);
            Console.WriteLine("Volume: " + dblVolume);
            Console.ReadKey();
        }

        public Shape3D()
        {
            strName = "";
            dblArea = 0;
            dblPerimeter = 0;
            dblVolume = 0;
        }
    }
}
