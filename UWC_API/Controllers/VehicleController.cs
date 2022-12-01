using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace UWC_API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class VehicleController : Controller
    {
        private readonly DataContext context;

        public VehicleController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Vehicle>>> Get()
        {
            if (await this.context.Vehicle.ToListAsync() == null) return BadRequest("No Vehicle has been added");
            return Ok(await this.context.Vehicle.ToListAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Vehicle>> Get(int id)
        {
            var Vehicle = await this.context.Vehicle.FindAsync(id);
            if (Vehicle == null) return BadRequest("Vehicle not found");
            return Ok(Vehicle);
        }


        [HttpPost]
        public async Task<ActionResult<List<Vehicle>>> Add(Vehicle VehicleS)
        {
            this.context.Vehicle.Add(VehicleS);
            await this.context.SaveChangesAsync();
            return Ok(await this.context.Vehicle.ToListAsync());
        }
        [HttpPut]
        public async Task<ActionResult<List<Vehicle>>> Update(Vehicle request)
        {
            var Vehicledb = await this.context.Vehicle.FindAsync(request.vehicleId);
            if (Vehicledb == null) return BadRequest("not found");

            Vehicledb.vehicleName = request.vehicleName;
            Vehicledb.plateNum= request.plateNum;
            Vehicledb.collectorName = request.collectorName;
            Vehicledb.status = request.status;
            Vehicledb.capacity = request.capacity;

            await this.context.SaveChangesAsync();
            return Ok(await this.context.Vehicle.ToListAsync());
        }
    }
}
