using Microsoft.AspNetCore.Mvc;
using SalonManagementAPI.Data;
using SalonManagementAPI.Models;
using System;
using System.Linq;

namespace SalonManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AppDBContext _context;

        public AuthController(AppDBContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public IActionResult Register(Customer customer)
        {
            customer.Email = customer.Email.Trim().ToLower();
            customer.Password = customer.Password.Trim();
            customer.FullName = customer.FullName.Trim();

            if (_context.Customers.Any(x => x.Email == customer.Email))
                return BadRequest("Email already exists");

            _context.Customers.Add(customer);
            _context.SaveChanges();

            return Ok(customer);
        }


        [HttpPost("login")]
        public IActionResult Login(User user)
        {
            var u = _context.Users
                .FirstOrDefault(x => x.Username == user.Username && x.Password == user.Password);

            if (u == null)
                return Unauthorized("Invalid username or password");

            return Ok(u);
        }
    }
}