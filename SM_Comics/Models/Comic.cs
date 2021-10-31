using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SM_Comics.Models
{
    public class Comic
    {
        public string Id { get; set; }
        public string Maker { get; set; }
        public string Image { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Published { get; set; }
        public string Series { get; set; }
        public int Series_Id { get; set; }
        public string[] Pages { get; set; }
        public int OnPage { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Comic>(this);

    }
}
