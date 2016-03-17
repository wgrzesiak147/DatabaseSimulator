using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseSimulator.NoSQL.Entities;

namespace DatabaseSimulator
{
    public class InsertTest<T> : Test where T : IDatabaseManager, new()
    {
        private readonly int _quantity;
        public InsertTest(RichTextBox output,int quantity) : base(output, new T())
        {
            _quantity = quantity;
            TestName = quantity + " inserts";
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