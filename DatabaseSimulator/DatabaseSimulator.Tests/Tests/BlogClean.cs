using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSimulator.Tests.Tests
{
    public class BlogClean : Operation
    {
        protected override string TestName => Constants.Blog + " clean";
        protected override void TestLogic()
        {
            Database.CleanBlogs();
        }
    }
}
