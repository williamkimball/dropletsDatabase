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
    public class BudgetItemsController : ControllerBase
    {
        private readonly DropletsDBContext _context;

        public BudgetItemsController(DropletsDBContext context)
        {
            _context = context;
        }

        // GET: api/BudgetItems
        [HttpGet]
        public IEnumerable<BudgetItem> GetBudgetItem()
        {
            return _context.BudgetItem;
        }

        // GET: api/BudgetItems/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBudgetItem([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var budgetItem = await _context.BudgetItem.FindAsync(id);

            if (budgetItem == null)
            {
                return NotFound();
            }

            return Ok(budgetItem);
        }

        // PUT: api/BudgetItems/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBudgetItem([FromRoute] int id, [FromBody] BudgetItem budgetItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != budgetItem.BudgetItemId)
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

            _context.BudgetItem.Add(budgetItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBudgetItem", new { id = budgetItem.BudgetItemId }, budgetItem);
        }

        // DELETE: api/BudgetItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBudgetItem([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var budgetItem = await _context.BudgetItem.FindAsync(id);
            if (budgetItem == null)
            {
                return NotFound();
            }

            _context.BudgetItem.Remove(budgetItem);
            await _context.SaveChangesAsync();

            return Ok(budgetItem);
        }

        private bool BudgetItemExists(int id)
        {
            return _context.BudgetItem.Any(e => e.BudgetItemId == id);
        }
    }
}