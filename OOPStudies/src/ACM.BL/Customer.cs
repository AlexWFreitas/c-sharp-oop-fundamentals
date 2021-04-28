using System.Collections.Generic;
using Acme.Common;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {
        #region Constructor

        public Customer() : this(0)
        {
        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
            Customer.InstanceCount++;
        }

        #endregion

        #region Properties and Fields

        public static int InstanceCount { get; set; }
        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Address> AddressList { get; set; }

        public string FullName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(FirstName) && string.IsNullOrWhiteSpace(LastName))
                    return "";
                if(string.IsNullOrWhiteSpace(LastName))
                    return FirstName;
                if (string.IsNullOrWhiteSpace(FirstName))
                    return LastName;
                return LastName + ", " + FirstName; 
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Validates the customer data.
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        public override string ToString() => FullName;

        public string Log() => $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";

        #endregion
    }
}
