using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSimulator.CrudeMongo
{
    public class Mongo_Crude_Services : IDatabaseManager
    {
        public string Name { get; set; } = "Mongo C# driver";

        public void InsertProduct(object objProduct)
        {
           
        }

        public object GetProductByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<object> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public void InsertBlog(object objBlog)
        {
            throw new NotImplementedException();
        }

        public object GetBlogByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<object> GetAllBlogs()
        {
            throw new NotImplementedException();
        }

        public void CleanBlogs()
        {
            throw new NotImplementedException();
        }

        public void CleanProducts()
        {
            throw new NotImplementedException();
        }
    }
}
