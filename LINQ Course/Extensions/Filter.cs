using Data;
using Data.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Course.Extensions
{
    public static class Filter
    {
        //public static Database database;
        //public Filter(Database _database)
        //{
        //    database = _database;
        //}
        public static List<Customer> GetName(string name,int age)
        {
            var customers = Database.GetCustomers().Where(w => w.name.Contains(name)&&w.age>=age).ToList();

            return customers;

        }

        public static List<Customer> GetName(this List<Customer> list,string name,int age)
        {

            List<Customer> names = new List<Customer>();

            

                foreach (var customer in list)
                {
                    if (customer.name.Contains(name)&&customer.age>=age)
                    {
                        names.Add(customer);
                    }
                }
            
           

            return names;
        }

        public static List<Customer> GetData(this List<Customer> list, Func<Customer, bool> filter)
        {
            List<Customer> names = new List<Customer>();



            foreach (var customer in list)
            {
                if (filter(customer))
                {
                    names.Add(customer);
                }
            }

            return names;
        }
    }
}
