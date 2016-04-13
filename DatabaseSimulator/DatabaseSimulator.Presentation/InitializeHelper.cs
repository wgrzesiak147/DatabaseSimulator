using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseSimulator.Presentation.Entities;
using DatabaseSimulator.Tests.NoSQL;
using System.Windows.Forms;
using DatabaseSimulator.Tests.SQL;

namespace DatabaseSimulator.Presentation
{
    public static class InitializeHelper
    {
        private static RichTextBox Output;
        public static  BindingList<TestManagerObject> InitializeTestManagers()
        {
            return new BindingList<TestManagerObject>()
            {
                {new TestManagerObject(new NoSqlTestManager(Output), "MongoDB")},
                {new TestManagerObject(new SqlTestManager(Output), "MSSQL 2012")}
            };
        }

        public static void InitializeOutput(RichTextBox output)
        {
            Output = output;
        }
    }
}
