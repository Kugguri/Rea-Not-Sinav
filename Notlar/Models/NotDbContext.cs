using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notlar.Models
{
    public class NotDbContext : DbContext
    {
        public NotDbContext(DbContextOptions<NotDbContext> options) : base(options)
        {

        }
        public DbSet<Not> Notlar { get; set; }
    }
}
