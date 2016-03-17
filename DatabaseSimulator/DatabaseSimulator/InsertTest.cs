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
                Output.AppendText("Wrong tests Quantity!\n");
                Output.ScrollToCaret();
                return;
            }
            for (int i = 0; i < _quantity; i++)
            {
                Database.Insert(new Product() { Name = i.ToString(), Price = i });
            }
        }
    }
}