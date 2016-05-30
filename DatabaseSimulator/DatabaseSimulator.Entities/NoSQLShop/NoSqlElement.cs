using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSimulator.Entities.NoSQLShop
{
    public class NoSqlElement
    {
        public int Id { get; set; }
        public NoSqlArticle NoSqlArticle { get; set; }
        public NoSqlReceipts Receipt { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
}