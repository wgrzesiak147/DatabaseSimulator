using System;
using System.Windows.Forms;
using DatabaseSimulator.Tests.NoSQL;
using DatabaseSimulator.Tests.SQL;

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