﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // Arrange
            var productRepository = new ProductRepository();

            var expected = new Product(2)
            {
                ProductName = "Sunflowers",
                ProductDescription = "Assorted Size of 4 Bright Yellow Mini Sunflowers",
                CurrentPrice = 15.96M
            };

            // Act
            var actual = productRepository.Retrieve(2);

            // Assert
            Assert.AreEqual(expected.ProductId, actual.ProductId);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        }

        [TestMethod]
        public void SaveTestValid()
        {
            // Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = 18M,
                ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            // Act
            var actual = productRepository.Save(updatedProduct);


            // Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void SaveTestMissingPrice()
        {
            // Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = null,
                ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            // Act
            var actual = productRepository.Save(updatedProduct);


            // Assert
            Assert.AreEqual(false, actual);
        }
    }
}
