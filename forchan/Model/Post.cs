using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace forchan.Model
{
    class Post
    {
        [JsonProperty("no")]
        public int Id { get; set; }
        [JsonProperty("now")]
        public string CreationDate { get; set; }
        [JsonProperty("name")]
        public string Author { get; set; }
        [JsonProperty("com")]
        public string Body { get; set; }
        [JsonProperty("filename")]
        public string Filename { get; set; }
        [JsonProperty("ext")]
        public string FileExtension { get; set; }
        [JsonProperty("w")]
        public int FileWidth { get; set; }
        [JsonProperty("h")]
        public int FileHeight { get; set; }
        /*
        [JsonProperty("tn_w")]
        public int MinatureWidth { get; set; }
        [JsonProperty("tn_h")]
        public int MinatureHeight { get; set; } 
        [JsonProperty("tim")]
        public long TimeMs { get; set; }
         */
        [JsonProperty("time")]
        public int Time { get; set; }
        /*public string md5 { get; set; }*/
        [JsonProperty("fsize")]
        public int FileSize { get; set; }
        [JsonProperty("resto")]
        public int ResponseTo { get; set; }
        /*public int bumplimit { get; set; }
        public int imagelimit { get; set; }
        public string semantic_url { get; set; }
        public int custom_spoiler { get; set; }
        public int replies { get; set; }
        public int images { get; set; }
        public int? spoiler { get; set; }*/
        [JsonProperty("trip")]
        public string TripCode { get; set; }
    }
}