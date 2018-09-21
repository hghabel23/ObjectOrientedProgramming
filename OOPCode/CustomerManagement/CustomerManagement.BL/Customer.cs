using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagement.BL
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private string _fullName;
        public string FullName
        {
            get
            {
                _fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(_fullName))
                    {
                        _fullName += ", ";
                    }
                }
                _fullName += FirstName;
                return _fullName;
            }
        }
    }
}
