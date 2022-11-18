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
    }
}
