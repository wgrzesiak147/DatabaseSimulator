using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSimulator.Tests.Tests
{
    public class ProductGetByIdOperation : Operation
    {
        protected override string TestName => Constants.Product + " GetById";

        protected override void TestLogic()
        {
            Database.GetProductByID(Id);

            Output.AppendText(String.Format(Environment.NewLine + "Product with id: {0} received", Id));
        }
    }
}