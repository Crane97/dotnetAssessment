using FinalAssessmentDotNet.model;

namespace FinalAssessmentDotNet.service.iServices
{
    public interface IClaimsService
    {

        public IEnumerable<Claims> GetClaims();

        public Claims AddClaim(Claims claim);
        public Claims UpdateClaims(Claims claim);

    }
}
