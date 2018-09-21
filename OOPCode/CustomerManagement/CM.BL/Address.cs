using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.BL
{
    public class Address
    {
        public Address()
        {

        }

        public Address(int addressId)
        {
            AddressID = addressId;
        }

        public int AddressID { get; private set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
    }
}
