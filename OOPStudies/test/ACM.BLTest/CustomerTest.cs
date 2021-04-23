using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "John",
                LastName = "Torque"
            };

            string expected = "Torque, John";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstEmpty()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                LastName = "Torque"
            };

            string expected = "Torque";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastEmpty()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "John"
            };

            string expected = "John";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer
            {
            };

            string expected = "";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
