using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSimulator.NoSQL.Entities
{
    public class RssEntry
    {
        public int ObjectId_id { get; set; }

        public Guid UniqueId { get; set; }
        public DateTime PostedDate { get; set; }
        public string Title { get; set; }
        public string RssGuid { get; set; }


    }
}
