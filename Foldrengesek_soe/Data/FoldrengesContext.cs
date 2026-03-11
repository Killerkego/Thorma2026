using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Foldrengesek_soe.Data
{
    public class FoldrengesContext : DbContext
    {
        public DbSet<Models.Telepules> Telepulesek { get; set; } = null!;
        public DbSet<Models.Naplo> Naplok { get; set; } = null!;

        public FoldrengesContext(DbContextOptions<FoldrengesContext> options) : base(options) { }
    }
}
