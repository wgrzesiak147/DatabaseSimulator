using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSimulator.NoSQL.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
            Id = Guid.NewGuid();
        }
    }
}
