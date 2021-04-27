using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Product : EntityBase
    {
        #region Constructors

        public Product()
        {
            Product.InstanceCount++;
        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        #endregion

        #region Methods

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        public Product Retrieve(int productId)
        {
            // Code
            return new Product();
        }

        public bool Save()
        {
            var isSaved = true;
            
            // Code

            return isSaved;
        }

        public override string ToString() => ProductName;

        #endregion

        #region Properties and Fields

        public int ProductId { get; private set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public decimal? CurrentPrice { get; set; }

        static int InstanceCount { get; set; }

        #endregion
    }
}
