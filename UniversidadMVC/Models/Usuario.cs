using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace UniversidadMVC
{
    public class Usuario:IdentityUser
    {
       
        public virtual List<Inscripcion> Inscripciones { get; set; }
        private string Nombre { get; set; }
        private string Apellido { get; set; }
     
        public Usuario():base() { }
    }

   
}
