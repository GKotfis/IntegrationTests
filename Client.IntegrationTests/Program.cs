using Client;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

Host.CreateDefaultBuilder().ConfigureWebHostDefaults(builder =>
{
   builder.UseStartup<Startup>();
}).Build().Run();

// #pragma warning disable CA1050 // Declare types in namespaces
public partial class Program { }
// so you can reference it in tests
// #pragma warning restore CA1050 // Declare types in namespaces

public class Startup
{
   public void ConfigureServices(IServiceCollection serviceCollection)
   {
      serviceCollection.AddClient();
   }

   public void Configure(IApplicationBuilder app)
   {
   }
}
