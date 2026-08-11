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
           var users=_context.Users.ToList();
            return Ok(users);
        }
     
    }
}
