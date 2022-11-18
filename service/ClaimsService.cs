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
    }
}
