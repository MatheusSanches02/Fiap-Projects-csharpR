using Microsoft.EntityFrameworkCore;

namespace Fiap.Aula05.Web.Models.Persistencia
{
    public class DimDimContext : DbContext
    {
        public DbSet<Investimento> Investimentos { get; set; } //set conjunto que nao possui dados indexados e nao repetem os elementos
        public DimDimContext(DbContextOptions options) : base(options)
        {
        }
    }
}
