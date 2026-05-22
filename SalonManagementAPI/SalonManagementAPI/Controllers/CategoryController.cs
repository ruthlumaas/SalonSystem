using Microsoft.AspNetCore.Mvc;
using SalonManagementAPI.Data;
using SalonManagementAPI.Models;

namespace SalonManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly AppDBContext _context;

        public CategoryController(AppDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Categories.ToList());
        }

        [HttpPost]
        public IActionResult Add(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();

            return Ok(category);
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, Category category)
        {
            var existing =
                _context.Categories.FirstOrDefault(x => x.Id == id);

            if (existing == null)
                return NotFound("Category not found");

            existing.Name = category.Name;
            existing.ImageUrl = category.ImageUrl;

            _context.SaveChanges();

            return Ok(existing);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var category =
                _context.Categories.FirstOrDefault(x => x.Id == id);

            if (category == null)
                return NotFound("Category not found");

            _context.Categories.Remove(category);

            _context.SaveChanges();

            return Ok("Category deleted");
        }
    }
}
