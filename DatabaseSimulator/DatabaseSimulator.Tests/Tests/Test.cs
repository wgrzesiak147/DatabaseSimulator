﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSimulator
{
    public abstract class Test
    {
        protected abstract string TestName { get; }
        protected RichTextBox Output { get; set; }
        protected IDatabaseManager Database { get; set; }
        protected abstract void TestLogic();
        protected Test(RichTextBox output, IDatabaseManager database)
        {
            Output = output;
            Database = database;
        }



        public void PerformTest()
        {
            Stopwatch watch = new Stopwatch();

            Output.AppendText(string.Format("Test <{0}> on {1} database started", TestName, Database.Name));
            Output.Refresh();

            try
            {
                watch.Start();
                TestLogic();
                watch.Stop();
            }
            catch (Exception ex)
            {
                Output.AppendText(string.Format(Environment.NewLine + ex.Message + Environment.NewLine));
                Output.ScrollToCaret();

                return;
            }

            Output.AppendText(string.Format(Environment.NewLine + "Finished with time : {0}" + Environment.NewLine,
                watch.Elapsed));
            Output.ScrollToCaret();
        }
    }
}