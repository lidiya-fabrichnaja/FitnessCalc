using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessCalc.WebApi.Services.ContractsRefit;
using Refit;

namespace FitnessCalc.WebApi.DI
{
    public static class RefitDI
    {
        public static IServiceCollection AddRefitClients(this IServiceCollection services)
        {
            services.AddRefitClient<IFoodDataCenterClient>()
                    .ConfigureHttpClient(httpClient => 
                    {
                        httpClient.BaseAddress = new Uri("https://api.nal.usda.gov/");

                    });

            services.AddRefitClient<IApiTranslate>()
                    .ConfigureHttpClient(httpClient =>
                    {
                        httpClient.BaseAddress = new Uri("https://translate.yandex.net/");
                    });

            return services;
        }   
    }
}