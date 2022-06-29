using Microsoft.EntityFrameworkCore;
using Brainlaw.Domain.Models;

namespace Brainlaw.Infrastructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext(){}

        public SqlContext(DbContextOptions<SqlContext> options) : base(options) {}

        public DbSet<Produto> Produtos { get; set; }
    }
}