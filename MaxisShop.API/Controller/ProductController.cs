using MaxisShop.API.Data;
using MaxisShop.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace MaxisShop.API.Controllers
{   

    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbcontext _context;

        public ProductController(ApplicationDbcontext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<ActionResult<Products>> create ([FromBody] Products products)
        {
            await _context.Products.AddAsync(products);
            await _context.SaveChangesAsync();
            return Ok();

        }
    }
}