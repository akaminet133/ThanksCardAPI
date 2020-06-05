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
    public class Comment_RirekisController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public Comment_RirekisController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/Comment_Rirekis
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Comment_Rireki>>> GetComment_Rirekis()
        {
            return await _context.Comment_Rirekis.ToListAsync();
        }

        // GET: api/Comment_Rirekis/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Comment_Rireki>> GetComment_Rireki(long id)
        {
            var Comment_Rireki = await _context.Comment_Rirekis.FindAsync(id);

            if (Comment_Rireki == null)
            {
                return NotFound();
            }

            return Comment_Rireki;
        }

        // POST: api/Comment_Rirekis
        [HttpPost]
        public async Task<ActionResult<Comment_Rireki>> PostComment_Rireki(Comment_Rireki Comment_Rireki)
        {
            _context.Comment_Rirekis.Add(Comment_Rireki);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetComment_Rireki", new { id = Comment_Rireki.Id }, Comment_Rireki);
        }

        private bool Comment_RirekiExists(long id)
        {
            return _context.Comment_Rirekis.Any(e => e.Id == id);
        }
    }
}