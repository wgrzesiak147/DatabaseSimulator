using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DatabaseSimulator.Entities;
using DatabaseSimulator.NoSQL.Entities;
using Norm;

namespace DatabaseSimulator.NoSQL
{
    public class NoSqlServiceManager : IDatabaseManager
    {
        public string Name { get; set; } = "NoSql";

        public void InsertProduct(Product obj)
        {
            using (var db = Mongo.Create(Constants.DatabaseAdress))
            {
                long newid = db.GetCollection<Product>().GenerateId(); 
                obj.Id = (int)newid;
                db.GetCollection<Product>().Save(obj);
            }
        }


        public Product GetProductByID(int id)
        {
            Product retval;

            using (var db = Mongo.Create(Constants.DatabaseAdress))
            {
                retval = db.GetCollection<Product>().AsQueryable().FirstOrDefault(x => x.Id == id);
            }
            return retval;
        }

        public List<Product> GetAllProducts()
        {
            var retval = new List<Product>();

            using (var db = Mongo.Create(Constants.DatabaseAdress))
            {
                retval = db.GetCollection<Product>().Find().ToList();
            }
            return retval;
        }
    }
}