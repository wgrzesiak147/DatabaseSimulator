using System;
using System.Windows.Forms;
using DatabaseSimulator.SQL;
using DatabaseSimulator.Tests.Generic;
using DatabaseSimulator.Tests.Tests;

namespace DatabaseSimulator.Tests.SQL
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
           BlogInsertTest<SqlServiceManager> insertTest = new BlogInsertTest<SqlServiceManager>(_output, quantity);
            insertTest.PerformTest();
        }

        public void PerformBlogGetAll()
       {
            BlogGetAllTest<SqlServiceManager> getAll = new BlogGetAllTest<SqlServiceManager>(_output);
            getAll.PerformTest();
        }

        public void PerformBlogGetByIdTest(int id)
       {
            BlogGetByIdTest<SqlServiceManager> getByIdTest = new BlogGetByIdTest<SqlServiceManager>(_output, id);
            getByIdTest.PerformTest();
        }

       public void PerformBlogClean()
       {
            BlogClean<SqlServiceManager> productClean = new BlogClean<SqlServiceManager>(_output);
            productClean.PerformTest();
        }

       public void PerformProductClean()
       {
           ProductClean<SqlServiceManager> productClean =  new ProductClean<SqlServiceManager>(_output);
           productClean.PerformTest();
       }
   }
}
