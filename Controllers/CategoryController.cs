using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using API.Models;

namespace API.Controllers {
    [ApiController]
    [Route("v1/categories")]
    
    public class CategoryController : ControllerBase {
        [HttpGet]
        [Route("")]

        public async Task<ActionResult<List<Category>>> Get([FromServices] DataContext context) {
            var categories = await context.Categories.ToListAsync();
            return categories;
        }
    }
}