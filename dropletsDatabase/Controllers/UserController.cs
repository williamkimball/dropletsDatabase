using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using dropletsDatabase.Models;

namespace dropletsDatabase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserContext _context;

        public UserController(UserContext context)
        {
            _context = context;

            if (_context.Users.Count() == 0)
            {
                // Create a new User if collection is empty,
                // which means you can't delete all User.
                _context.Users.Add(new User { Name = "William" });
                _context.SaveChanges();
            }
        }

            [HttpGet]
        public ActionResult<List<User>> GetAll()
        {
            return _context.Users.ToList();
        }

        [HttpGet("{id}", Name = "GetUser")]
        public ActionResult<User> GetById(long id)
        {
            var item = _context.Users.Find(id);
            return item == null ? (ActionResult<User>)NotFound() : (ActionResult<User>)item;
        }
        [HttpPost]
        public IActionResult Create(User item)
        {
            _context.Users.Add(item);
            _context.SaveChanges();

            return CreatedAtRoute("GetUser", new { id = item.Id }, item);
        }
        [HttpPut("{id}")]
        public IActionResult Update(long id, User item)
        {
            var user = _context.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }

            user.Name = item.Name;

            _context.Users.Update(user);
            _context.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            _context.SaveChanges();
            return NoContent();
        }
    }
    }