using HelpDeskServiceHelper.Repository.Entities;
using HelpDeskServiceHelper.Repository.Interfaces;

namespace HelpDeskServiceHelper.Repository.Db.Implementations
{
    public class ManufacturerRepository : Repository<ManufacturerEntity>, IManufacturerRepository
    {
        public ManufacturerRepository(RepositoryDbContext repositoryDbContext) : base(repositoryDbContext)
        {
        }
    }
}
