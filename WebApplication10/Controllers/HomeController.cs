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

namespace WebApplication10.Controllers
{
    public class HomeController : Controller
    {

     
        public IActionResult Index()
        {
            return View();
        }

        private ParseJson db;
        public HomeController(ParseJson parsejsm)
        {
            db = parsejsm;
        }
        
    }
}     
       
         
