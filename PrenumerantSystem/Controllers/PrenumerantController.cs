using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class PrenumerantController : ControllerBase
{
    private readonly PrenumerantContext _db;

    public PrenumerantController(PrenumerantContext db)
    {
        _db = db;
    }

    [HttpGet("personnummer/{personnummer}")]
    public async Task<IActionResult> GetByPersonnummer(string personnummer)
    {
        var p = await _db.Prenumeranter
            .FirstOrDefaultAsync(x => x.Personnummer == personnummer);
        if (p is null) return NotFound();
        return Ok(p);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var p = await _db.Prenumeranter.FindAsync(id);
        if (p is null) return NotFound();
        return Ok(p);
    }

    [HttpPost]
    public async Task<IActionResult> Create(Prenumerant prenumerant)
    {
        _db.Prenumeranter.Add(prenumerant);
        await _db.SaveChangesAsync();
        return CreatedAtAction(nameof(GetById), new { id = prenumerant.Id }, prenumerant);
    }

    [HttpGet("nummer/{nummer}")]
    public async Task<IActionResult> GetByPrenumerantnummer(int nummer)
    {
        var p = await _db.Prenumeranter
            .FirstOrDefaultAsync(x => x.Prenumerantnummer == nummer);
        if (p is null) return NotFound();
        return Ok(p);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var prenumeranter = await _db.Prenumeranter.ToListAsync();
        return Ok(prenumeranter);
    }
}