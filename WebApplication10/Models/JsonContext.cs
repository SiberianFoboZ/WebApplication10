using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication10.Models;

namespace WebApplication10.Models
{
    public class JsonContext : DbContext
    {
        public DbSet<Rates> jsons { get; set; }
        public DbSet<Date> dates { get; set; }
        public JsonContext(DbContextOptions<JsonContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
