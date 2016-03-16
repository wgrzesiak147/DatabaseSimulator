﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSimulator
{
    public abstract class Test
    {
        protected abstract string TestName { get; set; }
        protected RichTextBox Output { get; set; }
        protected IDatabaseManager Database { get; set; }

        protected Test(RichTextBox output, IDatabaseManager database)
        {
            Output = output;
            Database = database;
        }

        public void PerformTest()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Output.AppendText(string.Format("Test <{0}> on {1} database started", TestName, Database.Name));
            Output.Refresh();
            TestLogic();
            watch.Stop();
            Output.AppendText(string.Format("\nFinished with time : {0}\n", watch.Elapsed));
            Output.ScrollToCaret();
        }

        protected abstract void TestLogic();
    }
}