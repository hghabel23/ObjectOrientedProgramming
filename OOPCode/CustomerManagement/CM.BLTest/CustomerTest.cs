using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CM.BL;
using System.Collections.Generic;

namespace CM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTest()
        {
            //--Arange
            Customer customer = new Customer();
            //customer.FirstName = "Hasti";
            customer.LastName = "Ghabelzadeh";

            //--Act
            var expected = "Ghabelzadeh";
            var actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RetrieveTest()
        {
            //--Arange
            var customerId = 1;
            //Create instance of a Customer
            var expected = new Customer(customerId)
            {
                FirstName = "Chris",
                LastName = "Smith",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressLine1 = "2535 Piedmont Rd",
                        City = "Atlanta",
                        Country = "USA",
                        State = "GA",
                        ZipCode = 30305
                    },
                    new Address()
                    {
                        AddressLine1 = "195 Main Rd",
                        City = "Chicago",
                        Country = "USA",
                        State = "IL",
                        ZipCode = 98213
                    }
                }
            };

            //--Act
            var customer = new Customer();
            var actual = customer.Retrieve(customerId);

            //--Assert
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.FullName, actual.FullName);
            Assert.AreEqual(expected.CustomerID, actual.CustomerID);

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressLine1, actual.AddressList[i].AddressLine1);
                Assert.AreEqual(expected.AddressList[i].AddressLine2, actual.AddressList[i].AddressLine2);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].ZipCode, actual.AddressList[i].ZipCode);
            }
        }
    }
}
