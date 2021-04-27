using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class ProductRepository
    {
        /// <summary>
        ///  Retrieves the product related to productId.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            // New instance of Product.
            var product = new Product(productId);

            // Hard-coded workaround before implementation
            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size of 4 Bright Yellow Mini Sunflowers";
                product.CurrentPrice = 15.96M; // Type Money or Decimal
            }

            return product;
        }

        /// <summary>
        /// Saves a product.
        /// </summary>
        /// <returns></returns>
        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        // Call an Insert Stored Procedure
                    }
                    else
                    {
                        // Call an Update Stored Procedures
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
