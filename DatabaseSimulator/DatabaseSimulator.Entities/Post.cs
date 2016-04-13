using DatabaseSimulator.Entities;

namespace DatabaseSimulator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Post")]
    public partial class Post
    {
        public int Id { get; set; }

        [StringLength(10)]
        public string Title { get; set; }

        [StringLength(20)]
        public string Content { get; set; }

        public int? BlogId { get; set; }

        public virtual Blog Blog { get; set; }
    }
}
