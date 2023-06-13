using LevvaCoins.Domain.Models;
using LevvaCoins.Logic.Dtos;
using Microsoft.EntityFrameworkCore;

namespace LevvaCoins.Data
{
    public class Context : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Transacao> Transacao { get; set; }
        public DbSet<Categoria> Categoria { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }
    }
}
