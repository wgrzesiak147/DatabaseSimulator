using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSimulator.Tests.Tests
{
    public class BlogGetByIdOperation : Operation
    {
        protected override string TestName => Constants.Blog + "GetById";

        protected override void TestLogic()
        {
            Database.GetBlogByID(Id);

            Output.AppendText(String.Format(Environment.NewLine + "Product with id: {0} received", Id));
        }
    }
}