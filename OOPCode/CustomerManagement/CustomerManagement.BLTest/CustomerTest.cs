using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CM.BL;

namespace CustomerManagement.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTest()
        {
            //--Arg
            Customer customer = new Customer();
            //customer.FirstName = "Hasti";
            customer.LastName = "Ghabelzadeh";

            //--Act
            var expected = "Ghabelzadeh";
            var actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
