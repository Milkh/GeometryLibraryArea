using NUnit.Framework;
using GeometryLibraryArea;

namespace GeometryLibraryArea.test
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void TestCircleArea()//�������� ������ ��� ����� 
        {
            double radius = 5;
            Circle circle = new Circle(radius);
            double expected = Math.PI * radius * radius;
            Assert.AreEqual(expected, circle.CalculateArea(), 1e-1);
        }

        [Test]
        public void TestCircleInvalidRadius()//�� �������� ������ ��� ����� 
        {
            Assert.Throws<ArgumentException>(() => new Circle(-5));
        }
    }

    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void TestTriangleAreaDefault()//������� �����������
        {
            double a = 8, b = 12, c = 10;
            Triangle triangle = new Triangle(a, b, c);
            double expected = 39.6;
            Assert.AreEqual(expected, triangle.CalculateArea(), 1e-1);
        }

        [Test]
        public void TestTriangleAreaRightAngled()// ������������� �����������
        {
            double a=4, b=3, c=5;
            Triangle triangle = new Triangle(a, b, c);
            double expected = 6;
            Assert.AreEqual(expected, triangle.CalculateArea(), 1e-1);
        }

        [Test]
        public void TestTriangleInvalidSides()// ����������� �� ����������
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 3));
        }

    }
}