using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace agl_console
{
    public class Pet
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
