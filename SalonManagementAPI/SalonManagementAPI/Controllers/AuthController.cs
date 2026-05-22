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
<<<<<<< HEAD
            var email = user.Username.Trim().ToLower();
            var password = user.Password.Trim();

            var u = _context.Customers
                .FirstOrDefault(x =>
                    x.Email.ToLower() == email &&
                    x.Password == password);
=======
            var u = _context.Customers
                .FirstOrDefault(x =>
                    x.Email == user.Username &&
                    x.Password == user.Password);
>>>>>>> a3fa605c8d64d997bf0b13e434913200c5047611

            if (u == null)
                return Unauthorized("Invalid email or password");

            return Ok(new
            {
                id = u.Id,
                fullName = u.FullName,
                email = u.Email,
                token = "sample-token"
            });
        }
        [HttpPost("admin-login")]
        public IActionResult AdminLogin(User user)
        {
            var username = user.Username.Trim();
            var password = user.Password.Trim();

            var admin = _context.Users
                .FirstOrDefault(x =>
                    x.Username == username &&
                    x.Password == password);

            if (admin == null)
                return Unauthorized("Invalid admin credentials");

            return Ok(admin);
        }
        [HttpPut("change-password")]
        public IActionResult ChangePassword(ChangePassword model)
        {
            var user = _context.Customers
                .FirstOrDefault(x => x.Email == model.Email);

            if (user == null)
                return NotFound("User not found");

            if (user.Password != model.OldPassword)
                return BadRequest("Current password is incorrect");

            user.Password = model.NewPassword;
            
            _context.SaveChanges();

            return Ok("Password updated successfully");
        }
    }
}