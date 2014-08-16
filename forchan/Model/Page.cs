using System.Collections.Generic;
using Newtonsoft.Json;

namespace forchan.Model
{
    internal class Page
    {
        [JsonProperty("page")]
        public int PageNum { get; set; }
        [JsonProperty("threads")]
        public IEnumerable<ThreadHeader> Threads { get; set; }
    }
}
