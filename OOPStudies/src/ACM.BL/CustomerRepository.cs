using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            AddressRepository = new AddressRepository();
        }

        private AddressRepository AddressRepository { get; set; }

        /// <summary>
        /// Retrieve one customer.
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            // Create the instnace of the Customer class
            // Pass in the requested id
            Customer customer = new Customer(customerId);

            // Code that retrieves the defined customer


            // Temporary hard-coded values to return a populated customer.
            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.AddressList = AddressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            return customer;
        }

        /// <summary>
        /// Saves the passed in customer.
        /// </summary>
        /// <returns></returns>
        public bool Save(Customer customer)
        {
            // Code that saves the passed in customer

            return true;
        }

    }
}
