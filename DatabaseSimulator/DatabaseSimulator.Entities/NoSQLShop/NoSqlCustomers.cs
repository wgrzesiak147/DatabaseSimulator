using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSimulator.Entities.NoSQLShop
{
    public class NoSqlCustomers
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public NoSqlPersonalData PersonalData { get; set; }
        public string AdditionalInformations { get; set; }
    }
}