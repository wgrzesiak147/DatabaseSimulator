using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSimulator.Tests.Tests
{
    public class ProductGetByIdTest<T> : Test where T : IDatabaseManager, new()
    {
        private int _id;
        public ProductGetByIdTest(RichTextBox output, int id) : base(output, new T())
        {
            _id = id;
        }

        protected override string TestName { get; set; } = "Product GetById";
        protected override void TestLogic()
        {
            Database.GetProductByID(_id);
            Output.AppendText(String.Format("Product with id: {0} received",_id));
        }
    }
}
