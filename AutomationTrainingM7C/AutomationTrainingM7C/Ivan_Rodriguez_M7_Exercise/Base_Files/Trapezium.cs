using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace AutomationTrainingM7C.Ivan_Rodriguez_M7_Exercise.Base_Files
{
    class Trapezium : _2D_Shape
    {
        public double a;
        public double b;
        public double h;
        public Trapezium()
        {
            a = 3;
            b = 4;
            h = 5;
        }
        public Trapezium( double a2, double b2, double h2)
        {
            a2 = a;
            b2 = b;
            h2 = h;
        }
        class AreaCalc : Trapezium
        { 
        public AreaCalc(double AreaRes)
        {
            AreaRes = ((a + b) / 2 * h);
        }
        }
    }
}
