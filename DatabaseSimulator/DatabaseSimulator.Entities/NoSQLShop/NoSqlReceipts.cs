using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSimulator.Entities.NoSQLShop
{
    public class NoSqlReceipts
    {
        public int Id { get; set; }
        public NoSqlCustomers Customer { get; set; }
        public NoSqlEmployee Employee { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string NumberString { get; set; }
    }
}