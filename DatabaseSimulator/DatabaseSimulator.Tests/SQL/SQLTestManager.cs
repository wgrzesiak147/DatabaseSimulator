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

       public void PerformProductInserts(int quantity)
       {
            ProductInsertTest<SqlServiceManager> productInsertTest = new ProductInsertTest<SqlServiceManager>(_output, quantity);
            productInsertTest.PerformTest();
        }

        public void PerformProductGetAll()
        {
            ProductGetAllTest<SqlServiceManager> insertTest = new ProductGetAllTest<SqlServiceManager>(_output);
            insertTest.PerformTest();
        }

        public void PerformProductGetByIdTest(int id)
        {
            ProductGetByIdTest<SqlServiceManager> insertTest = new ProductGetByIdTest<SqlServiceManager>(_output, id);
            insertTest.PerformTest();
        }

       public void PerformBlogInserts(int quantity)
       {
           BlogInsertTest<SqlServiceManager>productInsertTest = new BlogInsertTest<SqlServiceManager>(_output, quantity);
           productInsertTest.PerformTest();
        }

        public void PerformBlogGetAll()
       {
            BlogGetAllTest<SqlServiceManager> insertTest = new BlogGetAllTest<SqlServiceManager>(_output);
            insertTest.PerformTest();
        }

        public void PerformBlogGetByIdTest(int id)
       {
            BlogGetByIdTest<SqlServiceManager> insertTest = new BlogGetByIdTest<SqlServiceManager>(_output, id);
            insertTest.PerformTest();
        }
    }
}
