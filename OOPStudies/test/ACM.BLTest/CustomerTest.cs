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

        [TestMethod]
        public void StaticCountTest()
        {
            // Arrange
            var beforeCount = Customer.InstanceCount;

            var c1 = new Customer();
            c1.FirstName = "Bilbo";


            var c2 = new Customer();
            c2.FirstName = "Frodo";


            var c3 = new Customer();
            c3.FirstName = "Rosie";

            // Act

            // Assert
            Assert.AreEqual(beforeCount + 3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            // Arrange
            var customer = new Customer
            {
                LastName = "Baggins",
                EmailAddress = "fbaggings@hobbiton.me"
            };

            var expected = true;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            // Arrange
            var customer = new Customer
            {
                EmailAddress = "fbaggings@hobbiton.me"
            };

            var expected = false;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingEmailAddress()
        {
            // Arrange
            var customer = new Customer
            {
                LastName = "Baggins",
            };

            var expected = false;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
