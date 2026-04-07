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
}