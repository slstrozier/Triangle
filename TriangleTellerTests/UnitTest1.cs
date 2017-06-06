using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TriangleTellerTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_That_Triangle_Type_Equilateral()
        {
            Triangle.TriangleType expected = Triangle.TriangleType.Equilateral;
            Triangle.TriangleType result = Triangle.Triangle.GetTriangleType(60, 60, 60);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_That_Triangle_Type_Isosceles()
        {
            Triangle.TriangleType expected = Triangle.TriangleType.Isosceles;
            Triangle.TriangleType result = Triangle.Triangle.GetTriangleType(30, 30, 20);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_That_Triangle_Type_Scalene()
        {
            Triangle.TriangleType expected = Triangle.TriangleType.Scalene;
            Triangle.TriangleType result = Triangle.Triangle.GetTriangleType(50, 40, 30);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_That_Triangle_Type_NotTriangle()
        {
            Triangle.TriangleType expected = Triangle.TriangleType.Invalid;
            Triangle.TriangleType result = Triangle.Triangle.GetTriangleType(-60, 75, 82);

            Assert.AreEqual(expected, result);
        }
    }
}
