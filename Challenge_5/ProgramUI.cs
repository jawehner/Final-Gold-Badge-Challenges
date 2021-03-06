﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    class ProgramUI
    {
        CustomerRepository _customerRepo = new CustomerRepository();

        public List<Customer> _customers = new List<Customer>();

        public void Run()
        {
            _customers = _customerRepo.GetList();
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Choose an action:" +
                    "\n1. Create new customer" +
                    "\n2. Update customer info" +
                    "\n3. See all customers" +
                    "\n4. Delete customer" +
                    "\n7. Exit");

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        CreateNewCustomer();
                        break;
                    case 2:
                        UpdateCustomer();
                        break;
                    case 3:
                        SeeAllCustomers();
                        break;
                    case 4:
                        RemoveCustomer();
                        break;
                    case 5:
                        isRunning = false;
                        Console.WriteLine("Goodbye!");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Invalid response.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        private void SeeAllCustomers()
        {
            foreach (Customer customer in _customers)
            {
                Console.WriteLine($"\nName: {customer.FirstName} {customer.LastName} " +
                    $"\nID Number: {customer.CustomerID} \nEmail Message: {customer.Email}\n");
            }
        }

        private void CreateNewCustomer()
        {
            Customer newCustomer = new Customer();

            Console.WriteLine("Enter the customer's first name:");
            newCustomer.FirstName = Console.ReadLine();

            Console.WriteLine("Enter the customer's last name:");
            newCustomer.LastName = Console.ReadLine();

            Console.WriteLine("Enter an ID number for customer:");
            newCustomer.CustomerID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the type of customer (former, current, or potential):");
            string input = Console.ReadLine();
            switch (input)
            {
                case "former":
                    newCustomer.TypeOfCustomer = CustomerType.Former;
                    newCustomer.Email = "We miss you! Would a discount bring you back?";
                    break;
                case "current":
                    newCustomer.TypeOfCustomer = CustomerType.Current;
                    newCustomer.Email = "We appreciate your business; here's a coupon just for you!";
                    break;
                case "potential":
                    newCustomer.TypeOfCustomer = CustomerType.Potential;
                    newCustomer.Email = "We currently have the lowest rates for helicopter insurance! Come check us out!";
                    break;
                default:
                    Console.WriteLine("Invalid response.");
                    Console.ReadLine();
                    break;
            }

            _customerRepo.AddCustomerToList(newCustomer);
        }
        private void RemoveCustomer()
        {
            Console.WriteLine("Enter the ID number of the customer you wish to delete:");
            foreach (Customer customer in _customers)
            {
                Console.WriteLine(customer.CustomerID);
            }
            int deleteCustomer = int.Parse(Console.ReadLine());

            foreach (Customer customer in _customers)
            {
                if (deleteCustomer == customer.CustomerID)
                {
                    _customers.Remove(customer);
                    break;
                }
            }
        }

        private void UpdateCustomer()
        {
            Console.WriteLine("Enter the ID number of the customer you wish to update:");
            foreach (Customer customer in _customers)
            {
                Console.WriteLine(customer.CustomerID);
            }
            int updateCustomer = int.Parse(Console.ReadLine());

            foreach(Customer customer in _customers)
            {
                if (updateCustomer == customer.CustomerID)
                {
                    _customers.Remove(customer);
                }
            }
            CreateNewCustomer();
        }
    }
}
