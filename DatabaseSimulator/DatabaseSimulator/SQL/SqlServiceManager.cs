using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSimulator.SQL
{
    public class SqlServiceManager : IDatabaseManager
    {
        public string Name { get; set; } = "SQL";

        public void Insert(Product obj)
        {
            using (var db = new SqlModel())
            {
                db.Product.Add(obj);
                db.SaveChanges();
            }
        }

        public Product GetProductByID(int id)
        {
            using (var db = new SqlModel())
            {
                Product product = db.Product.FirstOrDefault(x => x.Id == id);
                return product;
            }
        }

        public List<Product> GetAllObjects()
        {
            using (var db = new SqlModel())
            {
                List<Product> products = db.Product.ToList();
                return products;
            }
        }
    }
}