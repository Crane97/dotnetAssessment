using FinalAssessmentDotNet.model;
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

        public IEnumerable<Vehicles> GetVehicles()
        {
            return repository.Vehicles.ToList();
        }

        public Vehicles AddVehicles(Vehicles vehicle)
        {
            repository.Vehicles.Add(vehicle);
            repository.SaveChanges();
            return vehicle;
        }
    }
}
