using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace WebApplication10.Models
{
    public class JSonMoney : DbContext
    {
        public DbSet<Money> Mones { get; set; }
        public JSonMoney(DbContextOptions<JSonMoney> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
