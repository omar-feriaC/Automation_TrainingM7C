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

        public Trapezium(double dblA1, double dblB1, double dblC1, double dblD1, double dblH1, double dblW1) {
            dblA = dblA1;
            dblB = dblB1;
            dblC = dblC1;
            dblD = dblD1;
            dblH = dblH1;
            dblW = dblW1;
            strName = "Trapezium";
        }

        public double fnCalcArea()
        {
            dblArea = (dblH * ((dblA + dblB) / 2));
            return dblArea;

        }
        public double fnCalcArea(double dblA, double dblB, double dblH) {
            dblArea = (dblH * ((dblA + dblB) / 2));
            return dblArea;
            
        }

        public double fnCalcPerimeter()
        {
            dblPerimeter = dblA + dblB + dblC + dblD;
            return dblPerimeter;
        }
        public double fnCalcPerimeter(double dblA, double dblB, double dblC, double dblD) {
            dblPerimeter = dblA + dblB + dblC + dblD;
            return dblPerimeter;
        }

        public double fnCalcVolume()
        {
            dblVolume = dblArea * dblW;
            return dblVolume;
        }
        public double fnCalcVolume(double dblW) {
            dblVolume = dblArea * dblW;
            return dblVolume;
        }
    }
}
