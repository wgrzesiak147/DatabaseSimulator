using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSimulator.Tests.Tests
{
    public class GetByIdTest : Test
    {
        private int _id;
        public GetByIdTest(RichTextBox output, IDatabaseManager database,int id) : base(output, database)
        {
            _id = id;
        }

        protected override string TestName { get; set; } = "GetById";
        protected override void TestLogic()
        {
            Database.GetProductByID(_id);
            Output.AppendText(String.Format("Product with id: {0} received",_id));
        }
    }
}
