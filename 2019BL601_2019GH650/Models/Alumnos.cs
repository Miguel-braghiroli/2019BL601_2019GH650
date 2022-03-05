using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _2019BL601_2019GH650.Models
{
    public class Alumnos
    {
        public int id { get; set; }
        public string carnet { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public int dui { get; set; }
        public int estado { get; set; }
        public virtual List<Inscripciones> inscripciones { get; set; }
    }
}
