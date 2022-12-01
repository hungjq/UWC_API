using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace UWC_API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class JanitorController : Controller
    {

        private readonly DataContext context;

        public JanitorController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Janitor>>> Get()
        {
            if (await this.context.Janitor.ToListAsync() == null) return BadRequest("No Janitor has been added");
            return Ok(await this.context.Janitor.ToListAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Janitor>> Get(int id)
        {
            var Janitor = await this.context.Janitor.FindAsync(id);
            if (Janitor == null) return BadRequest("Janitor not found");
            return Ok(Janitor);
        }


        [HttpPost]
        public async Task<ActionResult<List<Janitor>>> Add(Janitor JanitorS)
        {
            this.context.Janitor.Add(JanitorS);
            await this.context.SaveChangesAsync();
            return Ok(await this.context.Janitor.ToListAsync());
        }
        [HttpPut]
        public async Task<ActionResult<List<Janitor>>> Update(Janitor request)
        {
            var Janitordb = await this.context.Janitor.FindAsync(request.id);
            if (Janitordb == null) return BadRequest("not found");

           Janitordb.id = request.id;
            Janitordb.name = request.name;  
            Janitordb.mcpName = request.mcpName;
            Janitordb.status = request.status;
            Janitordb.vehicleName = request.vehicleName;
            
            await this.context.SaveChangesAsync();
            return Ok(await this.context.Janitor.ToListAsync());
        }
    }
}
