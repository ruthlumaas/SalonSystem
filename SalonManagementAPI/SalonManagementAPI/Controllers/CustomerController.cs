using Microsoft.AspNetCore.Mvc;
using SalonManagementAPI.Data;
using SalonManagementAPI.Models;
using System.Linq;

namespace SalonManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly AppDBContext _context;

        public CustomerController(AppDBContext context)
        {
            _context = context;
        }

        // ================= GET =================
        [HttpGet]
        public IActionResult GetCustomers()
        {
            var customers = _context.Customers
                 .Select(c => new
                 {
                     c.Id,
                     c.FullName,
                     c.Email
                 }).ToList();

            return Ok(customers);
        }

        // ================= ADD =================
        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();

            return Ok(customer);
        }

        // ================= UPDATE =================
        [HttpPut("{id}")]
        public IActionResult UpdateCustomer(int id, Customer updatedCustomer)
        {
            var customer = _context.Customers.Find(id);

            if (customer == null)
                return NotFound("Customer not found");

            customer.FullName = updatedCustomer.FullName;
            customer.Email = updatedCustomer.Email;
            customer.Password = updatedCustomer.Password;

            _context.SaveChanges();

            return Ok(customer);
        }

        // ================= DELETE =================
        [HttpDelete("{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            var customer = _context.Customers.Find(id);

            if (customer == null)
                return NotFound("Customer not found");

            _context.Customers.Remove(customer);

            _context.SaveChanges();

            return Ok("Deleted Successfully");
        }
    }
}