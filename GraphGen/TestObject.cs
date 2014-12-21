﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinarySerialization;

namespace GraphGen
{
    class TestObject
    {
        public int NameLength { get; set; }

        [FieldLength("NameLength")]
        public string Name { get; set; }

        public uint Age { get; set; }

        [Subtype("Age", 0, typeof(SubtypeChildClassA))]
        [Subtype("Age", 1, typeof(SubtypeChildClassA))]
        public SubtypeBaseClass Details { get; set; }
    }
}