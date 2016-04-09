﻿using System;
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

        protected override string TestName =>Constants.Product + " GetById";
        protected override void TestLogic()
        {
            Database.GetProductByID(_id);
            Output.AppendText(String.Format(Environment.NewLine +"Product with id: {0} received",_id));
        }
    }
}
