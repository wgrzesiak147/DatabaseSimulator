﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSimulator.Entities
{
    public class NoSQLPost
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
