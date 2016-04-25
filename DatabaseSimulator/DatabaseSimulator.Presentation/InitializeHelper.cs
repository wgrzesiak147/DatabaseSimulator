using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseSimulator.Presentation.Entities;
using System.Windows.Forms;
using DatabaseSimulator.CrudeMongo;
using DatabaseSimulator.MSSQL;
using DatabaseSimulator.NoSQL;
using DatabaseSimulator.SQL;
using DatabaseSimulator.Tests;
using DatabaseSimulator.Tests.Enum;
using DatabaseSimulator.Tests.Tests;


namespace DatabaseSimulator.Presentation
{
    public static class InitializeHelper
    {
        public static BindingList<DatabaseServicesObject> GetDatabaseDataSource()
        {
            return new BindingList<DatabaseServicesObject>()
            {
                {new DatabaseServicesObject(new Mongo_NoRM_Services(), "MongoDB - NORM",DatabaseType.MongoDB)},
                {new DatabaseServicesObject(new MSSQL_EntityFramework_Services(), "MSSQL - Entity Framework",DatabaseType.MSSQL)},
                {new DatabaseServicesObject(new MSSQL_ADO_Services(), "MSSQL - ADO.NET",DatabaseType.MSSQL)},
                {new DatabaseServicesObject(new Mongo_Crude_Services(), "MongoDB",DatabaseType.MongoDB)}
            };
        }

        public static BindingList<OperationObject> GetOperationSource()
        {
            return new BindingList<OperationObject>()
            {
                {new OperationObject(new BlogClean(), "Blog - Clean")},
                {new OperationObject(new BlogGetAllOperation(), "Blog - Get all")},
                {new OperationObject(new BlogGetByIdOperation(), "Blog - Get by Id")},
                {new OperationObject(new BlogInsertOperation(), "Blog - Insert")},
                {new OperationObject(new ProductClean(), "Product - Clean")},
                {new OperationObject(new ProductGetAllOperation(), "Product - Get all")},
                {new OperationObject(new ProductGetByIdOperation(), "Product - Get by Id")},
                {new OperationObject(new ProductInsertOperation(), "Product - insert")}
            };
        }
    }
}