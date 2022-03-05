using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _2019BL601_2019GH650.Models
{
    public class Inscripciones
    {
        public int id { get; set; }
        public Materias materia { get; set; }
        public int inscripcion { get; set; }
        public DateTime fecha { get; set; }
        public string estado { get; set; }
        public int alumnoid { get; set; }
        public virtual Alumnos alumno { get; set; }
    }
}
