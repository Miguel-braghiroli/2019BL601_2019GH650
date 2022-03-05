using System;

namespace _2019BL601_2019GH650.Models
{
    public class Notas
    {
        public int id { get; set; }
        public string evaluacion { get; set; }
        public decimal nota { get; set; }
        public decimal porcentaje { get; set; }
        public DateTime fecha { get; set; }
        public int inscripcionId { get; set; }
        public virtual Inscripciones inscripcion { get; set; }
    }
}