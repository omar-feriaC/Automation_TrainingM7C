using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7C.Alfonso_medina_M7_Excercise
{
    class Shape2D : IShape
    {

		protected double Area { get; set; }
        protected double Perimeter { get; set; }


        public Shape2D()
		{
			String name = "Undefined";
            Shape2D figure = new Shape2D();
            figure.Area = 0;
            figure.Perimeter = 0;
			
		}
		
		public void DisplayInfo ()
        {
            Console.WriteLine(this.Area);
            Console.WriteLine(this.Perimeter);

        }


		
    }
}
