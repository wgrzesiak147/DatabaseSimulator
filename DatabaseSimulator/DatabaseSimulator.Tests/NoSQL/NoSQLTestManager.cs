using System.Windows.Forms;
using DatabaseSimulator.NoSQL;
using DatabaseSimulator.Tests.Generic;
using DatabaseSimulator.Tests.Tests;

namespace DatabaseSimulator.Tests.NoSQL
{
    public class NoSqlTestManager : ITestManager
    {
        private readonly RichTextBox _output;

        public NoSqlTestManager(RichTextBox txtOutput)
        {
            _output = txtOutput;
        }

        public void PerformProductInserts(int quantity)
        {
            ProductInsertTest<NoSqlServiceManager> productInsertTest = new ProductInsertTest<NoSqlServiceManager>(_output,quantity);
            productInsertTest.PerformTest();
        }

        public void PerformProductGetAll()
        {
            ProductGetAllTest<NoSqlServiceManager> insertTest = new ProductGetAllTest<NoSqlServiceManager>(_output);
            insertTest.PerformTest();
        }

        public void PerformProductGetByIdTest(int id)
        {
            ProductGetByIdTest<NoSqlServiceManager> insertTest = new ProductGetByIdTest<NoSqlServiceManager>(_output,id);
            insertTest.PerformTest();
        }

        public void PerformBlogInserts(int quantity)
        {
            BlogInsertTest<NoSqlServiceManager> productInsertTest = new BlogInsertTest<NoSqlServiceManager>(_output, quantity);
            productInsertTest.PerformTest();
        }

        public void PerformBlogGetAll()
        {
            BlogGetAllTest<NoSqlServiceManager> insertTest = new BlogGetAllTest<NoSqlServiceManager>(_output);
            insertTest.PerformTest();
        }

        public void PerformBlogGetByIdTest(int id)
        {
            BlogGetByIdTest<NoSqlServiceManager> productInsertTest = new BlogGetByIdTest<NoSqlServiceManager>(_output, id);
            productInsertTest.PerformTest();
        }
    }
}