using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using DatabaseSimulator.Entities;
using DatabaseSimulator.Presentation;
using DatabaseSimulator.Presentation.Entities;
using DatabaseSimulator.Tests;
using DatabaseSimulator.Tests.Generic;
using DatabaseSimulator.Tests.NoSQL;
using DatabaseSimulator.Tests.SQL;

namespace DatabaseSimulator
{


    
    public partial class Form1 : Form
    {
        
       // private  NoSqlTestManager _noSqlTestManager;
       // private  SqlTestManager _sqlTestManager;

        private BindingList<TestManagerObject> _databasesTestManagers;


        public Form1()
        {
            InitializeComponent();

           // _sqlTestManager = new SqlTestManager(txtOutput);
           // _noSqlTestManager = new NoSqlTestManager(txtOutput);
            InitializeHelper.InitializeOutput(txtOutput);
            cmbDatabase.DataSource = InitializeHelper.InitializeTestManagers();
            cmbDatabase.DisplayMember = "Name";
      
            cmbEntity.SelectedIndex = 0;
            cmbCommand.SelectedIndex = 0;


        }

       

        private void btnPerformNoSql_Click(object sender, EventArgs e)
        {
            int quantity = (int)cmbQuantity.Value;

            ITestManager selectedDatabase = ((TestManagerObject)cmbDatabase.SelectedValue).Value;
            IOperation selectedOperation = ((OperationObject) cmbCommand.SelectedValue).Value;
            IEntity selectedEntity = ((EntityObject) cmbEntity.SelectedValue).Value;

          
            // IOperation operation = 

//            if (cmbCommand.Text == "Insert")
//            {
//                if (cmbEntity.Text == "Product")
//                {
//                    _databasesTestManagers[selectedDatabase].PerformProductInserts(quantity);
//                }
//                else if (cmbEntity.Text == "Blog")
//                {
//                    _databasesTestManagers[selectedDatabase].PerformBlogInserts(quantity);
//                }
//            }
//            else if (cmbCommand.Text == "GetAll")
//            {
//                if (cmbEntity.Text == "Product")
//                {
//                    _databasesTestManagers[selectedDatabase].PerformProductGetAll();
//                }
//                else if (cmbEntity.Text == "Blog")
//                {
//                    _databasesTestManagers[selectedDatabase].PerformBlogGetAll();
//                }
//            }
//            if (cmbCommand.Text == "Insert")
//            {
//                if (cmbEntity.Text == "Product")
//                {
//                    _databasesTestManagers[selectedDatabase].PerformProductInserts(quantity);
//                }
//                else if (cmbEntity.Text == "Blog")
//                {
//                    _databasesTestManagers[selectedDatabase].PerformBlogInserts(quantity);
//                }
//            }
//            else if (cmbCommand.Text == "Clean")
//            {
//                if (cmbEntity.Text == "Product")
//                {
//                    _databasesTestManagers[selectedDatabase].PerformProductClean();
//                }
//                else if (cmbEntity.Text == "Blog")
//                {
//                    _databasesTestManagers[selectedDatabase].PerformBlogClean();
//                }
            //}
        }
    }
}