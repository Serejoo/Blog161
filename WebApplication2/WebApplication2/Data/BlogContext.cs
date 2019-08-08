using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;


namespace WebApplication2.Data
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Mensagem> Mensagems{ get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        
        }
    }
}
