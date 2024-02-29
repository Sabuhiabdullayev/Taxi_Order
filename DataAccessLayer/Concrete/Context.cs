using EntitiesLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ADMIN-ПК; Database=TaxiApi; Integrated security=true;");
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }
    }
}
