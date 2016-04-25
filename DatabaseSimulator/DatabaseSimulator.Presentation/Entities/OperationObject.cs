﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSimulator.Presentation.Entities
{
    public class OperationObject
    {
        public Operation Value { get; set; }
        public string Name { get; set; }

        public OperationObject(Operation value, string name)
        {
            Value = value;
            Name = name;
        }
    }
}