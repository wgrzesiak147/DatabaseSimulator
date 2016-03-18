using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseSimulator.NoSQL;
using DatabaseSimulator.SQL;

namespace DatabaseSimulator
{
    public partial class Form1 : Form
    {
        private readonly NoSqlTestManager _noSqlTestManager;
        private readonly SqlTestManager _sqlTestManager;

        public Form1()
        {
            InitializeComponent();
            _sqlTestManager = new SqlTestManager(txtOutput);
            _noSqlTestManager = new NoSqlTestManager(txtOutput);
        }

        private void btnPerform_Click(object sender, EventArgs e)
        {
            int quantity = (int) cmbQuantity.Value;
            _noSqlTestManager.PerformProductInserts(quantity);
        }

    }
}