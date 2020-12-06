using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        public Customer(): this(0)
        {

        }
        public Customer(int customerId)
        {
            CustomerId = CustomerId;
            AdressList = new List<Address>();
        }
        public List<Address> AdressList { get; set; }
        public int CustomerId { get; private set; } // a away to prepare set and get using snippet propg 
        public int CustomerType { get; set; }
        public string EmailAddress { get; set; }// a way to prpare set/get using sippet using prop
        public string FirstName { get; set; }
        public string LastName // a way to set and get
        {
            get
            {
                return LastName;
            }
            set
            {
                LastName = value;
            }
        }
        public override string ToString() => FUllName;

        public string FUllName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }

        }
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;

        }
       
        public static int InstanceCount { get; set; }
        public string EmailAdress { get; set; }
        public string FisrtName { get; set; }
        public List<Address> AddressList { get; set; }
    }
    
}
    

