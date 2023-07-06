using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IProductModel> cart = AddSampleData();
            CustomerModel customer = GetCustomer();

            foreach (IProductModel prod in cart)
            {
                prod.ShipItem(customer);
                if (prod is IDigitalProductModel digital)
                {
                    Console.WriteLine($"For the {digital.Title} you have {digital.TotalDownloadLeft}");
                }
            }
            Console.ReadLine();
        }

        private static CustomerModel GetCustomer()
        {
            return new CustomerModel
            { 
                FirstName = "Tim",
                LastName = "Corey",
                City = "Scranton",
                EmailAddress = "tim@IAmTimCorey.com",
                PhoneNumber = "555-1212"
            };
        }

        private static List<IProductModel> AddSampleData()
        {
            List<IProductModel> output = new List<IProductModel>();
            output.Add(new PhysicalProductModel { Title = "Nert Football" });
            output.Add(new PhysicalProductModel { Title = "IAmTimCorey T-Shirt" });
            output.Add(new PhysicalProductModel { Title = "Hard Drive" });
            output.Add(new DigitalProductModel { Title = "Lesson Source code"});
            //Power of Interfaces: Adding a new Class to your project, why to use Interfaces:
            // Benefit: 1. Don't have to change the code. 2. More flexible (eg. Customer vs ICustomer) <- DO NOT tied to sp. type
            output.Add(new CourseProductModel { Title = ".NET Core Start to Finish"});

            return output;
        }
    }
}
