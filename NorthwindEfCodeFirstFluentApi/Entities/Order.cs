using System;

namespace NorthwindEfCodeFirstFluentApi.Context
{
    public class Order
    {
       
        public int OrderID { get; set; }
         
        public string CustomerID { get; set; }
        public DateTime OrderDate { get; set; }

        public Customer Customer { get; set; }

       


    }
}