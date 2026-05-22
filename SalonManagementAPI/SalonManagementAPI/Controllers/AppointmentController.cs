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
        // GET ALL APPOINTMENTS
        [HttpGet]
        public IActionResult GetAll()
        {
            var appointments = _context.Appointments.ToList();

            foreach (var item in appointments)
            {
                if (
                    item.Status == "Approved" &&
                    item.AppointmentDate < DateTime.Now
                )
                {
                    item.Status = "Completed";
                }
            }

            _context.SaveChanges(); 
            var data = _context.Appointments
                .Select(x => new
                {
                    x.Id,
                    x.ServiceId,
                    ServiceName = _context.Services
                        .Where(s => s.Id == x.ServiceId)
                        .Select(s => s.Name)
                        .FirstOrDefault(),

                    x.FullName,
                    x.Email,
                    x.ContactNumber,
                    x.AppointmentDate,
                    x.Status,
                    x.Notes,
                    x.CreatedAt
                })
                .ToList();

            return Ok(data);
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
        // DECLINE APPOINTMENT
        [HttpPut("decline/{id}")]
        public IActionResult DeclineAppointment(int id)
        {
            var appointment = _context.Appointments
                .FirstOrDefault(x => x.Id == id);

            if (appointment == null)
                return NotFound("Appointment not found");

            // ONLY PENDING CAN BE DECLINED
            if (appointment.Status != "Pending")
                return BadRequest("Only pending appointments can be declined");

            appointment.Status = "Declined";

            _context.SaveChanges();

            return Ok("Appointment declined successfully");
        }
        // APPROVE APPOINTMENT
        [HttpPut("approve/{id}")]
        public IActionResult ApproveAppointment(int id)
        {
            var appointment = _context.Appointments
                .FirstOrDefault(x => x.Id == id);

            if (appointment == null)
                return NotFound("Appointment not found");

            // ONLY PENDING CAN BE APPROVED
            if (appointment.Status != "Pending")
                return BadRequest("Only pending appointments can be approved");

            appointment.Status = "Approved";

            _context.SaveChanges();

            return Ok("Appointment approved successfully");
        }
        [HttpGet("date/{date}")]
        public IActionResult GetByDate(DateTime date)
        {
            var appointments =
                _context.Appointments
                .Where(x =>
                    x.AppointmentDate.Date == date.Date
                    &&
                    x.Status != "Declined"
                )
                .Select(x => x.AppointmentDate)
                .ToList();

            return Ok(appointments);
        }
        [HttpGet("search/{search}")]
        public IActionResult SearchAppointment(string search)
        {
            var appointments =
                _context.Appointments
                .Where(x =>
                    x.FullName.Contains(search)
                    ||
                    x.Id.ToString().Contains(search))
                .Select(x => new
                {
                    x.Id,
                    x.ServiceId,

                    ServiceName =
                        _context.Services
                        .Where(s => s.Id == x.ServiceId)
                        .Select(s => s.Name)
                        .FirstOrDefault(),

                    x.FullName,
                    x.Email,
                    x.ContactNumber,
                    x.AppointmentDate,
                    x.Status,
                    x.Notes,
                    x.CreatedAt
                })
                .ToList();

            return Ok(appointments);
        }
    }
}