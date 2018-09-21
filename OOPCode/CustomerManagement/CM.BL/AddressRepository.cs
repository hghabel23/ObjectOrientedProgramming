using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.BL
{
    public class AddressRepository
    {
        /// <summary>
        /// Retrieve one address.
        /// </summary>
        public Address Retrieve(int addressId)
        {
            //create an instance of the Address Class
            Address address = new Address();

            if (addressId == 1)
            {
                address.AddressLine1 = "2535 Piedmont Rd";
                address.City = "Atlanta";
                address.Country = "USA";
                address.State = "GA";
                address.ZipCode = 30305;
            }
            return address;
        }

        /// <summary>
        /// Retrieve multiple address for one customerId.
        /// </summary>
        /// <param name="customerId"></param>
        public IEnumerable<Address> RetreivedByCustomerId(int customerId)
        {
            var addressList = new List<Address>();

            if (customerId == 1)
            {
                Address address = new Address(1)
                {
                    AddressLine1 = "2535 Piedmont Rd",
                    City = "Atlanta",
                    Country = "USA",
                    State = "GA",
                    ZipCode = 30305
                };
                addressList.Add(address);

                address = new Address(2)
                {
                    AddressLine1 = "195 Main Rd",
                    City = "Chicago",
                    Country = "USA",
                    State = "IL",
                    ZipCode = 98213
                };
                addressList.Add(address);
            }

            return addressList;
        }
        
    }
}
