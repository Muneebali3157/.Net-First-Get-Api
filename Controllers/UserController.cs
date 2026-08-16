using First_crud_operation.Models;
using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace First_crud_operation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet("Getall")]
        public IActionResult GetAllUsers()
        {
            var users = _context.Users.ToList();
            return Ok(users);
        }
        [HttpGet("{id}/Getbyid")]
        public IActionResult GetUserById(int id)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost("Add")]
        public IActionResult Adduser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return Ok();

        }
        [HttpPut("{id}/Update")]
        public IActionResult Updateuser(int id, User user)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var existing = _context.Users.Find(id);
            if (existing == null)
            {
                return NotFound();
            }
            existing.Name = user.Name;
            existing.Email = user.Email;
            existing.Password = user.Password;
            _context.SaveChanges();
            return Ok();
        }
        [HttpDelete("{id}/Delete")]
        public IActionResult Delete(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            _context.Users.Remove(user);
            _context.SaveChanges();
            return Ok("User Deeleted Successfully");

        }
    }
}
