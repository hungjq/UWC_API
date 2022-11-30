using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace UWC_API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class MCPController : Controller
    {
        private readonly DataContext context;

        public MCPController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<MCP>>> Get()
        {
            if (await this.context.MCP.ToListAsync() == null) return BadRequest("No MCP has been added");
            return Ok(await this.context.MCP.ToListAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<MCP>> Get(int id)
        {
            var MCP = await this.context.MCP.FindAsync(id);
            if (MCP == null) return BadRequest("MCP not found");
            return Ok(MCP);
        }


        [HttpPost]
        public async Task<ActionResult<List<MCP>>> Add(MCP mcpS)
        {
            this.context.MCP.Add(mcpS);
            await this.context.SaveChangesAsync();
            return Ok(await this.context.MCP.ToListAsync());
        }
        [HttpPut]
        public async Task<ActionResult<List<MCP>>> Update(MCP request)
        {
            var mcpdb = await this.context.MCP.FindAsync(request.mcpId);
            if (mcpdb == null) return BadRequest("not found");

            mcpdb.mcpName = request.mcpName;
            mcpdb.address= request.address;
            mcpdb.collectorName = request.collectorName;
            mcpdb.janitorName= request.janitorName;
            mcpdb.trollerName = request.trollerName;
            mcpdb.status = request.status;
            mcpdb.capacity = request.capacity;

            await this.context.SaveChangesAsync();
            return Ok(await this.context.MCP.ToListAsync());
        }
    }
}
