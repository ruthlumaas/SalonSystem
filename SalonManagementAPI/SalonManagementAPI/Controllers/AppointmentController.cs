using Microsoft.AspNetCore.Mvc;
using SalonManagementAPI.Data;
using SalonManagementAPI.Models;
using System;
using System.Linq;

namespace SalonManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly AppDBContext _context;

        public AppointmentController(AppDBContext context)
        {
            _context = context;
        }

        // BOOK APPOINTMENT
        [HttpPost]
        public IActionResult Book([FromBody] Appointment appointment)
        {
            if (appointment == null)
                return BadRequest("No data received");

            if (appointment.ServiceId == 0)
                return BadRequest("ServiceId missing");

            appointment.Status = "Pending";
            appointment.CreatedAt = DateTime.Now;

            _context.Appointments.Add(appointment);
            _context.SaveChanges();

            return Ok(appointment);
        }

        // GET ALL APPOINTMENTS (ADMIN)
        [HttpGet("name/{name}")]
        public IActionResult GetByName(string name)
        {
            var data = _context.Appointments
                .Where(x => x.FullName.Contains(name))
                .ToList();

            return Ok(data);
        }
    }
}