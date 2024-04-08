using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class DBProductosWebApi: DbContext
    {
        public DBProductosWebApi(DbContextOptions<DBProductosWebApi> options) : base(options)
        { }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
