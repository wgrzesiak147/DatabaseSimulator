using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseSimulator.Tests.Enum;

namespace DatabaseSimulator.Presentation.Entities
{
    public class DatabaseServicesObject
    {
        public IDatabaseManager Value { get; set; }
        public string Name { get; set; }
        public DatabaseType DatabaseType { get; set; }

        public DatabaseServicesObject(IDatabaseManager value, string name, DatabaseType type)
        {
            Value = value;
            Name = name;
            DatabaseType = type;
        }
    }
}