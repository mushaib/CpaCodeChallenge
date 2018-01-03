using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace CpaChallenge.Part1.Api
{
    [RoutePrefix("/api/results")]
    public class ResultsController : ApiController
    {
        private const string ApiUrl = "https://cpacodingchallenge.azurewebsites.net/api/results";

        [Route("")]        
        public async Task<IEnumerable<Models.ResultsViewModel>> Get()
        {
            using (var client = new HttpClient())
            {
                var res = await client.GetAsync(ApiUrl);

                if (res.IsSuccessStatusCode)
                {
                    var results = await res.Content.ReadAsAsync<IEnumerable<Models.Result>>();

                    return results.SelectMany(a => a.Results, (a, b) => new { a, b })
                        .Where(c => c.b.Grade == "PASS")
                        .GroupBy(ab => ab.b.Year)
                        .OrderBy(p =>p.Key)
                        .Select(x => new Models.ResultsViewModel
                        {
                            Year = x.Key,
                            Subjects = x.Select(t => t.a.Subject).OrderBy(t=> t).ToList()
                        }).ToList();
                    
                }
            }
            return null;
        }
    }
}