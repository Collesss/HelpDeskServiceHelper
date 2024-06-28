using HelpDeskServiceHelper.Repository.Entities;
using HelpDeskServiceHelper.Repository.Interfaces;

namespace HelpDeskServiceHelper.Repository.Db.Implementations
{
    public class ModelRepository : Repository<ModelEntity>, IModelRepository
    {
        public ModelRepository(RepositoryDbContext repositoryDbContext) : base(repositoryDbContext)
        {
        }
    }
}
