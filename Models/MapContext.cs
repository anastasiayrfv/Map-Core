using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Map.Models
{
    public class MapContext:DbContext
    {
        public MapContext(DbContextOptions<MapContext> options)
        : base(options) { }

        public DbSet<Place> Places { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
