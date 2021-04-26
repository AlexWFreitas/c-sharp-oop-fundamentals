using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Order
    {
        #region Constructors

        public Order()
        {
            Order.InstanceCount++;
        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        #endregion

        #region Methods

        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

        #endregion

        #region Field

        #endregion

        #region Properties

        public int OrderId { get; private set; }

        public Customer Customer { get; set; }

        public DateTimeOffset? OrderDate { get; set; }

        public string ShippingAddress { get; set; }

        public List<OrderItem> OrderItems { get; set; }

        static int InstanceCount { get; set; }

        #endregion
    }
}
