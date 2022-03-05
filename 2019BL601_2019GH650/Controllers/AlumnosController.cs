using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _2019BL601_2019GH650.Data;
using _2019BL601_2019GH650.Models;

namespace _2019BL601_2019GH650.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnosController : ControllerBase
    {
        private readonly _2019BL601_2019GH650Context _context;

        public AlumnosController(_2019BL601_2019GH650Context context)
        {
            _context = context;
        }

        // GET: api/Alumnos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Alumnos>>> GetAlumnos()
        {
            return await _context.Alumnos.ToListAsync();
        }

        // GET: api/Alumnos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Alumnos>> GetAlumnos(int id)
        {
            var alumnos = await _context.Alumnos.FindAsync(id);

            if (alumnos == null)
            {
                return NotFound();
            }

            return alumnos;
        }

        // PUT: api/Alumnos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlumnos(int id, Alumnos alumnos)
        {
            if (id != alumnos.id)
            {
                return BadRequest();
            }

            _context.Entry(alumnos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlumnosExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Alumnos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Alumnos>> PostAlumnos(Alumnos alumnos)
        {
            _context.Alumnos.Add(alumnos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAlumnos", new { id = alumnos.id }, alumnos);
        }

        // DELETE: api/Alumnos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAlumnos(int id)
        {
            var alumnos = await _context.Alumnos.FindAsync(id);
            if (alumnos == null)
            {
                return NotFound();
            }

            _context.Alumnos.Remove(alumnos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AlumnosExists(int id)
        {
            return _context.Alumnos.Any(e => e.id == id);
        }
    }
}
