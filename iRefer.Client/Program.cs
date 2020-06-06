using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.Extensions.DependencyInjection;
using iRefer.Shared.Services;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Blazor.FileReader;
using Radzen;
using Radzen.Blazor;

namespace iRefer.Client
{
    public class Program
    {
       private const string URL = "https://localhost:44344";
      // private const string URL = "https://plannerappserver20200228091432.azurewebsites.net";

        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.Services.AddScoped<AuthenticationService>(s =>
            {
                return new AuthenticationService(URL);
            });
            builder.Services.AddScoped<AgencyService>(s =>
            {
                return new AgencyService(URL);
            });
            builder.Services.AddScoped<AgencyRolesService>(s =>
            {
                return new AgencyRolesService(URL);
            });

            builder.Services.AddFileReaderService(options =>
            {
                options.UseWasmSharedBuffer = true;
            }); 

            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddOptions();
            builder.Services.AddAuthorizationCore();
            builder.Services.AddScoped<AuthenticationStateProvider, LocalAuthenticationStateProvider>();
            builder.Services.AddScoped<DialogService>();
            builder.Services.AddScoped<NotificationService>();


            builder.RootComponents.Add<App>("app");

            await builder.Build().RunAsync();
        }
    }
}
