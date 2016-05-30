using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSimulator.Entities.NoSQLShop
{
    public class NoSqlEmployee
    {
        public int Id { get; set; }
        public NoSqlPersonalData NoSqlPersonalData { get; set; }
        public string Occupation { get; set; }
        public string LicenseStarted { get; set; }
        public string LicenseEnd { get; set; }
    }
}