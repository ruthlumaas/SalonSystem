using Microsoft.AspNetCore.Mvc;
using SalonManagementAPI.Data;
using SalonManagementAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace SalonManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly AppDBContext _context;

        public ServiceController(AppDBContext context)
        {
            _context = context;
        }

        // GET ALL SERVICES
        [HttpGet]
        public IActionResult GetServices()
        {
            var services = _context.Services
                .Include(s => s.Category)
                .Where(s => s.IsActive == true) 
                .Select(s => new
                {
                    s.Id,
                    s.Name,
                    s.Price,
                    s.CategoryId,
                    s.ImageUrl,
                    CategoryName = s.Category.Name
                })
                .ToList();

            return Ok(services);
        }

        // ADD SERVICE (ADMIN)
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            _context.Services.Add(service);
            _context.SaveChanges();

            return Ok(service);
        }
    }
}