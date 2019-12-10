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
            trapezium.fnCalcArea();
            trapezium.fnCalcPerimeter();
            trapezium.fnCalcVolume();
            trapezium.fnDisplayInfo();
            trapezium.fnDisplayInfo3D();
        }
    }
}
