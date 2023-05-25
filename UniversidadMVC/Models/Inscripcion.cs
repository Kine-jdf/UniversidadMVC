using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversidadMVC
{
    public class Inscripcion
    {
        [Key]
        public int id { get; set; }
        public Usuario usuario { get; set; }
     
        public virtual List<Materia> materias { get; set; } 
        public Inscripcion() { 
        
        this.materias = new  List<Materia>();
        }    







    }
}
