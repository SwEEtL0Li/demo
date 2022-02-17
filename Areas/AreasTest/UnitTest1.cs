using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Areas;
using Areas.Figures;
using static System.Math;

namespace AreasTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CircleNoValues()
        {
            Areas.Figures.Circle circle = new Areas.Figures.Circle();
            var area = circle.Area;
            Assert.AreEqual(0, area);
        }
        [TestMethod]
        public void CircleValues()
        {
            Areas.Figures.Circle circle = new Areas.Figures.Circle(8);
            var P = PI * Pow(8, 2);
            var area = circle.Area;
            Assert.AreEqual(P, area);
        }
        [TestMethod]
        public void TriangNoValues()
        {
            Areas.Figures.Triang triang = new Areas.Figures.Triang();
            var area = triang.Area;
            Assert.AreEqual(0, area);
        }
        [TestMethod]
        public void TriangValues()
        {
            Areas.Figures.Triang triang = new Areas.Figures.Triang(3, 4, 5);
            var area = triang.Area;
            Assert.AreEqual(6, area);            
        }
        [TestMethod]
        public void RightTriang()
        {
            Areas.Figures.Triang triang = new Areas.Figures.Triang(3, 4, 5);
            bool Right = triang.RightTriang();
            Assert.IsTrue(Right);
        }
        [TestMethod]
        public void Area()
        {
            Areas.Figures.Figure figure = new Areas.Figures.Figure(new Circle());
            var area = figure.Area;
            Assert.AreEqual(0, area);
        }

    }
}
