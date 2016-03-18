using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSimulator.Tests.Tests
{
    public class BlogInsertTest<T> : Test where T : IDatabaseManager, new()
    {
        private int _quantity;
        public BlogInsertTest(RichTextBox output, int quantity) : base(output, new T())
        {
            _quantity = quantity;
        }

        protected override string TestName { get; set; }
        protected override void TestLogic()
        {
            if (_quantity <= 0)
            {
                throw new Exception("Quantity must be higher than 0!");
            }
            for (int i = 0; i < _quantity; i++)
            {
                Database.InsertProduct(new Product() { Name = i.ToString(), Price = i });
            }
        }
    }
}
