using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        #region Fields

        private string _firstName;
        private string _lastName;
        private string _email;
        private string _workAddress;

        #endregion

        #region Properties

        public string HomeAddress { get; set; }

        public string FirstName 
        {   get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            } 
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }

        public string WorkAddress
        {
            get
            {
                return _workAddress;
            }
            set
            {
                _workAddress = value;
            }
        }

        #endregion 
    }
}
