using Microsoft.EntityFrameworkCore;

namespace DEVNETCore_Web_CRUD_MVC_SQL.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public  DbSet<Produto> Produto { get; set; }
    }
}
