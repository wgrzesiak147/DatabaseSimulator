using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseSimulator.NoSQL.Entities;

namespace DatabaseSimulator
{
    public interface IDatabaseManager
    {
        string Name { get; set; }
        void InsertProduct(Product obj);
        Product GetProductByID(int id);
        List<Product> GetAllProducts();

    }
}
