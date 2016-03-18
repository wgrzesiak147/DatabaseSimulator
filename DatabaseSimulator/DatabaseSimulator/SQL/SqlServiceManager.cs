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
            using (var db = new SqlModel())
            {
                db.Product.Add(objProduct);
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

        public List<Product> GetAllProducts()
        {
            using (var db = new SqlModel())
            {
                List<Product> products = db.Product.ToList();
                return products;
            }
        }

        public void InsertBlog(Blog objBlog)
        {
            using (var db = new BlogModel())
            {
                db.Blogs.Add(objBlog);
                db.SaveChanges();
            }
        }


        public Blog GetBlogByID(int id)
        {
            using (var db = new BlogModel())
            {
                Blog blog = db.Blogs.FirstOrDefault(x => x.Id == id);
                return blog;
            }
        }

        public List<Blog> GetAllBlogs()
        {
            using (var db = new BlogModel())
            {
                List<Blog> blogs = db.Blogs.ToList();
                return blogs;
            }
        }

    }
}