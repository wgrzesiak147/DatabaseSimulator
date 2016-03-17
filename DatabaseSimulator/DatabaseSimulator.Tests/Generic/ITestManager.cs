using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSimulator.Tests.Generic
{
    internal interface ITestManager
    {
        void PerformInserts<T>(int quantity);
    }
}