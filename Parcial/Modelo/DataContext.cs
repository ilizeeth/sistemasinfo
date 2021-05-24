using Microsoft.EntityFrameworkCore;
namespace Parcial
{
    class DataContext : DbContext
    {
        private static bool Create = false;
        public DbSet<Libro> libros {get; set;}
        public DbSet<Datos> data {get; set;}

        public DataContext(){
            if(! Create){
                Create= true;
                Database.EnsureDeleted();
                Database.EnsureCreated();
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder opciones)=>
            opciones.UseSqlite(@"Data Source=Catalogo.db");
    }
}