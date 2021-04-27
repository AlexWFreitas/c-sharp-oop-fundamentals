using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ACM.BL
{
    public class Order : EntityBase
    {
        #region Constructors

        public Order() : this(0)
        {
        }

        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
            Order.InstanceCount++;
        }

        #endregion

        #region Methods

        public override bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

        #endregion

        #region Properties and Fields

        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        static int InstanceCount { get; set; }

        #endregion
    }
}
