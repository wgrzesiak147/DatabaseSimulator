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

        public void PerformInserts(int quantity)
        {
            InsertTest<NoSqlServiceManager> insertTest = new InsertTest<NoSqlServiceManager>(_output,quantity);
            insertTest.PerformTest();
        }

        public void PerformGetAll()
        {
            GetAllTest<NoSqlServiceManager> insertTest = new GetAllTest<NoSqlServiceManager>(_output);
            insertTest.PerformTest();
        }

        public void PerformGetByIdTest(int id)
        {
            GetByIdTest<NoSqlServiceManager> insertTest = new GetByIdTest<NoSqlServiceManager>(_output,id);
            insertTest.PerformTest();
        }
    }
}