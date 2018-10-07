using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using dropletsDatabase.Models;

namespace dropletsDatabase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserContext _context;

        public AccountController(UserContext context)
        {
            _context = context;

            if (_context.Accounts.Count() == 0)
            {
                // Create a new User if collection is empty,
                // which means you can't delete all User.
                _context.Accounts.Add(new Account { Name = "Test Account" });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public ActionResult<List<Account>> GetAll()
        {
            return _context.Accounts.ToList();
        }

        [HttpGet("{id}", Name = "GetAccount")]
        public ActionResult<Account> GetById(long id)
        {
            var item = _context.Accounts.Find(id);
            return item == null ? (ActionResult<Account>)NotFound() : (ActionResult<Account>)item;
        }
        [HttpPost]
        public IActionResult Create(Account item)
        {
            _context.Accounts.Add(item);
            _context.SaveChanges();

            return CreatedAtRoute("GetAccount", new { id = item.Id }, item);
        }
        [HttpPut("{id}")]
        public IActionResult Update(long id, Account item)
        {
            var account = _context.Accounts.Find(id);
            if (account == null)
            {
                return NotFound();
            }

            account.Name = item.Name;

            _context.Accounts.Update(account);
            _context.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var account = _context.Accounts.Find(id);
            if (account == null)
            {
                return NotFound();
            }

            _context.Accounts.Remove(account);
            _context.SaveChanges();
            return NoContent();
        }
    }
}