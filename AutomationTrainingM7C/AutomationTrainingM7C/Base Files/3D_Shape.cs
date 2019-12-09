using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using NUnit.Framework;

namespace AutomationTrainingM7C.Base_Files
{
    class _3D_Shape: _2D_Shape
    {
        public static double Volume;

        new public void DisplayInfo()
        {
            _3D_Shape.Name = "";
            _3D_Shape.BaseArea = 0;
            _3D_Shape.Perimeter = 0;
            _3D_Shape.Volume = 0;
        }
    }
}
