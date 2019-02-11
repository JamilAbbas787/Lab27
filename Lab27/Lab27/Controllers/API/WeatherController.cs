using Lab27.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Lab27.Controllers.API
{
    public class WeatherController : ApiController
    {
        private Weather _context = new Weather(); 

        // GET: api/Weather/5
        //public string Get()
        //{
        //    return HttpContent($"/api/weather");
        //    //return "value";
        //}

        // POST: api/Weather
        public void Post([FromBody]string value)
        {
        }
    }
}
