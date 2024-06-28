using HelpDeskServiceHelper.Repository.Entities;
using HelpDeskServiceHelper.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HelpDeskServiceHelper.Repository.Db.Implementations
{
    public abstract class Repository<T> : IRepository<T> where T : CommonEntity
    {
        private readonly RepositoryDbContext _repositoryDbContext;

        public Repository(RepositoryDbContext repositoryDbContext) 
        {
            _repositoryDbContext = repositoryDbContext ?? throw new ArgumentNullException(nameof(repositoryDbContext));
        }

        public async Task<IEnumerable<T>> GetAll(CancellationToken cancellationToken = default) =>
            await _repositoryDbContext.Set<T>().ToListAsync(cancellationToken);
    }
}
