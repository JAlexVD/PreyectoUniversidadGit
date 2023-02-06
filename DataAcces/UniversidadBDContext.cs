using Microsoft.EntityFrameworkCore;
using Proyecto_Universidad.Models.DataModels;

namespace Proyecto_Universidad.DataAcces
{
    public class UniversidadBDContext: DbContext
    {
        public UniversidadBDContext(DbContextOptions<UniversidadBDContext> options) : base(options) 
        {
        
        }
        //Para crear las Tablas de la BD
        public DbSet<User>? Users { get; set; }
        public DbSet<Course>? Courses { get; set; }
        public DbSet<Chapter>? Chapters { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
