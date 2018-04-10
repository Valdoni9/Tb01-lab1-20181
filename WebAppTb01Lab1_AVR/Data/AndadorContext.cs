using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebAppTb01Lab1_AVR.Models
{
    public class AndadorContext : DbContext
    {
        public AndadorContext (DbContextOptions<AndadorContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppTb01Lab1_AVR.Models.Automovel> Automovel { get; set; }
    }
}
