using Microsoft.AspNetCore.Mvc;
using PayrollManagementAPI.Data;
using PayrollManagementAPI.Models;
using System.Linq;

namespace PayrollManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AuthController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("Login")]
        public IActionResult Login(LoginDTO login)
        {
            var user = _context.Users
                .FirstOrDefault(u => u.User_ID == login.User_ID
                                  && u.Password == login.Password);

            if (user == null)
            {
                return Unauthorized("Invalid Credentials");
            }

            return Ok(new
            {
                message = "Login Successful",
                userId = user.User_ID
            });
        }
    }
}