using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DropletsDB.Models;

namespace DropletsDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SavingsBucketsController : ControllerBase
    {
        private readonly DropletsDBContext _context;

        public SavingsBucketsController(DropletsDBContext context)
        {
            _context = context;
        }

        // GET: api/SavingsBuckets
        [HttpGet]
        public IEnumerable<SavingsBucket> GetSavingsBucket()
        {
            return _context.SavingsBucket;
        }

        // GET: api/SavingsBuckets/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSavingsBucket([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var savingsBucket = await _context.SavingsBucket.FindAsync(id);

            if (savingsBucket == null)
            {
                return NotFound();
            }

            return Ok(savingsBucket);
        }

        // PUT: api/SavingsBuckets/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSavingsBucket([FromRoute] int id, [FromBody] SavingsBucket savingsBucket)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != savingsBucket.SavingsBucketId)
            {
                return BadRequest();
            }

            _context.Entry(savingsBucket).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SavingsBucketExists(id))
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

        // POST: api/SavingsBuckets
        [HttpPost]
        public async Task<IActionResult> PostSavingsBucket([FromBody] SavingsBucket savingsBucket)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.SavingsBucket.Add(savingsBucket);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSavingsBucket", new { id = savingsBucket.SavingsBucketId }, savingsBucket);
        }

        // DELETE: api/SavingsBuckets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSavingsBucket([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var savingsBucket = await _context.SavingsBucket.FindAsync(id);
            if (savingsBucket == null)
            {
                return NotFound();
            }

            _context.SavingsBucket.Remove(savingsBucket);
            await _context.SaveChangesAsync();

            return Ok(savingsBucket);
        }

        private bool SavingsBucketExists(int id)
        {
            return _context.SavingsBucket.Any(e => e.SavingsBucketId == id);
        }
    }
}