using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseSimulator.NoSQL;
using DatabaseSimulator.NoSQL.Entities;
using DatabaseSimulator.SQL;

namespace DatabaseSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPerform_Click(object sender, EventArgs e)
        {
            int quantity = (int) cmbQuantity.Value;
            InsertTest<NoSqlServiceManager> noSqlInsertTest = new InsertTest<NoSqlServiceManager>(txtOutput, quantity);
            noSqlInsertTest.PerformTest();
        }

        private void btnPerformSql_Click(object sender, EventArgs e)
        {
            int quantity = (int) cmbQuantity.Value;
            InsertTest<SqlServiceManager> noSqlInsertTest = new InsertTest<SqlServiceManager>(txtOutput, quantity);
            noSqlInsertTest.PerformTest();
        }
    }
}