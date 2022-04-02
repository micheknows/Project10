using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson10.Dal;

namespace Lesson10.Test
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the customer's first name:");
            String fname = Console.ReadLine();
            Console.WriteLine("Please enter the customer's last name:");
            String lname = Console.ReadLine();
            Console.WriteLine("Please enter the customer's country:");
            String country = Console.ReadLine();
            Console.WriteLine("Please enter the customer's email:");
            String email = Console.ReadLine();

            CustomerAdapter adapter = new CustomerAdapter();
            Customer customer = new Customer();
            customer.FirstName = fname;
            customer.LastName = lname;
            customer.Country = country;
            customer.Email = email;
            adapter.InsertCustomer(customer);
            Console.WriteLine("Customer Inserted.  Press <enter> to see all current customers.");
            Console.ReadLine();
            List<Customer> customers = adapter.GetAll();

            foreach (Customer c in customers)
            {
                Console.WriteLine(c.CustomerId + ":" + c.FirstName + " " + c.LastName + ":" + c.Country + ":" + c.Email);
            }
            Console.ReadLine();


            
            
            Console.WriteLine("Please enter the customer's id for the invoice:");
            int cid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the invoice date:");
            DateTime invdate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the invoice total:");
            Decimal total = Decimal.Parse(Console.ReadLine());
            InvoiceAdapter invadapter = new InvoiceAdapter();
            Invoice invoice = new Invoice();
            invoice.CustomerId = cid;
            invoice.InvoiceDate = invdate;
            invoice.Total = total;
            invadapter.InsertInvoice(invoice);
            Console.WriteLine("Invoice Inserted.  Press <enter> to see all current invoices.");
            List<Invoice> invoices = invadapter.GetAll();
            Console.ReadLine();

            foreach (Invoice i in invoices)
            {
                Console.WriteLine(i.InvoiceId + "  :  " + i.CustomerId + "  :  " + i.InvoiceDate + "  :  $" + i.Total);
            }
            Console.ReadLine();
        }
    }
}
