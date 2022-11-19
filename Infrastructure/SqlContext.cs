using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }

        public DbSet<Pessoa> Pessoa { get; set; }
    }
}