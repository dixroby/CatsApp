using Cats.BusinessObjects.Interfaces;
using Cats.BusinessObjects.ValueObjects;
using Cats.IoC;
using Microsoft.Extensions.Configuration;
using SimpleDI;

DIHost Host = DIHost.CreateDefaultHost();
var URL = Host.Configuration.GetSection("CatsEndpoints").Get<CatsEndpoints>();

Host.Services.AddConsoleServices(
    URL
    );
Host.Build();

ICatsView view = Host.GetRequiredService<ICatsView>();
await view.RenderCatsAsync();