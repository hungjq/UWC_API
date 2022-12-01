using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace UWC_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollectorController : ControllerBase
    {
        private readonly DataContext context;

        public CollectorController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Collector>>> Get()
        {
            if (await this.context.Collector.ToListAsync() == null) return BadRequest("No Collector has been added");
            return Ok(await this.context.Collector.ToListAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Collector>> Get(int id)
        {
            var collector = await this.context.Collector.FindAsync(id);
            if (collector == null) return BadRequest("Collector not found");
            return Ok(collector);
        }


        [HttpPost]
        public async Task<ActionResult<List<Collector>>> Add(Collector col)
        {
            this.context.Collector.Add(col);
            await this.context.SaveChangesAsync();
            return Ok(await this.context.Collector.ToListAsync());
        }
        [HttpPut]
        public async Task<ActionResult<List<Collector>>> Update(Collector request)
        {
            var coldb = await this.context.Collector.FindAsync(request.id);
            if (coldb == null) return BadRequest("not found");

            coldb.name = request.name;
            coldb.vehicleName = request.vehicleName;
            coldb.status= request.status;
            coldb.id = request.id;

            await this.context.SaveChangesAsync();
            return Ok(await this.context.Collector.ToListAsync());
        }


    }
}
