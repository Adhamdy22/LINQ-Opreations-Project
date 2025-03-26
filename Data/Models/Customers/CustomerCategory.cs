using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Customers
{
    public class CustomerCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<CustomerCategory>? Categories { get; set; }
    }
}
