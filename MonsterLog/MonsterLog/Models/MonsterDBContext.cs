using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonsterLog.Models
{
    public class MonsterDBContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Monster> Monsters { get; set; }

        public MonsterDBContext(DbContextOptions<MonsterDBContext> options) : base(options)
        {

        }

        
    }
}
