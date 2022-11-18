using FinalAssessmentDotNet.model;
using FinalAssessmentDotNet.service.iServices;
using Microsoft.AspNetCore.Mvc;

namespace FinalAssessmentDotNet.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class OwnerController : ControllerBase
    {
        public readonly IOwnersService ownerService;

        public OwnerController(IOwnersService ownersService)
        {
            this.ownerService = ownersService;
        }

        [HttpGet(Name = "/owners/all")]
        public IEnumerable<Owners> Get()
        {
           return ownerService.GetOwners();
        }

        [HttpPost(Name = "/addOwner")]
        public Owners PostOwner(Owners owner)
        {
            return ownerService.AddOwner(owner);
        }

        [HttpPut(Name = "/updateOwner")]
        public Owners PutOwner(Owners owner)
        {
            return ownerService.UpdateOwner(owner);
        }
    }
}