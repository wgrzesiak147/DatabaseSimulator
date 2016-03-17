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
        void PerformInserts(int quantity);
        void PerformGetAll();
        void PerformGetByIdTest(int id);
    }
}