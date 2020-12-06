using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {

        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);


            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot rwo";
                address.City = "Riyadh";
                address.StateProvince = "Riyadh";
                address.PostalCode = "13326";
                address.Country = "Saudi Arabia";
               
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int CustomerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
             AddressType = 1,
             StreetLine1 = "Bag End",
             StreetLine2 = "Bagshot rwo",
             City = "Riyadh",
             StateProvince = "Riyadh",
             PostalCode = "13326",
             Country = "Saudi Arabia",
        };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Green Dragon",
                StreetLine2 = "badshot rwo",
                City = "Riyadh",
                StateProvince = "Riyadh",
                PostalCode = "12236",
                Country = "Saudi Arabia",
            };
            addressList.Add(address);
            return addressList;

 
        }
        public bool Save(Address address)
        {
            return true;
        }
        }
}
