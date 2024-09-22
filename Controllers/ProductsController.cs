using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyDotNetAPIProject;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

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
        public async Task<ActionResult<Product>> CreateProduct([FromBody] Product product)
        {
            if(!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            // an ActionResult provided by .NET similar to Ok and NotFound
            return CreatedAtAction(
                "GetSingleProduct", //get single product route
                new {id = product.Id}, //params for get single product route
                product // the object needs to be return in response
            );
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Product product)
        {
            if( id != product.Id) {
                return BadRequest();
            }

            _context.Entry(product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if(!_context.Products.Any(product => product.Id == id)) {
                    return NotFound();
                }
                else {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Product>> Delete(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if(product == null) {
                return NotFound();
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return product; 
        }
    }
}
