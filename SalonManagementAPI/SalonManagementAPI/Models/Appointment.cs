using System.ComponentModel.DataAnnotations;

namespace SalonManagementAPI.Models
{
    public class Appointment
    {
            public int Id { get; set; }

            public int ServiceId { get; set; }

            public string FullName { get; set; }

            public string Email { get; set; } 

            public string ContactNumber { get; set; }

            public DateTime AppointmentDate { get; set; }

            public string Status { get; set; }

            public string Notes { get; set; }

            public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
