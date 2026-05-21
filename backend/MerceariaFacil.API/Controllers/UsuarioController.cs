using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class UsuarioController : ControllerBase
{
    private readonly MerceariaContext _context;

    public UsuarioController(MerceariaContext context)
    {
        _context = context;
    }

    // GET api/usuario
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var usuarios = await _context.Usuarios.ToListAsync();
        return Ok(usuarios);
    }

    [HttpPost]
    public async Task<IActionResult> Post(Usuario usuario)
    {
        _context.Usuarios.Add(usuario);
        await _context.SaveChangesAsync();
        return Ok(usuario);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var usuario = await _context.Usuarios.FindAsync(id);

        if (usuario == null)
        {
            return NotFound();
        }

         _context.Usuarios.Remove(usuario);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Usuario usuario)
    {
        var usuarioBanco = await _context.Usuarios.FindAsync(id);

        if (usuarioBanco == null)
        {
            return NotFound();
        }

        usuarioBanco.Name = usuario.Name;
        usuarioBanco.Email = usuario.Email;
        usuarioBanco.Senha = usuario.Senha;

        await _context.SaveChangesAsync();

        return NoContent();
    }

    [HttpPatch("{id}")]
    public async Task<IActionResult> Patch(int id, Usuario usuario)
    {
        var usuarioBanco = await _context.Usuarios.FindAsync(id);

        if (usuarioBanco == null)
        {
            return NotFound();
        }

        if (!string.IsNullOrEmpty(usuario.Name))
        {
            usuarioBanco.Name = usuario.Name;
        }
        if (!string.IsNullOrEmpty(usuario.Email))
        {
            usuarioBanco.Email = usuario.Email;
        }
        if (!string.IsNullOrEmpty(usuario.Senha))
        {
            usuarioBanco.Senha = usuario.Senha;
        }

        await _context.SaveChangesAsync();

        return NoContent();
    }
}