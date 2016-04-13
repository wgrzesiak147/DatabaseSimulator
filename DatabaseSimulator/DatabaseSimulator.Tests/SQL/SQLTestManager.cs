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
            ProductInsertTest<MSSQL_EntityFramework_Services> productInsertTest = new ProductInsertTest<MSSQL_EntityFramework_Services>(_output, quantity);
            productInsertTest.PerformTest();
        }

        public void PerformProductGetAll()
        {
            ProductGetAllTest<MSSQL_EntityFramework_Services> insertTest = new ProductGetAllTest<MSSQL_EntityFramework_Services>(_output);
            insertTest.PerformTest();
        }

        public void PerformProductGetByIdTest(int id)
        {
            ProductGetByIdTest<MSSQL_EntityFramework_Services> insertTest = new ProductGetByIdTest<MSSQL_EntityFramework_Services>(_output, id);
            insertTest.PerformTest();
        }

        public void PerformBlogInserts(int quantity)
        {
            BlogInsertTest<MSSQL_EntityFramework_Services> insertTest = new BlogInsertTest<MSSQL_EntityFramework_Services>(_output, quantity);
            insertTest.PerformTest();
        }

        public void PerformBlogGetAll()
        {
            BlogGetAllTest<MSSQL_EntityFramework_Services> getAll = new BlogGetAllTest<MSSQL_EntityFramework_Services>(_output);
            getAll.PerformTest();
        }

        public void PerformBlogGetByIdTest(int id)
        {
            BlogGetByIdTest<MSSQL_EntityFramework_Services> getByIdTest = new BlogGetByIdTest<MSSQL_EntityFramework_Services>(_output, id);
            getByIdTest.PerformTest();
        }

        public void PerformBlogClean()
        {
            BlogClean<MSSQL_EntityFramework_Services> productClean = new BlogClean<MSSQL_EntityFramework_Services>(_output);
            productClean.PerformTest();
        }

        public void PerformProductClean()
        {
            ProductClean<MSSQL_EntityFramework_Services> productClean = new ProductClean<MSSQL_EntityFramework_Services>(_output);
            productClean.PerformTest();
        }

    }
}
