using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7C.Jose_Cruz_M7_Exercise
{
    class Trapezium:Shape3D
    {
        public double dblA;
        public double dblB;
        public double dblC;
        public double dblD;
        public double dblH;
        public double dblW;
        public Trapezium()
        {
            dblA = 10;
            dblB = 20;
            dblC = 30;
            dblD = 40;
            dblH = 5;
            dblW = 10;
            strName = "Trapezium";
        }

        public Trapezium(string strNameT, double dblA1, double dblB1, double dblC1, double dblD1, double dblH1, double dblW1) {
            dblA = dblA1;
            dblB = dblB1;
            dblC = dblC1;
            dblD = dblD1;
            dblH = dblH1;
            dblW = dblW1;
            strName = strNameT;
        }

        public double fnCalcArea()
        {
            dblArea = (dblH * ((dblA + dblB) / 2));
            return dblArea;

        }
        public double fnCalcArea(double dblA2, double dblB2, double dblH2)
        {
            dblArea = (dblH2 * ((dblA2 + dblB2) / 2));
            return dblArea;

        }

        public double fnCalcPerimeter()
        {
            dblPerimeter = dblA + dblB + dblC + dblD;
            return dblPerimeter;
        }
        public double fnCalcPerimeter(double dblA3, double dblB3, double dblC3, double dblD3)
        {
            dblPerimeter = dblA3 + dblB3 + dblC3 + dblD3;
            return dblPerimeter;
        }

        public double fnCalcVolume()
        {
            dblVolume = dblArea * dblW;
            return dblVolume;
        }
        public double fnCalcVolume(double dblW4)
        {
            dblVolume = dblArea * dblW4;
            return dblVolume;
        }
    }
}
