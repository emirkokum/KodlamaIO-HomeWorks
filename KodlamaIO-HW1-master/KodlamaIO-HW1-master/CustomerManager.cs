using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    internal class CustomerManager
    {
        List<Customer> customerList = new List<Customer>();

        public void AddCustomer(Customer customer)
        {
            customerList.Add(customer);
            Console.WriteLine(" -------------------------------------------------- ");
            Console.WriteLine($"{customer.customerFirstName} {customer.customerLastName} Added to the list.");
            Console.WriteLine(" -------------------------------------------------- ");
        }

        public void RemoveCustomer(Customer customer)
        {
            customerList.Remove(customer);
            Console.WriteLine(" -------------------------------------------------- ");
            Console.WriteLine($"{customer.customerFirstName} {customer.customerLastName} Removed from the list.");
            Console.WriteLine(" -------------------------------------------------- ");
        }
        public void GetCustomerList()
        {
            foreach (Customer customer in customerList)
            {
                Console.WriteLine(" -------------------------------------------------- ");
                Console.WriteLine(customer.customerFirstName + " " + customer.customerLastName);
                Console.WriteLine(" -------------------------------------------------- ");
            }
        }



    }
}
