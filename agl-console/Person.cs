using System;
using System.Collections.Generic;
using System.Text;

namespace agl_console
{
    class Person
    {
        public string name { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public virtual ICollection<Pet> pets { get; set; }

    }
}
