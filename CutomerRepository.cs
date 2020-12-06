using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CutomerRepository
    {
        public CutomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        public AddressRepository addressRepository { get; set; }


        public Customer Retrieve(int customerId)
        {
        Customer customer = new Customer(customerId);

            if(customerId == 1)
            {
                customer.EmailAddress = "R$#%^@hobiton.me";
                customer.FirstName = "Rawan";
                customer.LastName = "Khalid";
                customer.AdressList = addressRepository.RetrieveByCustomerId(customerId).ToList();

                

            }

            return customer;
        }
        public bool Save()
        {
            return true;
        }
    }
}
