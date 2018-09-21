using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.BL
{
    public class Customer
    {
        public AddressRepository addressRepository { get; set; }

        public Customer()
            :this(0)
        {

        }

        public Customer(int customerId)
        {
            CustomerID = customerId;
            AddressList = new List<Address>();
            addressRepository = new AddressRepository();
        }

        public int CustomerID { get; private set; }

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

        public List<Address> AddressList { get; set; }

        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);
            customer.AddressList = addressRepository.RetreivedByCustomerId(customerId).ToList();

            if(customerId == 1)
            {
                customer.FirstName = "Chris";
                customer.LastName = "Smith";
            }
            return customer;
        }

    }
}
