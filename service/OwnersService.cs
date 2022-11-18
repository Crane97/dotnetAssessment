using FinalAssessmentDotNet.repos;
using FinalAssessmentDotNet.service.iServices;

namespace FinalAssessmentDotNet.service
{
    public class OwnersService : IOwnersService
    {
        RepositoryContext repository;

        public OwnersService(RepositoryContext repository)
        {
            this.repository = repository;
        }
    }
}
