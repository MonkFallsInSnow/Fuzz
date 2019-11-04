using System;
using Fuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FuzzUnitTests.SetTests
{
    [TestClass]
    public class ShoulderSetTests
    {
        [TestMethod]
        public void LeftShoulder_RepresentativeValue()
        {
            double mid = 10;
            double end = 20;

            Set set = new LeftShoulderSet(mid, end);
            Assert.AreEqual(set.RepresentativeValue, 5);
        }

        [TestMethod]
        public void LeftShoulder_CalculateDOM_CrispValue_LessThanMid()
        {
            double mid = 10;
            double end = 20;
            double crispValue = 0;

            Set set = new LeftShoulderSet(mid, end);

            Assert.AreEqual(set.CalculateDOM(crispValue), 1);

            crispValue = 5;
            Assert.AreEqual(set.CalculateDOM(crispValue), 1);

            crispValue = -5;
            Assert.AreEqual(set.CalculateDOM(crispValue), 1);
        }

        [TestMethod]
        public void LeftShoulder_CalculateDOM_CrispValue_EqualToMid()
        {
            double mid = 10;
            double end = 20;
            double crispValue = mid;

            Set set = new LeftShoulderSet(mid, end);

            Assert.AreEqual(set.CalculateDOM(crispValue), 1);
        }

        [TestMethod]
        public void LeftShoulder_CalculateDOM_CrispValue_GreaterThanMid()
        {
            double mid = 10;
            double end = 20;
            double crispValue = 15;

            Set set = new LeftShoulderSet(mid, end);

            Assert.AreEqual(set.CalculateDOM(crispValue), 0.5);

            crispValue = end;
            Assert.AreEqual(set.CalculateDOM(crispValue), 0);

            crispValue = end + 10;
            Assert.AreEqual(set.CalculateDOM(crispValue), 0);
        }
    }
}
