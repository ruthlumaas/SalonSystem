using System.Text.Json.Serialization;

namespace SalonManagementAPI.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        [JsonIgnore]
        public ICollection<Service> Services { get; set; }
    }
}
