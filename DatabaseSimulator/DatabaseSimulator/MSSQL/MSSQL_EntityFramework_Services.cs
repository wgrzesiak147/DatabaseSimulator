using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using DatabaseSimulator.Entities;
using IsolationLevel = System.Data.IsolationLevel;


namespace DatabaseSimulator.SQL
{
    public class MSSQL_EntityFramework_Services : IDatabaseManager
    {
        public string Name { get; set; } = "SQL";

        public void InsertProduct(object objProduct)
        {
            //using (
            //    var scope = new TransactionScope(TransactionScopeOption.Required,
            //        new TransactionOptions {IsolationLevel = System.Transactions.IsolationLevel.Snapshot}))
            //{
                using (var db = new Model1())
                {
                    Product prod = (Product) objProduct;
                    db.Product.Add(prod);
                    db.SaveChanges();
                }
           // }
        }

        public object GetProductByID(int id)
        {
            using (var db = new Model1())
            {
                Product product = db.Product.FirstOrDefault(x => x.Id == id);
                return product;
            }
        }

        public List<object> GetAllProducts()
        {
            using (var db = new Model1())
            {
                List<Product> products = db.Product.ToList();
                return products.Cast<object>().ToList();
            }
        }

        public void InsertBlog(object objBlog)
        {
            using (var db = new Model1())
            {
                Blog blog = (Blog) objBlog;
                db.Blog.Add(blog);
                db.SaveChanges();
            }
        }
        public object GetBlogByID(int id)
        {
            using (var db = new Model1())
            {
                Blog blog = db.Blog.FirstOrDefault(x => x.Id == id);
                return blog;
            }
        }

        public List<object> GetAllBlogs()
        {
            using (var db = new Model1())
            {
                List<Blog> blogs = db.Blog.ToList();
                return blogs.Cast<object>().ToList();
            }
        }


        public void CleanBlogs()
        {
            using (var db = new Model1())
            {
                db.Database.ExecuteSqlCommand("DELETE  FROM  Post");
                db.Database.ExecuteSqlCommand("DELETE  FROM  Blog");
            }
        }

        public void CleanProducts()
        {
            using (var db = new Model1())
            {
                db.Database.ExecuteSqlCommand("TRUNCATE TABLE Product");
            }
        }

        public List<object> GetAllPosts()
        {
            List<Post> result= null;
            using (var db = new Model1())
            {
                result = db.Post.ToList();
                return result.Cast<object>().ToList();
            }
            
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