using System.Data.Common; 
using backendnet.Data;
using backendnet.Models; 
using Microsoft.AspNetCore.Mvc; 
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace backendnet.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize(Roles = "Administrador")]

public class CategoriasController(IdentityContext context): Controller
{
    // GET: api/categorias
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Categoria>>> GetCategorias()
    {
        return await context.Categoria.AsNoTracking().ToListAsync();
    }

    // GET: api/categorias/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Categoria>> GetCategoria(int id)
    {
        var categoria = await context.Categoria.FindAsync(id);
        if (categoria == null) return NotFound();
        
        return categoria;
    }

    // POST: api/Categorias
    [HttpPost]
    public async Task<ActionResult<Categoria>> PostCategoria(CategoriaDTO categoriaDTO)
    {
        Categoria categoria = new()
        {
            Nombre = categoriaDTO.Nombre
        };

        context.Categoria.Add(categoria);
        await context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetCategoria), new { id = categoria.CategoriaId }, categoria);
    }

    // PUT: api/Categorias/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutCategoria(int id, CategoriaDTO categoriaDTO)
    {
        if (id != categoriaDTO.CategoriaId) return BadRequest();

        var categoria = await context.Categoria.FindAsync(id);
        if (categoria == null) return NotFound();

        categoria.Nombre = categoriaDTO.Nombre; 
        await context.SaveChangesAsync(); 
        return NoContent();
    }

    // DELETE: api/Categorias/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCategoria(int id)
    {
        var categoria = await context.Categoria
            .Include(c => c.Peliculas) // Cargar las películas asociadas
            .FirstOrDefaultAsync(c => c.CategoriaId == id);

        if (categoria == null) return NotFound();

        if (categoria.Protegida)
        {
            return BadRequest("Esta categoría está protegida y no se puede eliminar.");
        }

        // 🔥 Eliminar las relaciones en la tabla intermedia
        categoria.Peliculas.Clear();
        await context.SaveChangesAsync();

        // Ahora eliminar la categoría
        context.Categoria.Remove(categoria);
        await context.SaveChangesAsync();

        return NoContent();
    }
}