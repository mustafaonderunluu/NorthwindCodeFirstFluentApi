﻿using System.Collections.Generic;

namespace NorthwindEfCodeFirstFluentApi.Context
{
    public class Customer
    {
        public Customer()
        {
            Orders = new List<Order>();
        }

        public string CustomerID { get; set; }
        public string ContactName { get; set; }

        public string CompanyName { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public List <Order> Orders { get; set; }




    }
}