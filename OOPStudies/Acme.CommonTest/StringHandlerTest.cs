    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Acme.Common;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesValid()
        {
            // Arrange
            var source = "SonicScrewdriverGamma";
            var expected = "Sonic Screwdriver Gamma";

            // Act
            var actual = source.InsertSpaces();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {
            // Arrange
            var source = "Sonic Screwdriver the Gamma";
            var expected = "Sonic Screwdriver the Gamma";

            // Act
            var actual = source.InsertSpaces();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
