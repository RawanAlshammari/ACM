using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ACM.BLTest
{
    [TestClass]
    public class CutomerRepositoryTest
    {
        

        [TestMethod]

        
        public void RetrieveValide()
        {
            var customerRepository = new CutomerRepository(); //Arrange 
            var expected = new Customer(1)
            {
                EmailAdress = "R$#%^@hobiton.me", //Act
                FisrtName = "Rawan",
                LastName = "Khalid",

            };

            var actual = customerRepository.Retrieve(1);

            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

        }
       
            public void RetrieveExistingWithAddress()
            {
            var customerRepository = new ProductRepositoryTest();
            var expected = new Customer(1)
               {
                EmailAdress = "R$#%^@hobiton.me",
                FisrtName = "Rawan",
                LastName = "Khalid",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "Bag End",
                        StreetLine2 = "Bagshot rwo",
                        City = "Riyadh",
                        StateProvince = "Riyadh",
                        PostalCode = "13326",
                        Country = "Saudi Arabia",

                    },
                    new Address()
                    {
                 AddressType = 2,
                StreetLine1 = "Green Dragon",
                StreetLine2 = "badshot rwo",
                City = "Riyadh",
                StateProvince = "Riyadh",
                PostalCode = "12236",
                Country = "Saudi Arabia",
                    },

                }


            };


            Assert.AreEqual(expected.CustomerId, customerRepository.Retrieve((int)1).CustomerId);
            Assert.AreEqual(expected.EmailAddress, customerRepository.Retrieve((int)1).EmailAddress);
            Assert.AreEqual(expected.FirstName, customerRepository.Retrieve((int)1).FirstName);
            Assert.AreEqual(expected.LastName, customerRepository.Retrieve((int)1).LastName);

            for(int i = 0; i < 1; i++)
            {
                Assert.AreEqual(
                    expected.AddressList[i].AddressType, customerRepository.Retrieve((int)1).AddressList[i].Address);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, customerRepository.Retrieve((int)1).AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].City, customerRepository.Retrieve((int)1).AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].StateProvince, customerRepository.Retrieve((int)1).AddressList[i].StateProvince);
                Assert.AreEqual(expected.AddressList[i].Country, customerRepository.Retrieve((int)1).AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, customerRepository.Retrieve((int)1).AddressList[i].PostalCode);
            }
            
            
            




        }
    }
}
    

