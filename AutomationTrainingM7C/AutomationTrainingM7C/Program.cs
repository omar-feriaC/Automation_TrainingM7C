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
            Trapezium paramTrapezium = new Trapezium("ParamTrapezium",100, 200, 300, 400, 150, 120);
            Ellipsoid ellipsoid = new Ellipsoid();
            Ellipsoid paramEllipsoid = new Ellipsoid("ParamEllipsoid", 100, 75, 200, 150, 250);
            trapezium.fnCalcArea();
            trapezium.fnCalcPerimeter();
            trapezium.fnCalcVolume();
            trapezium.fnDisplayInfo();
            trapezium.fnDisplayInfo3D();

            paramTrapezium.fnCalcArea();
            paramTrapezium.fnCalcPerimeter();
            paramTrapezium.fnCalcVolume();
            paramTrapezium.fnDisplayInfo();
            paramTrapezium.fnDisplayInfo3D();


            ellipsoid.fnCalcArea();
            ellipsoid.fnCalcPerimeter();
            ellipsoid.fnCalcVolume();
            ellipsoid.fnDisplayInfo();
            ellipsoid.fnDisplayInfo3D();

            paramEllipsoid.fnCalcArea();
            paramEllipsoid.fnCalcPerimeter();
            paramEllipsoid.fnCalcVolume();
            paramEllipsoid.fnDisplayInfo();
            paramEllipsoid.fnDisplayInfo3D();

            Console.ReadKey();
        }
    }
}
