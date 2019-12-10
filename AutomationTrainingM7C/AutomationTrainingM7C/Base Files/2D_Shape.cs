using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7C.Base_Files
{
    class 2D_Shape
    {
        string name = undefined;
        double Area = 0;
        double Perimeter = 0;
        
        public interface IShape
        {
        double Area { };
        double Perimeter { };
        string Name { };
        void DisplayInfo();
        }

    }

    class 3D_Shape
    {
    string Name = undefined;
    double Base = 0;
    double Area = 0;
    double Perimeter = 0;
    

    public interface IShape
    {
    double Volume { };
    void DisplayInfo();
    }
    }
}
