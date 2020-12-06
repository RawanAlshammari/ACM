using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class CutomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            Customer customer = new Customer
            {
                FirstName = "Rawan",
                LastName = "Khalid"
            };

            string expected = "Khalid, Rawan";


            String actual = customer.FirstName;

            Assert.AreEqual(expected, actual);
        }
        public void FullNameFisrtNameEmpty()
        {
            Customer customer = new Customer
            {
                LastName = "Khalid"
            };
            string expected = "Khalid";

            string actual = customer.LastName;

            Assert.AreEqual(expected, actual);
        }
        public void FullNameLastNAmeEmpty()
        {
            Customer customer = new Customer
            {
                FirstName = "Rawan"
            };

            string expected = "Rawan";

            string actual = customer.FirstName;

            Assert.AreEqual(expected, actual);

        }
        public void StaticTest()
        {
            var c1 = new Customer();
            c1.FirstName = "Rawan";
            Customer.InstanceCount += 1;
            var c2 = new Customer();
            c2.FirstName = "Satah";
            Customer.InstanceCount += 1;
            var c3 = new Customer();
            c3.FirstName = "Norah";
            Customer.InstanceCount += 1;

            Assert.AreEqual(3, Customer.InstanceCount);

        
        }
        public void ValidateValid()
        {
            var customer = new Customer
            {
                LastName = "Khalid",
                EmailAddress = "R$#%^@hobiton.me"

            };
            var excepted = true;

            var actual = customer.Validate();

            Assert.AreEqual(excepted, actual);
        }
        public void ValidateMissingLastName()
        {
            var customer = new Customer()
            {
                EmailAddress = "R$#%^@hobiton.me"

            };
            var expected = false;

            var actual = false;

            Assert.AreEqual(expected, actual);

        }

    }
}
