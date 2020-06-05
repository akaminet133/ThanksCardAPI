using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ThanksCardAPI.Models;

namespace ThanksCardAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectionsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public SectionsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/Sections
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Section>>> GetSections()
        {
            return await _context.Sections.ToListAsync();
        }

        // GET: api/Sections/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Section>> GetSection(long id)
        {
            var Section = await _context.Sections.FindAsync(id);

            if (Section == null)
            {
                return NotFound();
            }

            return Section;
        }

        // PUT: api/Sections/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSection(long id, Section Section)
        {
            if (id != Section.Id)
            {
                return BadRequest();
            }

            _context.Entry(Section).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SectionExists(id))
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

        // POST: api/Sections
        [HttpPost]
        public async Task<ActionResult<Section>> PostSection(Section Section)
        {
            _context.Sections.Add(Section);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSection", new { id = Section.Id }, Section);
        }

        // DELETE: api/Sections/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Section>> DeleteSection(long id)
        {
            var Section = await _context.Sections.FindAsync(id);
            if (Section == null)
            {
                return NotFound();
            }

            _context.Sections.Remove(Section);
            await _context.SaveChangesAsync();

            return Section;
        }

        private bool SectionExists(long id)
        {
            return _context.Sections.Any(e => e.Id == id);
        }

    }
}