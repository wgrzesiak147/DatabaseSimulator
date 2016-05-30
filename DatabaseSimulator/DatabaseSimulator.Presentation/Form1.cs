using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using DatabaseSimulator.Presentation;
using DatabaseSimulator.Presentation.Entities;
using DatabaseSimulator.SQL;
using DatabaseSimulator.Tests;
using DatabaseSimulator.Tests.Enum;

namespace DatabaseSimulator
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbDatabase.DataSource = InitializeHelper.GetDatabaseDataSource();
            cmbCommand.DataSource = InitializeHelper.GetOperationSource();
            cmbDatabase.DisplayMember = "Name";
            cmbCommand.DisplayMember = "Name";
            cmbCommand.SelectedIndex = 0;
        }


        private void btnPerformNoSql_Click(object sender, EventArgs e)
        {
            int quantity = (int)cmbQuantity.Value;
            int id = (int) cmbId.Value;
            IDatabaseManager selectedDatabase = ((DatabaseServicesObject)cmbDatabase.SelectedValue).Value;
            DatabaseType type = ((DatabaseServicesObject) cmbDatabase.SelectedValue).DatabaseType;
            Operation selectedOperation = ((OperationObject) cmbCommand.SelectedValue).Value;
            selectedOperation.PerformTest(selectedDatabase,txtOutput,id,quantity,type);
        }
    }
}