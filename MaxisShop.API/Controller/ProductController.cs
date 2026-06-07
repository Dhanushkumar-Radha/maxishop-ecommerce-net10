using MaxisShop.API.Data;
using MaxisShop.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MaxisShop.API.Controllers
{   

    [Route("api/Products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbcontext _context;

        public ProductController(ApplicationDbcontext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<ActionResult<Products>> Create([FromBody] Products products)
        {
            await _context.Products.AddAsync(products);
            await _context.SaveChangesAsync();
            return Ok(products);

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Products>> Get(int id)
        {
            var products = await _context.Products.FindAsync(id);
            if (products == null)
            {
                return NotFound();
            }
            return Ok(products);
        }
        [HttpGet]
        public async Task<ActionResult<List<Products>>> GetAll()
        {
            var products = await _context.Products.ToListAsync();
            return Ok(products);
        }
    }
}
