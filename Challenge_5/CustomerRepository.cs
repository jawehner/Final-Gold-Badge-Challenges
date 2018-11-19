using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    class CustomerRepository
    {
        List<Customer> _customers = new List<Customer>();

        public void AddCustomerToList(Customer customer)
        {
            _customers.Add(customer);
        }

        public List<Customer> GetList()
        {
            return _customers;
        }
    }
}
