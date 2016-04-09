using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseSimulator.Entities;

namespace DatabaseSimulator.Tests.Tests
{
    public class BlogGetAllTest<T> : Test where T : IDatabaseManager, new()
    {
        public BlogGetAllTest(RichTextBox output) : base(output, new T())
        {
        }

        protected override string TestName => Constants.Blog + "GetAll";
        protected override void TestLogic()
        {
            List<Blog> listOfObjects = Database.GetAllBlogs();
            Output.AppendText(String.Format(Environment.NewLine + "Received {0} objects", listOfObjects.Count()));
        }
    }
}
