using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseSimulator.Entities;


namespace DatabaseSimulator.Tests.Tests
{
    public class BlogGetAllOperation : Operation 
    {
        protected override string TestName => Constants.Blog + "GetAll";

        protected override void TestLogic()
        {
            List<object> listOfObjects = Database.GetAllBlogs();

            Output.AppendText(String.Format(Environment.NewLine + "Received {0} objects", listOfObjects.Count()));
        }
    }
}