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
        private NoSqlTestManager _noSqlTestManager = new NoSqlTestManager();
        private SqlTestManager _sqlTestManager = new SqlTestManager();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPerform_Click(object sender, EventArgs e)
        {
            int quantity = (int) cmbQuantity.Value;
            _noSqlTestManager.PerformInserts<Product>(quantity);
        }

        private void btnPerformSql_Click(object sender, EventArgs e)
        {
            int quantity = (int) cmbQuantity.Value;
            _sqlTestManager.PerformInserts<Product>(quantity);
        }
    }
}