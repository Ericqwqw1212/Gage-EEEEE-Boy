using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonsterLog.Models
{
    public class MonsterDBContext : DbContext
    {
        public DbSet<Monster> Monsters { get; set; }

        public MonsterDBContext(DbContextOptions<MonsterDBContext> options) : base(options)
        { /**/ }

        
    }
}
