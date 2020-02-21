using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace agl_console
{
    public class Person
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("gender")]
        public string Gender { get; set; }
        [JsonPropertyName("age")]
        public int Age { get; set; }
        [JsonPropertyName("pets")]
        public virtual ICollection<Pet> Pets { get; set; }

        public override string ToString() { return "Person name:" + Name; }

    }
}
