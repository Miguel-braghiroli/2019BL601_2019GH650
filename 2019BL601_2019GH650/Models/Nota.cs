using System;

namespace _2019BL601_2019GH650.Models
{
    public class Nota
    {
        public int id { get; set; }
        public int inscripcion { get; set; }
        public string evaluacion { get; set; }
        public double nota { get; set; }
        public double porcentaje { get; set; }
        public DateTime fecha { get; set; }
    }
}