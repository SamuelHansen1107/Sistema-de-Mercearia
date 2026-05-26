using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]

public class ProdutoController : ControllerBase
{
    private readonly MerceariaContext _context;

    public ProdutoController(MerceariaContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var produtos = await _context.Produtos.ToListAsync();
        return Ok(produtos);
    }

    [HttpPost]
    public async Task<IActionResult> Post(Produto produto)
    {
        _context.Produtos.Add(produto);
        await _context.SaveChangesAsync();
        return Ok(produto);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var produto = await _context.Produtos.FindAsync(id);

        if (produto == null)
        {
            return NotFound();
        }

         _context.Produtos.Remove(produto);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Produto produto)
    {
        Console.WriteLine(id);
        var produtoBanco = await _context.Produtos.FindAsync(id);

        if (produtoBanco == null)
        {
            return NotFound();
        }

        produtoBanco.Nome = produto.Nome;
        produtoBanco.Preco = produto.Preco;
        produtoBanco.Quantidade = produto.Quantidade;

        await _context.SaveChangesAsync();

        return NoContent();
    }

    [HttpPatch("{id}")]
    public async Task<IActionResult> Patch(int id, Produto produto)
    {
        var produtoBanco = await _context.Produtos.FindAsync(id);

        if (produtoBanco == null)
        {
            return NotFound();
        }

        if (!string.IsNullOrEmpty(produto.Nome))
        {
            produtoBanco.Nome = produto.Nome;
        }

        if (produto.Preco.HasValue)
        {
            produtoBanco.Preco = produto.Preco;
        }

        if (produto.Quantidade.HasValue)
        {
            produtoBanco.Quantidade = produto.Quantidade;
        }

        await _context.SaveChangesAsync();

        return NoContent();
    }
}