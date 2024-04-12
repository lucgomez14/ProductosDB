using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly DBProductosWebApi _context;

        public ProductoController(DBProductosWebApi context)
        {
            _context = context;
        }
        // GET api/Producto
        [HttpPost]
        public IActionResult Post(Producto producto)
        {
            _context.Add(producto);
            _context.SaveChanges();
            return Ok();
        }

        // GET api/Producto
        [HttpGet]
        public IEnumerable<Producto> Get()
        {
            return _context.Productos.ToList();
        }

        // GET api/Producto/id
        [HttpGet("{id}")]
        public ActionResult<Producto> Get(int id)
        {
            var producto = _context.Productos.Find(id);
            if (producto == null)
            {
                return NotFound();
            }

            return producto;

        }

        // GET api/Producto/id
        [HttpPut("{id}")]
        public IActionResult Put(int Id, [FromBody] Producto producto)
        {
            if (Id != producto.Id)
            {
                return BadRequest();
            }

            _context.Entry(producto).State = EntityState.Modified;

            _context.SaveChanges();

            return Ok();
        }

        // GET api/Producto/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int Id)
        {
            var producto = _context.Productos.First(x => x.Id == Id);
            if (producto == null)
            {
                return NotFound();
            }

            _context.Remove(producto);
            _context.SaveChanges();
            return Ok();
        }
    }
}