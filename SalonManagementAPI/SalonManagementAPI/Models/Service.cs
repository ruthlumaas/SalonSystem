using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SalonManagementAPI.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Duration { get; set; }
        public int CategoryId { get; set; }

        [JsonIgnore]
        public Category? Category { get; set; }
        public string ImageUrl { get; set; }  

        public bool IsActive { get; set; }
        
    }
}
