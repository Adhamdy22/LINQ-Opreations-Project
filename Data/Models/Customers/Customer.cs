﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Customers
{
    public class Customer:IComparable<Customer>
    {
        public int id { get; set; }
        public string name { get; set; }
        public long telephone { get; set; }
        public int age { get; set; }
        public decimal spendAverage { get; set; }
        public int categoryId { get; set; }

        public virtual CustomerCategory ? category {  get; set; }
        public bool isActive { get; set; }
        public DateTime joinDate { get; set; }

        public int CompareTo(Customer? other)
        {
            return this.age;
        }
    }
}
