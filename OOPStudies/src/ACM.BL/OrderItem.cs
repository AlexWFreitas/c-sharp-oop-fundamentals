using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderItem : EntityBase
    {
        #region Constructors

        public OrderItem()
        {
            OrderItem.InstanceCount++;
        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        #endregion

        #region Methods

        public override bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }

        public OrderItem Retrieve(int productId)
        {
            // Code
            return new OrderItem();
        }

        public bool Save()
        {
            var isSaved = true;

            // Code

            return isSaved;
        }

        #endregion

        #region Field

        #endregion

        #region Properties

        public int OrderItemId { get; private set; }

        public int ProductId { get; set; }

        public int Quantity{ get; set; }

        public decimal? PurchasePrice{ get; set; }

        static int InstanceCount { get; set; }

        #endregion
    }
}
