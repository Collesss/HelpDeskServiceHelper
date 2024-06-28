using HelpDeskServiceHelper.Repository.Entities;

namespace HelpDeskServiceHelper.Repository.Interfaces
{
    public interface IRepository<T> where T: CommonEntity
    {
        Task<IEnumerable<T>> GetAll(CancellationToken cancellationToken = default);
    }
}
