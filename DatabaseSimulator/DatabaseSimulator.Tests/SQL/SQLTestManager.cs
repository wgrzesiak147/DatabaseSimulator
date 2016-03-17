using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseSimulator.NoSQL;
using DatabaseSimulator.Tests;
using DatabaseSimulator.Tests.Generic;
using DatabaseSimulator.Tests.Tests;

namespace DatabaseSimulator.SQL
{
   public class SqlTestManager : ITestManager
   {
       private readonly RichTextBox _output;
       public SqlTestManager(RichTextBox txtOutput)
       {
           _output = txtOutput;
       }

       public void PerformInserts(int quantity)
       {
            InsertTest<SqlServiceManager> insertTest = new InsertTest<SqlServiceManager>(_output, quantity);
            insertTest.PerformTest();
        }

        public void PerformGetAll()
        {
            GetAllTest<SqlServiceManager> insertTest = new GetAllTest<SqlServiceManager>(_output);
            insertTest.PerformTest();
        }

        public void PerformGetByIdTest(int id)
        {
            GetByIdTest<SqlServiceManager> insertTest = new GetByIdTest<SqlServiceManager>(_output, id);
            insertTest.PerformTest();
        }
    }
}
