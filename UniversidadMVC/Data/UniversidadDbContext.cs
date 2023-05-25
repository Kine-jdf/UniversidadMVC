using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace UniversidadMVC.Data
{
    public class UniversidadDbContext:IdentityDbContext<Usuario>
    {
        public UniversidadDbContext(DbContextOptions<UniversidadDbContext> options) : base(options) { }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=NBTHINKPAD;Database=PNT1_Biblioteca;Trusted_Connection=True;");
        }
    }



       
        
 }
    
   

