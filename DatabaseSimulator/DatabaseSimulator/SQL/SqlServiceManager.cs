using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSimulator.SQL
{
    public class SqlServiceManager
    {
        public void SaveProduct(Product product)
        {
            using (var db = new SqlModel())
            {
                db.Product.Add(product);
                db.SaveChanges();
            }
        }
    }
}
