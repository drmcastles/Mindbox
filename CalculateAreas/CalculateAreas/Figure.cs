using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAreas
{
    public class Figure
    {
        //класс для создания и вычисления площадей фигур без явного указания их типа
        public Figure()
        {
        }
        public double FigureArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double triangleArea = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"This is triangle with area: {Math.Round(triangleArea, 5)}");
            return Math.Round(triangleArea, 5);
        }
        public double FigureArea(double a)
        {
            double circleArea = Math.PI * Math.Pow(a, 2);
            Console.WriteLine($"This circle with area: {Math.Round(circleArea, 2)}");
            return Math.Round(circleArea, 2); 
        }
    }
}

