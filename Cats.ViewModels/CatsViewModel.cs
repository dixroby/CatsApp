namespace Cats.ViewModels
{
    public class CatsViewModel : ICatsViewModel
    {
        readonly ICatsModel Model;
        public IReadOnlyCollection<Cat> Cats { get; private set; }

        public CatsViewModel(ICatsModel model)
        {
            Model = model;
        }

        public async Task GetCatAsync()
        {
            Cats = await Model.GetCatsAsync();
        }
    }
}