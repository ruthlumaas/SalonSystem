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
                .Where(s => s.IsActive)
                .Select(s => new
                {
                    s.Id,
                    s.Name,
                    s.Price,
                    s.Duration,
                    s.CategoryId,
                    s.ImageUrl,
                    CategoryName = _context.Categories
                        .Where(c => c.Id == s.CategoryId)
                        .Select(c => c.Name)
                        .FirstOrDefault()
                })
                .ToList();

            return Ok(services);
        }

        // ADD SERVICE (ADMIN)
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            service.IsActive = true;

            _context.Services.Add(service);
            _context.SaveChanges();

            return Ok(service);
        }
        // ================= UPDATE SERVICE =================
        [HttpPut("{id}")]
        public IActionResult UpdateService(int id, Service updatedService)
        {
            var service = _context.Services.Find(id);

            if (service == null)
                return NotFound();

            service.Name = updatedService.Name;
            service.Price = updatedService.Price;
            service.Duration = updatedService.Duration;
            service.CategoryId = updatedService.CategoryId;
            service.ImageUrl = updatedService.ImageUrl;

            _context.SaveChanges();

            return Ok(service);
        }
        // ================= DELETE SERVICE =================
        [HttpDelete("{id}")]
        public IActionResult DeleteService(int id)
        {
            var service = _context.Services.Find(id);

            if (service == null)
                return NotFound();

            service.IsActive = false;

            _context.SaveChanges();

            return Ok();
        }
    }
}