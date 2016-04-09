using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseSimulator.Entities;

namespace DatabaseSimulator.SQL
{
    public class SqlServiceManager : IDatabaseManager
    {
        public string Name { get; set; } = "SQL";
       
        public void InsertProduct(Product objProduct)
        {
            using (var db = new Model1())
            {
                db.Product.Add(objProduct);
                db.SaveChanges();
            }
        }

        public Product GetProductByID(int id)
        {
            using (var db = new Model1())
            {
                Product product = db.Product.FirstOrDefault(x => x.Id == id);
                return product;
            }
        }

        public List<Product> GetAllProducts()
        {
            using (var db = new Model1())
            {
                List<Product> products = db.Product.ToList();
                return products;
            }
        }

        public void InsertBlog(Blog objBlog)
        {
            using (var db = new Model1())
            {
                db.Blog.Add(objBlog);
                db.SaveChanges();
            }
        }


        public Blog GetBlogByID(int id)
        {
            using (var db = new Model1())
            {
                Blog blog = db.Blog.FirstOrDefault(x => x.Id == id);
                return blog;
            }
        }

        public List<Blog> GetAllBlogs()
        {
            using (var db = new Model1())
            {
                List<Blog> blogs = db.Blog.ToList();
                return blogs;
            }
        }

        public void CleanBlogs()
        {
            using (var db = new Model1())
            {
                db.Database.ExecuteSqlCommand("TRUNCATE TABLE Post");
                db.Database.ExecuteSqlCommand("TRUNCATE TABLE Blog");
            }
        }

        public void CleanProducts()
        {
            using (var db = new Model1())
            {
                db.Database.ExecuteSqlCommand("TRUNCATE TABLE Product");
            }    
        }
    }
}