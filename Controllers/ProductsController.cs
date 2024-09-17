using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyDotNetAPIProject;
using Microsoft.EntityFrameworkCore;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ShopContext _context;

        public ProductsController (ShopContext context) {
            _context = context;
            _context.Database.EnsureCreated();
        }

        // GET: api/<ProductsController>
        [HttpGet]
        public async Task<ActionResult> GetAllProducts()
        {
            return Ok(await _context.Products.ToArrayAsync());
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetSingleProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if(product == null) {
                return NotFound();
            }

            return Ok(product);
        }

        // POST api/<ProductsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
