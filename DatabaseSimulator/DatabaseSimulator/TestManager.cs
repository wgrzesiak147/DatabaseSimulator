using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseSimulator.NoSQL.Entities;

namespace DatabaseSimulator
{
    public class TestManager<T> where T : IDatabaseManager,new()
    {
        private RichTextBox Output { get; set; }
        private IDatabaseManager Database { get; set; }

        public TestManager(RichTextBox output)
        {
            Output = output;
            Database = new T();
        }

        public void PerformInserts(int quantity)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Output.AppendText(string.Format("Performing {0} inserts started", quantity));

            for (int i = 0; i < quantity; i++)
            {
                Database.Insert(new Product() {Name = i.ToString(),Price = i});
            }
            
            watch.Stop();
            Output.AppendText(string.Format("\nTest finished with time : {0}\n", watch.Elapsed));
        }

    }

}
