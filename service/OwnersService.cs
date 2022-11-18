using FinalAssessmentDotNet.model;
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

        public IEnumerable<Owners> GetOwners()
        {
            return repository.Owners.ToList();
        }

        public Owners AddOwner(Owners owners)
        {
            repository.Owners.Add(owners);
            repository.SaveChanges();
            return owners;
        }

    }
}
