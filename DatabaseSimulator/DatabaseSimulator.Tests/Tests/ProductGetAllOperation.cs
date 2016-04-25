using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSimulator.Tests
{
    public class ProductGetAllOperation : Operation
    {
        protected override string TestName { get; } = Constants.Product + " GetAlltest";

        protected override void TestLogic()
        {
            List<object> listOfObjects = Database.GetAllProducts();

            Output.AppendText(String.Format(Environment.NewLine + "Received {0} objects", listOfObjects.Count()));
        }
    }
}