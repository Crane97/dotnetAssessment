using FinalAssessmentDotNet.model;
using FinalAssessmentDotNet.service.iServices;
using Microsoft.AspNetCore.Mvc;

namespace FinalAssessmentDotNet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClaimsController : ControllerBase
    {
        public readonly IClaimsService claimService;

        public ClaimsController(IClaimsService claimService)
        {
            this.claimService = claimService;
        }

        [HttpGet(Name = "/claims/all")]
        public IEnumerable<Claims> Get()
        {
            return claimService.GetClaims();
        }
        
        [HttpPost(Name = "/addClaim")]
        public Claims PostClaim(Claims claims)
        {
            return claimService.AddClaim(claims);
        }

        [HttpPut(Name = "/updateClaim")]
        public Claims PutClaim(Claims claims)
        {
            return claimService.UpdateClaims(claims);
        }

        [HttpGet("/claimByVehicle/{id:int}")]
        public IEnumerable<Claims> GetClaimsByVehicleId(int id)
        {
            return claimService.getClaimsByVehicleId(id);
        }

    }
}