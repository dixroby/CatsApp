using Cats.BusinessObjects.Entities;

namespace Cats.BusinessObjects.Intefaces
{
    public interface ICatsViewModel
    {
        IReadOnlyCollection<Cat> Cats { get; }

        Task GetCatAsync();
    }
}