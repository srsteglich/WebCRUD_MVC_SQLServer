using Microsoft.EntityFrameworkCore;

namespace WebCRUD_MVC_SQLServer.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<Cliente> Cliente { get; set; }
    }
}
