using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CpaChallenge.Part1.Api
{
    [RoutePrefix("/api/results2")]
    public class Results2Controller : ApiController
    {
        [Route("")]
        public  IEnumerable<Models.Result> Get()
        {
            var path = string.Concat(AppDomain.CurrentDomain.BaseDirectory, @"\App_Data\data.json");

            using (var s = new StreamReader(path))
            {
                var data = s.ReadToEnd();

                return JsonConvert.DeserializeObject<IEnumerable<Models.Result>>(data);
            }            
        }
    }
}
