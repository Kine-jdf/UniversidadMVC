using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversidadMVC
{
    public class Carrera
    {
        [Key]
        public int id { get; set; }

        public string Nombre { get; set; }

        public virtual List<Materia> Materias { get; set; }   
        public Carrera() { 
        
        this.Materias = new List<Materia>();
        }

    }
}
