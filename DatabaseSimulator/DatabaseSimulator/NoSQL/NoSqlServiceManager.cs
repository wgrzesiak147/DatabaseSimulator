using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DatabaseSimulator.NoSQL.Entities;
using Norm;

namespace DatabaseSimulator.NoSQL
{
    public class NoSqlServiceManager
    {
        //tmp
        public List<Product> GetLisOfProducts()
        {
            var retval = new List<Product>();

            using (var db = Mongo.Create(Constants.DatabaseAdress))
            {
                retval = db.GetCollection<Product>().Find().ToList();
            }
            return retval;
        }

        public void SaveProduct(Product product)
        {
            using (var db = Mongo.Create(Constants.DatabaseAdress))
            {
                db.GetCollection<Product>().Save(product);
            }
        }

        public Product GetProductById(int id)
        {
            Product retval = null;

            using (var db = Mongo.Create(Constants.DatabaseAdress))
            {
                retval = db.GetCollection<Product>().AsQueryable().FirstOrDefault(x => x.Id == id);
            }
            return retval;
        }
    }
}