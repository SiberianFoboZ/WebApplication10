using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication10.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.Data.SqlClient;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.IO;

namespace WebApplication10.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index(DateTime lastDate, DateTime firstDate)
        {

            int days = (lastDate.Day - firstDate.Day);
            int year = firstDate.Year;
            int month = firstDate.Month;
            for (int i = 0; i <days;i++)
            {
                WebRequest request = WebRequest.Create("https://openexchangerates.org/api/historical/2019-01-"+i+".json?app_id=bcf546b9a0ea43518b0cbcff6a43a1d6&symbols=USD%2CRUB%2CEUR%2CGBP%2CJPY");
                WebResponse web = request.GetResponse();
                Stream st = web.GetResponseStream();
                StreamReader reader = new StreamReader(st);
                string data = reader.ReadToEnd();
                Console.WriteLine(data);
                Rates temp = JsonConvert.DeserializeObject<Rates>(data);
            }
           

            return View();

        }

        [HttpPost]
        public IActionResult Index()
        {           

            return View();
        }

        private JsonContext db;
        public HomeController(JsonContext context)
        {
            db = context;
        }




    }
}


