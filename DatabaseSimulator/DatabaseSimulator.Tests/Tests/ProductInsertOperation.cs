using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSimulator
{
    public class ProductInsertOperation : Operation
    {
        protected override string TestName => Quantity + " Products insert";

        protected override void TestLogic()
        {
            if (Quantity <= 0)
            {
                throw new Exception("Quantity must be higher than 0!");
            }
            for (int i = 0; i < Quantity; i++)
            {
                Database.InsertProduct(new Product() {Name = i.ToString(), Price = i});
            }
        }
    }
}