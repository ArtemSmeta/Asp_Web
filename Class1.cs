﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTest
{
    public class Class1
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Class2> Cases { get; set; }
    }
}
