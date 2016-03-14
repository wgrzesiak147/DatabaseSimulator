using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseSimulator.NoSQL.Entities;

namespace DatabaseSimulator
{
    public class TestManager<T> where T : IDatabaseManager,new()
    {
        private TextBox _output { get; set; }
        private IDatabaseManager _database { get; set; }

        public TestManager(TextBox output)
        {
            _output = output;
            _database = new T();
        }

        public void PerformInserts(int quantity)
        {
            _output.AppendText(string.Format("Performing {0} inserts started", quantity));

            for (int i = 0; i < quantity; i++)
            {
                _database.Insert(new Product() {Name = i.ToString(),Price = i});
            }
            _output.AppendText(string.Format("Test finished with time : ", quantity));
        }

    }
}
