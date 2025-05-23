﻿
using Data.Models.Customers;
using Data.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public static class Database
    {
        public static List<CustomerCategory> GetCategories()
        {
            List<CustomerCategory> categories = new List<CustomerCategory>();
            categories.Add(new CustomerCategory() { Id = 1, Name = "normal" });
            categories.Add(new CustomerCategory() { Id = 2, Name = "VIP" });
            categories.Add(new CustomerCategory() { Id = 3, Name = "Blocked" });
            return categories;
        }

        public static List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { id = 101, name = "ahmed mohmed", age = 30, isActive = true, joinDate = new DateTime(2022, 10, 15), categoryId = 1, spendAverage = 1500.9m, telephone = 123456789 });
            customers.Add(new Customer { id = 102, name = "salah ahmed", age = 32, isActive = false, joinDate = new DateTime(2022, 10, 15), categoryId = 1, spendAverage = 2500.9m, telephone = 987654321 });
            customers.Add(new Customer { id = 103, name = "mahoude samy", age = 22, isActive = true, joinDate = new DateTime(2022, 10, 15), categoryId = 2, spendAverage = 3000.0m, telephone = 741852963 });
            customers.Add(new Customer { id = 104, name = "mostafa kamel", age = 27, isActive = true, joinDate = new DateTime(2022, 10, 15), categoryId = 1, spendAverage = 4500.11m, telephone = 369852147 });
            customers.Add(new Customer { id = 105, name = "seed nabil", age = 48, isActive = true, joinDate = new DateTime(2022, 10, 15), categoryId = 1, spendAverage = 2000.0m, telephone = 102365214 });
            customers.Add(new Customer { id = 106, name = "fareed sif", age = 18, isActive = true, joinDate = new DateTime(2022, 11, 8), categoryId = 1, spendAverage = 8110.9m, telephone = 14256363 });
            customers.Add(new Customer { id = 107, name = "abdelrahman", age = 31, isActive = false, joinDate = new DateTime(2022, 12, 24), categoryId = 1, spendAverage = 1900.0m, telephone = 259874689 });
            customers.Add(new Customer { id = 108, name = "sayed kabaka", age = 39, isActive = true, joinDate = new DateTime(2023, 4, 8), categoryId = 2, spendAverage = 1800.4m, telephone = 123698789 });
            customers.Add(new Customer { id = 109, name = "nora hazem", age = 25, isActive = false, joinDate = new DateTime(2023, 10, 31), categoryId = 1, spendAverage = 1250.6m, telephone = 121111189 });
            customers.Add(new Customer { id = 110, name = "samy tony", age = 29, isActive = true, joinDate = new DateTime(2023, 8, 18), categoryId = 1, spendAverage = 1854.9m, telephone = 122222289 });
            customers.Add(new Customer { id = 111, name = "ahmed galal", age = 37, isActive = true, joinDate = new DateTime(2023, 7, 12), categoryId = 2, spendAverage = 9632.2m, telephone = 123333339 });
            customers.Add(new Customer { id = 112, name = "invalid", age = 37, isActive = true, joinDate = new DateTime(2023, 7, 12), categoryId = 4, spendAverage = 9632.2m, telephone = 123333339 });
            return customers;
        }

        public static List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            return orders;
        }
    }
}
