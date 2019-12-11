using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Jose_Pasos_M7_Excercise
{
    class Cone : _3D_Shape
    {
        //Attributes
        double Height;
        double Radio;

        //Constructors
        public Cone()
        {
            Height = 0;
            Radio = 0;
        }

        public Cone(double h, double r)
        {
            Height = h;
            Radio = r;
        }

        //Methods
        public void GetBaseArea()
        {
            Area = 3.14 * (Radio * Radio);
        }

        public void GetVolume()
        {
            Volume = (3.14 * (Radio * Radio) * Height) / 3;
        }
      
    }
}
