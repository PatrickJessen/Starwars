using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars
{
    public class StarwarsCtx : DbContext
    {
        public DbSet<Planet> Planet { get; set; }
        public StarwarsCtx() : base()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=PJJ-P15S-2022\\SQLEXPRESS;Database=myDataBase;Trusted_Connection=True;");
        }
    }
}
