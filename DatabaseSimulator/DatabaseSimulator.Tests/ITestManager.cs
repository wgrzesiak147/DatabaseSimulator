using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseSimulator.Tests.Tests;

namespace DatabaseSimulator.Tests.Generic
{
    internal interface ITestManager
    {
        void PerformProductInserts(int quantity);
        void PerformProductGetAll();
        void PerformProductGetByIdTest(int id);

        void PerformBlogInserts(int quantity);
        void PerformBlogGetAll();
        void PerformBlogGetByIdTest(int id);

    }
}