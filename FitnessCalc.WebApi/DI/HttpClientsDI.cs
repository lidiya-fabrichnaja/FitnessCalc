using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Net.Http.Headers;

namespace FitnessCalc.WebApi.DI
{
    public static class HttpClientsDI
    {
        public static IServiceCollection AddHttpClients(this IServiceCollection services)
        {
            services.AddHttpClient("FoodDataCenter", httpClient =>
            {
                  httpClient.BaseAddress = new Uri("https://api.nal.usda.gov/");

   
                  httpClient.DefaultRequestHeaders.Add(
                  HeaderNames.Accept, "*/*");
                  httpClient.DefaultRequestHeaders.Add(
                  HeaderNames.UserAgent, "HttpRequestsSample");
            });
            return services;
        }
    }
}