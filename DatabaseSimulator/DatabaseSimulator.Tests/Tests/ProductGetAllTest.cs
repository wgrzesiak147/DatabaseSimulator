using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSimulator.Tests
{
    public class ProductGetAllTest<T> : Test where T : IDatabaseManager, new()
    {
        public ProductGetAllTest(RichTextBox output) : base(output, new T())
        {
        }

        protected override string TestName { get; set; } = "Product GetAlltest";
        protected override void TestLogic()
        {
           List<Product> listOfObjects = Database.GetAllProducts();
           Output.AppendText(String.Format("Received {0} objects", listOfObjects.Count()));
        }
    }
}
