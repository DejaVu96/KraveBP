using KraveBazaAPI.Data;
using KraveBazaAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KraveBazaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // api/krave
    public class KraveController(DataContext context) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Krava>>> GetKrave()
        {
            var krave = await context.Krave.ToListAsync();

            return krave;
        }
        
        [HttpGet("{id:int}")] // /api/krave/2
        public async Task<ActionResult<Krava>> GetKrava(int id)
        {
            var krava = await context.Krave.FindAsync(id);

            if (krava == null) return NotFound();

            return krava;
        }
    }
}
