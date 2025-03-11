using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ToDoBlazor.Services;
using ToDoBlazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<ToDoService>();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5295/") }); // Set yours.

await builder.Build().RunAsync();