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
        public string Name { get; set; }


        public Shape2D()
		{
            Name = null;
            Area = 0;
            Perimeter = 0;
			
		}
		
		public void DisplayInfo ()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Area);
            Console.WriteLine(Perimeter);

        }
		
    }
}
