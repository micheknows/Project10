using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Database.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerAdapter adapter = new CustomerAdapter();
            List customers = adapter.GetAll();

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.CustomerId + ":" + customer.FirstName + " " + customer.LastName + ":" + customer.Country + ":" + customer.Email);
            }
            Console.ReadLine();
        }
    }
}
