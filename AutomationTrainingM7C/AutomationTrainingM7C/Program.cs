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
            Ellipsoid paramEllipsoid = new Ellipsoid("ParamEllipsoid", 120, 75, 200, 170, 250);

            Console.WriteLine("*******************************");
            trapezium.fnCalcArea();
            trapezium.fnCalcPerimeter();
            trapezium.fnCalcVolume();
            trapezium.fnDisplayInfo();
            trapezium.fnDisplayInfo3D();
            Console.WriteLine("*******************************");
            paramTrapezium.fnCalcArea();
            paramTrapezium.fnCalcPerimeter();
            paramTrapezium.fnCalcVolume();
            paramTrapezium.fnDisplayInfo();
            paramTrapezium.fnDisplayInfo3D();
            Console.WriteLine("************OverLoaded**********");
            paramTrapezium.fnCalcArea(135, 235, 400);
            paramTrapezium.fnCalcPerimeter(145, 145, 345, 445);
            paramTrapezium.fnCalcVolume(17.4);
            paramTrapezium.fnDisplayInfo();
            paramTrapezium.fnDisplayInfo3D();
            Console.WriteLine("*******************************");
            ellipsoid.fnCalcArea();
            ellipsoid.fnCalcPerimeter();
            ellipsoid.fnCalcVolume();
            ellipsoid.fnDisplayInfo();
            ellipsoid.fnDisplayInfo3D();
            Console.WriteLine("*******************************");
            paramEllipsoid.fnCalcArea();
            paramEllipsoid.fnCalcPerimeter();
            paramEllipsoid.fnCalcVolume();
            paramEllipsoid.fnDisplayInfo();
            paramEllipsoid.fnDisplayInfo3D();
            Console.WriteLine("************OverLoaded**********");
            paramEllipsoid.fnCalcArea(110, 80);
            paramEllipsoid.fnCalcPerimeter(115, 85);
            paramEllipsoid.fnCalcVolume(300, 220, 189);
            paramEllipsoid.fnDisplayInfo();
            paramEllipsoid.fnDisplayInfo3D();
            Console.WriteLine("*******************************");
            Console.ReadKey();
        }
    }
}
