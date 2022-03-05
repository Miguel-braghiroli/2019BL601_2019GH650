using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _2019BL601_2019GH650.Models;

namespace _2019BL601_2019GH650.Data
{
    public class _2019BL601_2019GH650Context : DbContext
    {
        public _2019BL601_2019GH650Context (DbContextOptions<_2019BL601_2019GH650Context> options)
            : base(options)
        {
        }

        public DbSet<_2019BL601_2019GH650.Models.Facultad> Facultad { get; set; }
        public DbSet<_2019BL601_2019GH650.Models.Inscripciones> Inscripciones { get; set; }
        public DbSet<_2019BL601_2019GH650.Models.Departamentos> Departamentos { get; set; }
        public DbSet<_2019BL601_2019GH650.Models.Materias> Materias { get; set; }
        public DbSet<_2019BL601_2019GH650.Models.Notas> Notas { get; set; }
        public DbSet<_2019BL601_2019GH650.Models.Alumnos> Alumnos { get; set; }

    }
}
