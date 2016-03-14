using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSimulator.NoSQL.Entities
{
   public class Blog
    {
        public int ObjectId_id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string RssUrl { get; set; }
        public List<RssEntry> Entries { get; set; }

    }
}
