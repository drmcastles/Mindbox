using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculateAreas;
namespace ClassLibraryTest
{
    [TestClass]
    public class CalculateAreasTests
    {
        [TestMethod]
        public void CircleAreaTests()
        {
            // исходные данные
            double radius = 1;
            // ожидаемый результат
            double expected = 3.14;

            //cоздаем круг с указанными параметрами и вычисляем его площадь
            Circle circle = new Circle(radius);
            double actual = circle.Area();

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TriangleAreaTest()
        {
            // исходные данные
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            // ожидаемый результат
            double expected = 6;

            //cоздаем треугольник с указанными параметрами и вычисляем его площадь
            Triangle triangle = new Triangle(sideA,sideB,sideC);
            double actual = triangle.Area();

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FigureAreaTest_3params()
        {
            // ожидаемый результат
            double expected = 6;

            //cоздаем фигуру
            Figure figureT = new Figure();
            //указываем 3 параметра и вычисляем площадь фигуры (треугольника)
            double actual = figureT.FigureArea(3, 4, 5);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FigureAreaTest_1params()
        {
            // ожидаемый результат
            double expected = 3.14;

            //cоздаем фигуру
            Figure figureC = new Figure();
            //указываем 1 параметр и вычисляем площадь фигуры (круга)
            double actual = figureC.FigureArea(1);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

    }
} 

