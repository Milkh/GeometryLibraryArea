using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibraryArea
{
    public class Triangle : IFigure
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        //Конструктор класса с проверкой на существование треугольника

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("Отрицательная сторона");
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
                throw new ArgumentException("Такого треугольника не существует (одна из сторон больше суммы двух других)");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        //Вычесление площади треугольника
        public double CalculateArea()
        {
           
            double[] sides = { SideA, SideB, SideC };
            Array.Sort(sides);
            bool isRightAngled = Math.Abs(Math.Pow(sides[2], 2) - (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))) < 1e-10;// (a² - b² - c²=0)

            if (isRightAngled)
            {
                return 0.5 * sides[0] * sides[1];
            }
            else
            {
                // Формала через полупериметр
                double P = (SideA + SideB + SideC) / 2;
                return Math.Sqrt(P * (P - SideA) * (P - SideB) * (P - SideC));
            }
        }
    }
}