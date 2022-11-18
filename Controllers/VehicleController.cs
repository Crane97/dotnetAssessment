using FinalAssessmentDotNet.model;
using FinalAssessmentDotNet.service.iServices;
using Microsoft.AspNetCore.Mvc;

namespace FinalAssessmentDotNet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehicleController : ControllerBase
    {
        private readonly IVehiclesService vehiclesService;

        public VehicleController(IVehiclesService vehiclesService)
        {
            this.vehiclesService = vehiclesService;
        }

        [HttpGet(Name = "/vehicles/all")]
        public IEnumerable<Vehicles> Get()
        {
            return vehiclesService.GetVehicles();
        }


        [HttpPost(Name = "/addVehicles")]
        public Vehicles Post(Vehicles vehicle)
        {
            return vehiclesService.AddVehicles(vehicle);
        }

        [HttpPut(Name = "/updateVehicles")]
        public Vehicles Put(Vehicles vehicle)
        {
            return vehicle;
        }


    }
}