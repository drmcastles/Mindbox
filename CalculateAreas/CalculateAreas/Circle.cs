using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAreas
{
    public class Circle : FigureArea
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;

        }
        
        public override double Area()
        {
            double circleArea = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"Circle area = {circleArea}");
            return Math.Round(circleArea, 2);

        }

    }
}
