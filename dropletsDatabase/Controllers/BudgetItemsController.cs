using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dropletsDatabase.Models;

namespace dropletsDatabase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BudgetItemsController : ControllerBase
    {
        private readonly Droplets _context;

        public BudgetItemsController(Droplets context)
        {
            _context = context;
        }

        // GET: api/BudgetItems
        [HttpGet]
        public IEnumerable<BudgetItem> GetBudgetItems()
        {
            return _context.BudgetItems;
        }

        // GET: api/BudgetItems/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBudgetItem([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var budgetItem = await _context.BudgetItems.FindAsync(id);

            if (budgetItem == null)
            {
                return NotFound();
            }

            return Ok(budgetItem);
        }

        // PUT: api/BudgetItems/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBudgetItem([FromRoute] long id, [FromBody] BudgetItem budgetItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != budgetItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(budgetItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BudgetItemExists(id))
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

        // POST: api/BudgetItems
        [HttpPost]
        public async Task<IActionResult> PostBudgetItem([FromBody] BudgetItem budgetItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BudgetItems.Add(budgetItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBudgetItem", new { id = budgetItem.Id }, budgetItem);
        }

        // DELETE: api/BudgetItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBudgetItem([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var budgetItem = await _context.BudgetItems.FindAsync(id);
            if (budgetItem == null)
            {
                return NotFound();
            }

            _context.BudgetItems.Remove(budgetItem);
            await _context.SaveChangesAsync();

            return Ok(budgetItem);
        }

        private bool BudgetItemExists(long id)
        {
            return _context.BudgetItems.Any(e => e.Id == id);
        }
    }
}