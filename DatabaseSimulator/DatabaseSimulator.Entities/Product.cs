namespace DatabaseSimulator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Product")]
    public partial class Product
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        public decimal? Price { get; set; }
    }
}
