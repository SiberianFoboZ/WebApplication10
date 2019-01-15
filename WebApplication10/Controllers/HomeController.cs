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

        private JSonMoney db;
        public HomeController(JSonMoney sonMoney)
        {
            db = sonMoney;
        }
        public async Task<IActionResult> Index()
        {
            return View(await db.Mones.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Money money)
        {
            db.Mones.Add(money);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public ActionResult JsonExample()
        {
            return View();
        }
        
    }
}     
       
         
