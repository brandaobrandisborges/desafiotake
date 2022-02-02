using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace Blip.Api.Template.Models.Response
{
    public class Repositories
    {
        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("language")]
        public object Language { get; set; }

        [JsonProperty("description")]
        public object Description { get; set; }
    }
}
