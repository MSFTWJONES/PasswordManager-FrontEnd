using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using keyvault.web.services;

namespace keyvault
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddSingleton<SecretService>();
            builder.Services.AddScoped<KeyvaultAPIAuthorizationMessageHandler>();
            builder.Services.AddHttpClient(builder.Configuration["Keyvault:ApiClientName"],
                client => client.BaseAddress = new Uri(builder.Configuration["Keyvault:APIBaseUrl"]))
                    .AddHttpMessageHandler<KeyvaultAPIAuthorizationMessageHandler>();

            builder.Services.AddMsalAuthentication(options =>
            {
                builder.Configuration.Bind("AzureAd", options.ProviderOptions.Authentication);
                options.ProviderOptions.DefaultAccessTokenScopes.Add(string.Format("api://{0}/.default",builder.Configuration["Keyvault:APIApplicatonId"]));
            });

            await builder.Build().RunAsync();
        }
    }
}
