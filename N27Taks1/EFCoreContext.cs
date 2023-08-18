using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N27Taks1
{
    internal class EFCoreContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql
                ("Server=localhost;Port=5432;UserName=postgres;Database=postgres;Password=postgres;");
        public DbSet<Person> People { get; set; }
    }
}
