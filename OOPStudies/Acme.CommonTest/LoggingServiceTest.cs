using ACM.BL;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteFileToTest()
        {
            // Arrange
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "RakeOfStorms",
                ProductDescription = "Kills crows by lightning!",
                CurrentPrice = 666M
            };
            changedItems.Add(product);

            // Act
            LoggingService.WriteToFile(changedItems);

            // Assert
            // Check the output to assert.
        }
    }
}
