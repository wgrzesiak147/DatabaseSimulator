using System.Threading.Tasks;
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
            ProductInsertTest<Mongo_NoRM_Services> productInsertTest = new ProductInsertTest<Mongo_NoRM_Services>(_output, quantity);
            productInsertTest.PerformTest();
        }

        public void PerformProductGetAll()
        {
            ProductGetAllTest<Mongo_NoRM_Services> insertTest = new ProductGetAllTest<Mongo_NoRM_Services>(_output);
            insertTest.PerformTest();
        }

        public void PerformProductGetByIdTest(int id)
        {
            ProductGetByIdTest<Mongo_NoRM_Services> insertTest = new ProductGetByIdTest<Mongo_NoRM_Services>(_output, id);
            insertTest.PerformTest();
        }

        public void PerformBlogInserts(int quantity)
        {
            BlogInsertTest<Mongo_NoRM_Services> productInsertTest = new BlogInsertTest<Mongo_NoRM_Services>(_output, quantity);
            productInsertTest.PerformTest();
        }

        public void PerformBlogGetAll()
        {
            BlogGetAllTest<Mongo_NoRM_Services> insertTest = new BlogGetAllTest<Mongo_NoRM_Services>(_output);
            insertTest.PerformTest();

        }

        public void PerformBlogGetByIdTest(int id)
        {
            BlogGetByIdTest<Mongo_NoRM_Services> productInsertTest = new BlogGetByIdTest<Mongo_NoRM_Services>(_output, id);
            productInsertTest.PerformTest();
        }

        public void PerformBlogClean()
        {
            BlogClean<Mongo_NoRM_Services> blogCleanTest = new BlogClean<Mongo_NoRM_Services>(_output);
            blogCleanTest.PerformTest(); 
        }

        public void PerformProductClean()
        {
            ProductClean<Mongo_NoRM_Services> blogCleanTest = new ProductClean<Mongo_NoRM_Services>(_output);
            blogCleanTest.PerformTest();
        }

    }
}