using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseSimulator.Entities;

namespace DatabaseSimulator.Tests.Tests
{
    public class BlogInsertTest<T> : Test where T : IDatabaseManager, new()
    {
        private int _quantity;
        public BlogInsertTest(RichTextBox output, int quantity) : base(output, new T())
        {
            _quantity = quantity;
        }

        protected override string TestName => _quantity + "Blogs insert";

        protected override void TestLogic()
        {
            if (_quantity <= 0)
            {
                throw new Exception("Quantity must be higher than 0!");
            }
            for (int i = 0; i < _quantity; i++)
            {
                Database.InsertBlog(new Blog { Name = i.ToString(),Post = new List<Post>() {new Post() {Title = "tmp",Content = "tmpContent"} } });
            }
        }
    }
}
