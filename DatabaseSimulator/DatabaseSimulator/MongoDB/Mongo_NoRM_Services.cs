using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DatabaseSimulator.Entities;
using Norm;
using Norm.Collections;

namespace DatabaseSimulator.NoSQL
{
    public class Mongo_NoRM_Services :IDatabaseManager
    {
        public string Name { get; set; } = "NoSql";

        public void InsertProduct(object objProduct)
        {
            using (var db = Mongo.Create(Constants.DatabaseAdress))
            {
                long newid = db.GetCollection<Product>().GenerateId();
                Product prod = (Product) objProduct;
                prod.Id = (int) newid;
                db.GetCollection<Product>().Save(prod);
            }
        }

        public object GetProductByID(int id)
        {
            Product retval;

            using (var db = Mongo.Create(Constants.DatabaseAdress))
            {
                retval = db.GetCollection<Product>().AsQueryable().FirstOrDefault(x => x.Id == id);
            }
            return retval;
        }

        public List<object> GetAllProducts()
        {
            var retval = new List<object>();

            using (var db = Mongo.Create(Constants.DatabaseAdress))
            {
                retval = db.GetCollection<Product>().Find().Cast<object>().ToList();
            }
            return retval;
        }

        public void InsertBlog(object objBlog)
        {
            using (var db = Mongo.Create(Constants.DatabaseAdress))
            {
                NoSQLBlog blog = (NoSQLBlog) objBlog;
                long newid = db.GetCollection<NoSQLBlog>().GenerateId();
                blog.Id = (int)newid;
                db.GetCollection<NoSQLBlog>().Save(blog);
            }
        }

        public object GetBlogByID(int id)
        {
            NoSQLBlog retval;

            using (var db = Mongo.Create(Constants.DatabaseAdress))
            {
                retval = db.GetCollection<NoSQLBlog>().AsQueryable().FirstOrDefault(x => x.Id == id);
            }
            return retval;
        }

        public List<object> GetAllBlogs()
        {
            var retval = new List<object>();

            using (var db = Mongo.Create(Constants.DatabaseAdress))
            {
                retval = db.GetCollection<NoSQLBlog>().Find().Cast<object>().ToList();
            }
            return retval;
        }

        public void CleanBlogs()
        {
            using (var db = Mongo.Create(Constants.DatabaseAdress))
            {
                 var blogCollection = db.GetCollection<NoSQLBlog>().Find(); 

                foreach (var blog in blogCollection)
                {
                    db.GetCollection<NoSQLBlog>().Delete(blog);
                }
            }
        }

        public void CleanProducts()
        {
            using (var db = Mongo.Create(Constants.DatabaseAdress))
            {
                var blogCollection = db.GetCollection<Product>().Find();

                foreach (var blog in blogCollection)
                {
                    db.GetCollection<Product>().Delete(blog);
                }
            }
        }

        public List<object> GetAllPosts()
        {
            var retval = new List<object>();
            var blogList = new List<NoSQLBlog>();
            using (var db = Mongo.Create(Constants.DatabaseAdress))
            {
                blogList = db.GetCollection<NoSQLBlog>().Find().ToList();
            }
            blogList.ForEach(x=> retval.AddRange(x.Post));
            return retval;
        }

        public void InsertReceipt(object receipt)
        {
            throw new NotImplementedException();
        }

        public List<object> GetAllReceipts()
        {
            throw new NotImplementedException();
        }

        public void CleanReceipts()
        {
            throw new NotImplementedException();
        }
    }
}