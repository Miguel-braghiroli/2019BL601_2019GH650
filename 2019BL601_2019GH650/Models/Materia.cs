using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _2019BL601_2019GH650.Models
{
    public class Materia
    {
        [Key]
        public int id { get; set; }
        public virtual Facultad facultad { get; set; }
        public string materia { get; set; }
        public int unidades_valorativas { get; set; }
        public string estado { get; set; }
        public List<Inscripciones> inscripciones { get; set; }
    }
}