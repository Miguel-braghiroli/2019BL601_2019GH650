using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _2019BL601_2019GH650.Models
{
    public class Alumno
    {
        [Key]
        public int id { get; set; }
        public string carnet { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dui { get; set; }
        public virtual Departamento departamento { get; set; }
        public int estado { get; set; }
    }
}
