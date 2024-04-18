using CP_MVC_RM550889.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CP_MVC_RM550889.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<User> PZ_Users { get; set; }
        public DbSet<Avaliacao> PZ_Avaliacoes { get; set; }
    }
}
