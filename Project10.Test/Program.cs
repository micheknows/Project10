using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_Database.Dal;

namespace Web_Database.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerAdapter adapter = new CustomerAdapter();
            List<Customer> customers = adapter.GetAll();

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.CustomerId + ":" + customer.FirstName + " " + customer.LastName + ":" + customer.Country + ":" + customer.Email);
            }
            Console.ReadLine();
        }
    }
}
