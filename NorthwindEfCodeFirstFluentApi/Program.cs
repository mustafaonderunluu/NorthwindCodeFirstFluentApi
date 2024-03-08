using NorthwindEfCodeFirstFluentApi.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindEfCodeFirstFluentApi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (NortwindContext nortwindContext = new NortwindContext()) {


                foreach (var customer in nortwindContext.Customers) {



                    Console.WriteLine(customer.ContactName);

                }
            
            Console.ReadLine();
            }
        }
    }
}
