using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication10.Models;

namespace WebApplication10.Models
{
    public class MoneyJson : DbContext
    {
        DbSet<ParseJson> parseJsons { get; set; }
        public MoneyJson(DbContextOptions<MoneyJson> options) : base(options) // передача данных в структуру данных EF core 
        {
            Database.EnsureCreated();
        }
    }
}
