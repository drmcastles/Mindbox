using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAreas
{
    public class Triangle : FigureArea
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;

         // проверка на наличие прямого угла в созданном треугольнике
            if (Math.Pow(sideA, 2) + Math.Pow(sideB, 2) == Math.Pow(sideC, 2) ||
               (Math.Pow(sideB, 2) + Math.Pow(sideC, 2) == Math.Pow(sideA, 2)) ||
               (Math.Pow(sideB, 2) + Math.Pow(sideC, 2) == Math.Pow(sideA, 2)))
            {
                Console.WriteLine("This triangle with an angle of 90 degrees.");
            }

        }
        //вычисление площади треугольника по трем сторонам
        public override double Area()
        {
            double p = (sideA + sideB + sideC) / 2;
            double triangleArea = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            Console.WriteLine($"Triangle area: {Math.Round(triangleArea, 2)}");
            return Math.Round(triangleArea, 2);
        }
    }
}
