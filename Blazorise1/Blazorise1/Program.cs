using Blazorise;
using Blazorise.Bulma;
using Blazorise.Icons.FontAwesome;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace Blazorise1
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            AddBlazorise(builder.Services);

            await builder.Build().RunAsync();
        }

        public static void AddBlazorise(IServiceCollection services)
        {
            services
                .AddBlazorise();
            services
                .AddBulmaProviders()
                .AddFontAwesomeIcons();
        }
    }
}