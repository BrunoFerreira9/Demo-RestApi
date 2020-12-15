using restDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace restDemo.Controllers
{
    public class WeatherController : ApiController
    {
        // GET: api/Weather
        public IEnumerable<Weather> Get()
        {
            var weatherinfoList = new List<Weather>();

            for (int i = 0; i < 10; i++)
            {
                var weatherinfo = new Weather
                {
                    Location = $"Location{i}",
                    Degrees = i * 23 / 17,
                    DateTime = DateTime.Now.ToUniversalTime()
                };

                weatherinfoList.Add(weatherinfo);
            }
            return weatherinfoList;
        }

        // GET: api/Weather/5
        public Weather Get(int id)
        {
            return new Weather
            {
                Location = $"Location{id}",
                Degrees = id * 23 / 17,
                DateTime = DateTime.Now.ToUniversalTime()
            };
        }

        
    }
}
