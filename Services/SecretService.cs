using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.Extensions.Configuration;

namespace keyvault.web.services
{
    public class SecretService
    {

        private readonly HttpClient _http;
        private readonly IConfiguration _config;

        public SecretService(IConfiguration configuration, IHttpClientFactory HttpClientFactory)
        {
            this._config = configuration;
             _http = HttpClientFactory.CreateClient(_config["Keyvault:ApiClientName"]);
        }

        public async Task<List<SecretIndexViewModel>> GetAll()
        {
            try 
            {
                var dataRequest = await _http.GetAsync(String.Format("{0}/secret",_config["Keyvault:APIBaseUrl"]));
                return await dataRequest.Content.ReadFromJsonAsync<List<SecretIndexViewModel>>();
            }
            catch(InvalidOperationException exception)
            {
                throw exception;
            }
            catch(AccessTokenNotAvailableException exception)
            {
                throw exception;
            }
        }

        public async Task<SecretModel> Reveal(string name)
        {
            try 
            {
                var dataRequest = await _http.GetAsync(String.Format("{0}/secret/{1}",_config["Keyvault:APIBaseUrl"],name));
                return await dataRequest.Content.ReadFromJsonAsync<SecretModel>();
            }
            catch(InvalidOperationException exception)
            {
                throw exception;
            }
            catch(AccessTokenNotAvailableException exception)
            {
                throw exception;
            }
        }
        public async Task<SecretDetailsViewModel> Get(string name)
        {
            try 
            {
                var dataRequest = await _http.GetAsync(String.Format("{0}/secret/{1}",_config["Keyvault:APIBaseUrl"], name));
                return await dataRequest.Content.ReadFromJsonAsync<SecretDetailsViewModel>();
            }
            catch(InvalidOperationException exception)
            {
                throw exception;
            }
            catch(AccessTokenNotAvailableException exception)
            {
                throw exception;
            }
        }


        public async Task<List<SecretDetailsViewModel>> Edit(string name, string password)
        {
            try 
            {
                var dataRequest = await _http.PostAsJsonAsync(String.Format("{0}/secret/{1}/update",_config["Keyvault:APIBaseUrl"], name),password);
                return await dataRequest.Content.ReadFromJsonAsync<List<SecretDetailsViewModel>>();
            }
            catch(InvalidOperationException exception)
            {
                throw exception;
            }
            catch(AccessTokenNotAvailableException exception)
            {
                throw exception;
            }
        }

    }
}
