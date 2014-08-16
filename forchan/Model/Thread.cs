using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace forchan.Model
{
    internal class ThreadHeader
    {
        [JsonProperty("no")]
        public int Id { get; set; }
        [JsonProperty("last_modified")]
        public int LastModified { get; set; }
    }

    internal class ThreadBody
    {
        [JsonProperty("posts")]
        public IEnumerable<Post> Posts { get; set; }
    }
}
