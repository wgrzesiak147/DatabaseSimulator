using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseSimulator.Tests.Generic;

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
    }
}
