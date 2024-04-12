using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly DBProductosWebApi _context;

        public CategoriaController(DBProductosWebApi context)
        {
            _context = context;
        }
        // GET api/Categoria
        [HttpPost]
        public IActionResult Post(Categoria categoria)
        {
            _context.Add(categoria);
            _context.SaveChanges();
            return Ok();
        }

        // GET api/Categoria
        [HttpGet]
        public IEnumerable<Categoria> Get()
        {
            return _context.Categorias.ToList();
        }

        // GET api/Categoria/id
        [HttpGet("{id}")]
        public ActionResult<Categoria> Get(int id)
        {
            var categoria = _context.Categorias.Find(id);
            if (categoria == null)
            {
                return NotFound();
            }

            return categoria;

        }

        // GET api/Categoria/id
        [HttpPut("{id}")]
        public IActionResult Put(int Id, [FromBody] Categoria categoria)
        {
            if (Id != categoria.Id)
            {
                return BadRequest();
            }

            _context.Entry(categoria).State = EntityState.Modified;

            _context.SaveChanges();

            return Ok();
        }

        // GET api/Categoria/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int Id)
        {
            var categoria = _context.Categorias.First(x => x.Id == Id);
            if (categoria == null)
            {
                return NotFound();
            }

            _context.Remove(categoria);
            _context.SaveChanges();
            return Ok();
        }
    }
}