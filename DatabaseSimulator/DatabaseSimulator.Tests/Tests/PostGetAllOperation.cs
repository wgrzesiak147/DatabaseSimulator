using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSimulator.Tests.Tests
{
    public class PostGetAllOperation : Operation
    {
        protected override string TestName => "Post" + "GetAll";

        protected override void TestLogic()
        {
            List<object> listOfObjects = Database.GetAllPosts();

            Output.AppendText(String.Format(Environment.NewLine + "Received {0} objects", listOfObjects.Count()));
        }

    }
}
