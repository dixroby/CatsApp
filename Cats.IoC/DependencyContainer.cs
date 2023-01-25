namespace Cats.IoC;
public static class DependencyContainer
{
    public static IServiceCollection AddCoreServices(this IServiceCollection services, CatsEndpoints endpoints)
    {
        services.AddHttpClient<ICatsModel, CatsModel>(HttpClient => new CatsModel(HttpClient, endpoints));
        services.AddScoped<ICatsViewModel, CatsViewModel>();
        return services;
    }

    public static IServiceCollection AddConsoleServices(this IServiceCollection services, CatsEndpoints endpoints)
    {
        services.AddCoreServices(endpoints);
        services.AddScoped<ICatsView, CatsView>();

        return services;
    }
}