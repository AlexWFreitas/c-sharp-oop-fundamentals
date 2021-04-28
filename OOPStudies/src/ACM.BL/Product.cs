using Acme.Common;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
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

        public override string ToString() => ProductName;

        public string Log() => $"{ProductId}: {ProductName} Detail: {ProductDescription} Status: {EntityState.ToString()}";

        #endregion

        #region Properties and Fields

        public int ProductId { get; private set; }

        public string ProductName 
        { 
            get
            {
                return _productName.InsertSpaces();
            }

            set
            {
                _productName = value;
            }
        }

        private string _productName;

        public string ProductDescription { get; set; }

        public decimal? CurrentPrice { get; set; }


        static int InstanceCount { get; set; }

        #endregion
    }
}
