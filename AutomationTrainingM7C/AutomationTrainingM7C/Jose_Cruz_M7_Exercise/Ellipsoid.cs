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

        public Ellipsoid(string strNameT, double dblMajorRadius0, double dblMinorRadius0, double dblMayorDiameter0, double dblMinorDiameter0, double dblEllipsoidSideWidth0)
        {
            dblMajorRadius = dblMajorRadius0;
            dblMinorRadius = dblMinorRadius0;
            dblMayorDiameter = dblMayorDiameter0;
            dblMinorDiameter = dblMinorDiameter0;
            dblEllipsoidSideWidth = dblEllipsoidSideWidth0;
            strName = strNameT;
        }

        public double fnCalcArea()
        {
            dblArea = (dblMajorRadius * dblMinorRadius * dblPi);
            return dblArea;

        }
        public double fnCalcArea(double dblMajorRadius1, double dblMinorRadius1)
        {
            dblArea = (dblMajorRadius1 * dblMinorRadius1 * dblPi);
            return dblArea;

        }

        public double fnCalcPerimeter()
        {
            dblPerimeter = (2*dblPi)*( Math.Sqrt((dblMinorRadius*dblMinorRadius)+(dblMajorRadius*dblMajorRadius)/2)) ;
            return dblPerimeter;
        }
        public double fnCalcPerimeter(double dblMajorRadius2, double dblMinorRadius2)
        {
            dblPerimeter = (2 * dblPi) * (Math.Sqrt((dblMinorRadius2 * dblMinorRadius2) + (dblMajorRadius2 * dblMajorRadius2) / 2));
            return dblPerimeter;
        }

        public double fnCalcVolume()
        {
            dblVolume = (((4 * dblPi) / 3) * dblMayorDiameter * dblMinorDiameter * dblEllipsoidSideWidth);
            return dblVolume;
        }
        public double fnCalcVolume(double dblMayorDiameter3, double dblMinorDiameter3, double dblEllipsoidSideWidth3)
        {
            dblVolume = (((4 * dblPi) / 3) * dblMayorDiameter3 * dblMinorDiameter3 * dblEllipsoidSideWidth3);
            return dblVolume;
        }

    }
}
