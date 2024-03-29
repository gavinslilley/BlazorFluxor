using System;
using System.Net.Http;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Fluxor;
using System.Reflection;
using BlazorFluxor.Web.Services;
using Microsoft.AspNetCore.Components.Web;
using BlazorFluxor.Web;
using BlazorFluxor.Web.Store;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddFluxor(options =>
{
    options.ScanAssemblies(typeof(BarFeature).Assembly);
    options.ScanAssemblies(typeof(FooFeature).Assembly);
    options.UseReduxDevTools();
});

builder.Services.AddScoped<StateFacade>();

await builder.Build().RunAsync();
