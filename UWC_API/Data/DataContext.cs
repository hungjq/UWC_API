using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace UWC_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Collector> Collector { get; set; }
    }
}
