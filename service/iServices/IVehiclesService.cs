using FinalAssessmentDotNet.model;

namespace FinalAssessmentDotNet.service.iServices
{
    public interface IVehiclesService
    {
        public IEnumerable<Vehicles> GetVehicles();

        public Vehicles AddVehicles(Vehicles vehicle);

        public Vehicles UpdateVehicles(Vehicles vehicle);

        public IEnumerable<Vehicles> GetVehiclesByOwner(int OwnerId);
    }
}
