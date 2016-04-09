using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSimulator.Tests.Tests
{
    public class ProductClean<T> : Test where T : IDatabaseManager, new()
    {
        public ProductClean(RichTextBox output) : base(output, new T())
        {
        }

        protected override string TestName => Constants.Product + " Clean";
        protected override void TestLogic()
        {
            Database.CleanProducts();
        }
    }
}
