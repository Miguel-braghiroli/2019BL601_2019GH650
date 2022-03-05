using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _2019BL601_2019GH650.Models
{
    public class Departamento
    {
        [Key]
        public int id { get; set; }
        public string departamento { get; set; }
    }
}
