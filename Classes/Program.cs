using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            Console.WriteLine("*************************************");

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Console.WriteLine("*************************************");

            Customer customer = new Customer();
            customer.City = "İstanbul";
            customer.Id = 1;
            customer.Firstname = "ALi Rıza";
            customer.Lastname = "Şahin";

            Customer customer2 = new Customer
            {

                Id = 2,
                City = "Kayseri",
                Firstname = "Mustafa",
                Lastname = "Şahin"

            };

            Console.WriteLine(customer2.Lastname);

            Console.ReadLine();
        }


    }
}
