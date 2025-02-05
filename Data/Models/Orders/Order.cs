using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Orders
{
    public class Order
    {
        public int Id { get; set; }
        public decimal total { get; set; }
        public DateTime orderDate { get; set; }
        public int customerId { get; set; }
    }
}
