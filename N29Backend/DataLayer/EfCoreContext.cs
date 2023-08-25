using Microsoft.EntityFrameworkCore;
using N29Backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N29Backend.DataLayer
{
    internal class EfCoreContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
            => optionsBuilder.UseNpgsql("Server=localhost;Port=5432;UserName=postgres;Database=postgres;Password=postgres");
        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }
    }
}
