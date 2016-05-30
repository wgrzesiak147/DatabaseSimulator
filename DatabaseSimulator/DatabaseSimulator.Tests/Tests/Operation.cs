using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseSimulator.Tests.Enum;

namespace DatabaseSimulator
{
    public abstract class Operation
    {
        protected DatabaseType DatabaseType;
        protected int Id { get; set; }
        protected int Quantity { get; set; }
        protected abstract string TestName { get; }
        protected RichTextBox Output { get; set; }
        protected IDatabaseManager Database { get; set; }
        protected abstract void TestLogic();

        public void PerformTest(IDatabaseManager database, RichTextBox output,int id,int quantity,DatabaseType type = DatabaseType.MSSQL)
        {
            DatabaseType = type;
            Quantity = quantity;
            Id = id;
            Database = database;
            Output = output;
            Stopwatch watch = new Stopwatch();

            Output.AppendText(string.Format("Operation <{0}> on {1} database started", TestName, Database.Name));
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
                watch.Elapsed.TotalSeconds));
            Output.ScrollToCaret();
        }
    }
}