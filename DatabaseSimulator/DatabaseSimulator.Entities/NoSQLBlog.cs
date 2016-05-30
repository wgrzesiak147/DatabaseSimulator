using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSimulator.Entities
{

    public class NoSQLBlog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<NoSQLPost> Post { get; set; }
    }
}
