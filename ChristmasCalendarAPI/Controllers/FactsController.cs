using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChristmasCalendarAPI.Data;
using ChristmasCalendarAPI.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChristmasCalendarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FactsController : ControllerBase
    {
        private readonly CalendarDbContext _context;
        public FactsController(CalendarDbContext context) {
            _context = context;
        }
        // GET api/values
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fact>>> GetFacts() {
            return await _context.Facts.ToListAsync();
        }

        // GET api/values/5
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Fact>> GetFactsById(int id) {
            var fact = await _context.Facts.FindAsync(id);

            if(fact == null) {
                return NotFound();
            }
            return fact;
        }

        // POST: api/Facts
        [HttpPost]
        public async Task<ActionResult<Fact>> PostFact(Fact fact) {
            _context.Facts.Add(fact);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFact", new { id = fact.ID }, fact);
        }

        // DELETE: api/Facts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Fact>> DeleteFact(int id) {
            var fact = await _context.Facts.FindAsync(id);
            if (fact == null) {
                return NotFound();
            }

            _context.Facts.Remove(fact);
            await _context.SaveChangesAsync();

            return fact;
        }

        private bool FactExists(int id) {
            return _context.Facts.Any(e => e.ID == id);
        }

    }
}
