using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using NUnit.Framework;
using AutomationTrainingM7C.Ivan_Rodriguez_M7_Exercise;

namespace AutomationTrainingM7C.Base_Files
{
    public class _3D_Shape : _2D_Shape
    {
        new public double Area { get; set; }
        new public double Perimeter { get; set; }
        new public string Name { get; set; }
        new public double Volume { get; set; }

        new public void DisplayInfo()
        {
        }
    }
}
