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
    public class User_Dep_KanriController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public User_Dep_KanriController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/User_Dep_Kanri
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User_Dep_Kanri>>> GetUser_Dep_Kanri()
        {
            return await _context.User_Dep_Kanris
                                    .Include(User_Dep_Kanri => User_Dep_Kanri.User)
                                    .Include(User_Dep_Kanri => User_Dep_Kanri.Section)
                                    .ThenInclude(Section => Section.Department)
                                    .ToListAsync();
        }

        // GET: api/User_Dep_Kanri/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User_Dep_Kanri>> GetUser_Dep_Kanri(long id)
        {
            var User_Dep_Kanri = await _context.User_Dep_Kanris.FindAsync(id);

            if (User_Dep_Kanri == null)
            {
                return NotFound();
            }

            return User_Dep_Kanri;
        }

        // PUT: api/User_Dep_Kanri/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser_Dep_Kanri(long id, User_Dep_Kanri User_Dep_Kanri)
        {
            if (id != User_Dep_Kanri.Id)
            {
                return BadRequest();
            }

            _context.Entry(User_Dep_Kanri).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!User_Dep_KanriExists(id))
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

        // POST: api/User_Dep_Kanri
        [HttpPost]
        public async Task<ActionResult<User_Dep_Kanri>> PostUser_Dep_Kanri(User_Dep_Kanri User_Dep_Kanri)
        {
            _context.User_Dep_Kanris.Add(User_Dep_Kanri);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser_Dep_Kanri", new { id = User_Dep_Kanri.Id }, User_Dep_Kanri);
        }

        // DELETE: api/User_Dep_Kanri/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<User_Dep_Kanri>> DeleteUser_Dep_Kanri(long id)
        {
            var User_Dep_Kanri = await _context.User_Dep_Kanris.FindAsync(id);
            if (User_Dep_Kanri == null)
            {
                return NotFound();
            }

            _context.User_Dep_Kanris.Remove(User_Dep_Kanri);
            await _context.SaveChangesAsync();

            return User_Dep_Kanri;
        }

        private bool User_Dep_KanriExists(long id)
        {
            return _context.User_Dep_Kanris.Any(e => e.Id == id);
        }
    }
}