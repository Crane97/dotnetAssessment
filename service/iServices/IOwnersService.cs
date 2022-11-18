using FinalAssessmentDotNet.model;

namespace FinalAssessmentDotNet.service.iServices
{
    public interface IOwnersService
    {
        public IEnumerable<Owners> GetOwners();

        public Owners AddOwner(Owners owners);

        public Owners UpdateOwner(Owners owners);
    }
}
