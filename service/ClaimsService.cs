using FinalAssessmentDotNet.model;
using FinalAssessmentDotNet.repos;
using FinalAssessmentDotNet.service.iServices;

namespace FinalAssessmentDotNet.service
{
    public class ClaimsService : IClaimsService
    {
        RepositoryContext repository;

        public ClaimsService(RepositoryContext repository)
        {
            this.repository = repository;
        }

        public IEnumerable<Claims> GetClaims()
        {
            return repository.Claims.ToList();
        }

        public Claims AddClaim(Claims claim)
        {
            repository.Add(claim);
            repository.SaveChanges();
            return claim;
        }

        public Claims UpdateClaims(Claims claim)
        {
            repository.Claims.Update(claim);
            repository.SaveChanges();
            return claim;
        }

        public IEnumerable<Claims> getClaimsByVehicleId(int id)
        {
            List<Claims> allClaims = repository.Claims.ToList();
            List<Claims> result = new List<Claims>();

            foreach (var claim in allClaims)
            {
                if (claim.Vehicle_Id == id)
                {
                    result.Add(claim);
                }
            }

            return result;
        }
    }
}
