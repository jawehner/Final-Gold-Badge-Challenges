using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    public enum CustomerType { Former = 1, Current, Potential}
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public CustomerType TypeOfCustomer { get; set; }
        public string Email { get; set; }


        public Customer(int customerID, string firstName, string lastName, CustomerType typeOfCustomer, string email)
        {
            CustomerID = customerID;
            FirstName = firstName;
            LastName = lastName;
            TypeOfCustomer = typeOfCustomer;
            Email = email;
        }

        public Customer()
        {

        }
    }
}
