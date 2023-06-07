using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UniversidadMVC.Models;
namespace UniversidadMVC.Data
{
    public class UniversidadDbContext:IdentityDbContext<Usuario>
    {
        public UniversidadDbContext(DbContextOptions<UniversidadDbContext> options) : base(options) { }

        public UniversidadDbContext() { }



       //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       // { //esto hace la conexion con la base de datos, ahora tiene puestos
          //los datos del profesor xq nos lo paso asi


          //  optionsBuilder.UseSqlServer(@"Server=KINE-ORT;Database=PNT1_Universidad;Trusted_Connection=True;");
        
       // }
        public DbSet<Carrera> Carreras { get; set; }
        public DbSet<Inscripcion> Inscripciones { get; set; }

        public DbSet<Materia> Materias { get; set; }


        // se modifico el JSON de appsettings para utilizar el comando add-migration "nombreDB"
        //se creo la base de datos y se vinculo al SQL por medio de update-database
    }





}
    
   

