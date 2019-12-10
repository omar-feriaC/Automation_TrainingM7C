using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using AutomationTrainingM7C.Jose_Cruz_M7_Exercise;

namespace AutomationTrainingM7C
{
    class Program
    {
        static void Main(string[] args)
        {
            Trapezium trapezium = new Trapezium();
            Trapezium trapezium1 = new Trapezium("ParamTrapezium",100, 200, 300, 400, 150, 120);
            trapezium.fnCalcArea();
            trapezium.fnCalcPerimeter();
            trapezium.fnCalcVolume();
            trapezium.fnDisplayInfo();
            trapezium.fnDisplayInfo3D();
            trapezium1.fnCalcArea();
            trapezium1.fnCalcPerimeter();
            trapezium1.fnCalcVolume();
            trapezium1.fnDisplayInfo();
            trapezium1.fnDisplayInfo3D();
            Console.ReadKey();
        }
    }
}
