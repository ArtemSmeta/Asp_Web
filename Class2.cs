using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTest
{
    public class Class2
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<ClassChild1> NewCases { get; set; }
    }
    public class ClassChild1 : Class2
    {
        public float Summary { get; set; }
        public int SMS { get; set; }
    }
    public class ClassChild2 : Class2
    {
        public float Summary { get; set; }
        public int MIN { get; set; }
        public string Abonent { get; set; }
    }
}
