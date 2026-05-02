using System.ComponentModel.DataAnnotations;

namespace SalonManagementAPI.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Duration { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string ImageUrl { get; set; }  

        public bool IsActive { get; set; }
        
    }
}
