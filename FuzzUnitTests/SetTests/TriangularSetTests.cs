using System;
using Fuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FuzzUnitTests
{
    [TestClass]
    public class TriangularSetTests
    {
        [TestMethod]
        public void CalculateDom_TriangularSet_CrispValue_LessThanMid()
        {
            double start = 0;
            double mid = 10;
            double end = 20;

            double crispValue = start;

            Set set = new TriangularSet(start, mid, end);
            Assert.AreEqual(set.CalculateDOM(crispValue), 0);

            crispValue = 5;
            Assert.AreEqual(set.CalculateDOM(crispValue), 0.5);
        }

        [TestMethod]
        public void CalculateDom_TriangularSet_CrispValue_EqualToMid()
        {
            double start = 0;
            double mid = 10;
            double end = 20;

            double crispValue = 10;

            Set set = new TriangularSet(start, mid, end);
            Assert.AreEqual(set.CalculateDOM(crispValue), 1);
        }

        [TestMethod]
        public void CalculateDom_TriangularSet_CrispValue_GreaterThanMid()
        {
            double start = 0;
            double mid = 10;
            double end = 20;

            double crispValue = 15;

            Set set = new TriangularSet(start, mid, end);
            Assert.AreEqual(set.CalculateDOM(crispValue), 0.5);

            crispValue = end;
            Assert.AreEqual(set.CalculateDOM(crispValue), 0);
        }


        [TestMethod]
        public void CalculateDom_TriangularSet_CrispValue_LessThanStart()
        {
            double start = 10;
            double mid = 20;
            double end = 30;
            double crispValue = 5;

            Set set = new TriangularSet(start, mid, end);
            Assert.AreEqual(set.CalculateDOM(crispValue), 0);
        }

        [TestMethod]
        public void CalculateDom_TriangularSet_CrispValue_GreaterThanEnd()
        {
            double start = 0;
            double mid = 10;
            double end = 20;
            double crispValue = 30;

            Set set = new TriangularSet(start, mid, end);
            Assert.AreEqual(set.CalculateDOM(crispValue), 0);
        }

    }
}
