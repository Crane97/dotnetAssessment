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

        public Vehicles UpdateVehicles(Vehicles vehicle)
        {
            repository.Vehicles.Update(vehicle);
            repository.SaveChanges();
            return vehicle;
        }

        public IEnumerable<Vehicles> GetVehiclesByOwner(int OwnerId)
        {
            List<Vehicles> allVehicles = repository.Vehicles.ToList();
            List<Vehicles> result = new List<Vehicles>();

            foreach (var vehicle in allVehicles)
            {
                if(vehicle.Owner_Id == OwnerId)
                {
                    result.Add(vehicle);
                }
            }

            return result;
        }
    }
}
