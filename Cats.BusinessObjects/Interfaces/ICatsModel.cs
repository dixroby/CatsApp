using Cats.BusinessObjects.Entities;

namespace Cats.BusinessObjects.Interfaces
{
    public interface ICatsModel
    {
        Task<IReadOnlyCollection<Cat>> GetCatsAsync();
    }
}