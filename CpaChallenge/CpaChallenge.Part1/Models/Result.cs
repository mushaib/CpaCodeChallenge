using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace CpaChallenge.Part1.Models
{
    public class Result
    {
        [JsonProperty("subject")]
        public string Subject { get; set; }
        [JsonProperty("results")]
        public List<Data> Results { get; set; }
    }

    public class Data
    {
        [JsonProperty("year")]
        public string Year { get; set; }
        [JsonProperty("grade")]
        public string Grade { get; set; }
    }

    public class ResultsViewModel
    {
        [JsonProperty("year")]
        public string Year { get; set; }
        [JsonProperty("subjects")]
        public List<string> Subjects { get; set; }
    }
}