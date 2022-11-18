using FinalAssessmentDotNet.model;

namespace FinalAssessmentDotNet.service.iServices
{
    public interface IVehiclesService
    {
        public IEnumerable<Vehicles> GetVehicles();

        public Vehicles AddVehicles(Vehicles vehicle);
    }
}
