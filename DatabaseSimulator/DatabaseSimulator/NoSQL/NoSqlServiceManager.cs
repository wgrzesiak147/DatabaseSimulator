using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DatabaseSimulator.Entities;
using Norm;

namespace DatabaseSimulator.NoSQL
{
    public class NoSqlServiceManager : IDatabaseManager
    {
        public string Name { get; set; } = "NoSql";

        public void InsertProduct(Product objProduct)
        {
            using (var db = Mongo.Create(Constants.DatabaseAdress))
            {
                long newid = db.GetCollection<Product>().GenerateId();
                objProduct.Id = (int) newid;
                db.GetCollection<Product>().Save(objProduct);
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

        public void InsertBlog(Blog objBlog)
        {
            using (var db = Mongo.Create(Constants.DatabaseAdress))
            {
                long newid = db.GetCollection<Blog>().GenerateId();
                objBlog.Id = (int) newid;
                db.GetCollection<Blog>().Save(objBlog);
            }
        }

        public Blog GetBlogByID(int id)
        {
            Blog retval;

            using (var db = Mongo.Create(Constants.DatabaseAdress))
            {
                retval = db.GetCollection<Blog>().AsQueryable().FirstOrDefault(x => x.Id == id);
            }
            return retval;
        }

        public List<Blog> GetAllBlogs()
        {
            var retval = new List<Blog>();

            using (var db = Mongo.Create(Constants.DatabaseAdress))
            {
                retval = db.GetCollection<Blog>().Find().ToList();
            }
            return retval;
        }
    }
}