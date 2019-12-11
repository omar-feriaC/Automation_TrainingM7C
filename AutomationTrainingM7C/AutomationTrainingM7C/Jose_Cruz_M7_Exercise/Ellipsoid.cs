using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7C.Jose_Cruz_M7_Exercise
{
    class Ellipsoid:Shape3D
    {
        public double dblPi=3.1416;
        public double dblMajorRadius;
        public double dblMinorRadius;
        public double dblMayorDiameter;
        public double dblMinorDiameter;
        public double dblEllipsoidSideWidth;
        public Ellipsoid()
        {
            dblMajorRadius = 10;
            dblMinorRadius = 20;
            dblMayorDiameter = 30;
            dblMinorDiameter = 40;
            dblEllipsoidSideWidth = 5;
            strName = "Ellipsoid";
        }

        public Ellipsoid(string strNameT, double dblMajorRadius1, double dblMinorRadius1, double dblMayorDiameter1, double dblMinorDiameter1, double dblEllipsoidSideWidth1/*, double dblEllipsoidSideW1*/)
        {
            dblMajorRadius = dblMajorRadius1;
            dblMinorRadius = dblMinorRadius1;
            dblMayorDiameter = dblMayorDiameter1;
            dblMinorDiameter = dblMinorDiameter1;
            dblEllipsoidSideWidth = dblEllipsoidSideWidth1;
            strName = strNameT;
        }

        public double fnCalcArea()
        {
            dblArea = (dblMajorRadius * dblMinorRadius * dblPi);
            return dblArea;

        }
        public double fnCalcArea(double dblMajorRadius1, double dblMinorRadius1)
        {
            dblArea = (dblMajorRadius * dblMinorRadius * dblPi);
            return dblArea;

        }

        public double fnCalcPerimeter()
        {
            dblPerimeter = (2*dblPi)*( Math.Sqrt((dblMinorRadius*dblMinorRadius)+(dblMajorRadius*dblMajorRadius)/2)) ;
            return dblPerimeter;
        }
        public double fnCalcPerimeter(double dblMajorRadius, double dblMinorRadius)
        {
            dblPerimeter = (2 * dblPi) * (Math.Sqrt((dblMinorRadius * dblMinorRadius) + (dblMajorRadius * dblMajorRadius) / 2));
            return dblPerimeter;
        }

        public double fnCalcVolume()
        {
            dblVolume = (((4 * dblPi) / 3) * dblMayorDiameter * dblMinorDiameter * dblEllipsoidSideWidth);
            return dblVolume;
        }
        public double fnCalcVolume(double dblMayorDiameter, double dblMinorDiameter, double dblEllipsoidSideWidth)
        {
            dblVolume = (((4 * dblPi) / 3) * dblMayorDiameter * dblMinorDiameter * dblEllipsoidSideWidth);
            return dblVolume;
        }

    }
}
