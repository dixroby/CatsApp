using Cats.BusinessObjects.Entities;

namespace Cats.BusinessObjects.Intefaces
{
    public interface ICatsModel
    {
        Task<IReadOnlyCollection<Cat>> GetCatsAsync();
    }
}