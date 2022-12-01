using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace UWC_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Collector> Collector { get; set; }
        public DbSet<MCP> MCP { get; set; }
        public DbSet<Janitor> Janitor { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }

    }
}
