using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversidadMVC
{
    public class Materia
    {
        [Key]
        public int id { get; set; }
        public string Nombre { get; set; }
        public Carrera Carrera { get; set; }    

        public virtual List<Inscripcion> inscriptos { get; set; }  

        public Materia() { 
        this.inscriptos = new List<Inscripcion>();
        }    
    }
}
