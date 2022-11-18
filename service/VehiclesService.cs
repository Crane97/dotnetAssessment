using FinalAssessmentDotNet.repos;
using FinalAssessmentDotNet.service.iServices;

namespace FinalAssessmentDotNet.service
{
    public class VehiclesService : IVehiclesService
    {
        RepositoryContext repository;

        public VehiclesService(RepositoryContext repository)
        {
            this.repository = repository;
        }
    }
}
