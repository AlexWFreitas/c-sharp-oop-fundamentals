using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    class Address
    {
        #region Constructor

        public Address()
        {

        }

        public Address(int addressId)
        {
            AddressId = addressId;
        }

        #endregion

        #region Properties and Fields

        public int AddressId { get; private set; }
        public int AddressType { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }

        #endregion

        #region Methods

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(StreetLine1)) isValid = false;
            if (string.IsNullOrWhiteSpace(City)) isValid = false;
            if (string.IsNullOrWhiteSpace(State)) isValid = false;
            if (string.IsNullOrWhiteSpace(Country)) isValid = false;
            if (string.IsNullOrWhiteSpace(PostalCode)) isValid = false;

            return isValid;
        }

        #endregion
    }
}
