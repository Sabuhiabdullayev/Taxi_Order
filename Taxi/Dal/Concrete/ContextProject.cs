using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Taxi.Dal.Entities;

namespace Taxi.Dal.Concrete
{
    public class ContextProject:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ADMIN-ПК; Database=Taxi; Integrated security=true;");
        }
    }
}
