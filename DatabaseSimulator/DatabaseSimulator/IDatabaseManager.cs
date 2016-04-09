using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseSimulator.Entities;

namespace DatabaseSimulator
{
    public interface IDatabaseManager
    {
        string Name { get; set; }
        void InsertProduct(Product objProduct);
        Product GetProductByID(int id);
        List<Product> GetAllProducts();
        void InsertBlog(Blog objBlog);
        Blog GetBlogByID(int id);
        List<Blog> GetAllBlogs();
        void CleanBlogs();
        void CleanProducts();
    }
}