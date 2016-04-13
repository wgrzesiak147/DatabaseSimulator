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
        void InsertProduct(object objProduct);
        object GetProductByID(int id);
        List<object> GetAllProducts();
        void InsertBlog(object objBlog);
        object GetBlogByID(int id);
        List<object> GetAllBlogs();
        void CleanBlogs();
        void CleanProducts();
    }
}