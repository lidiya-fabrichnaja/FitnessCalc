using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;

namespace FitnessCalc.WebApi.DI
{
    public static class VersioningDI
    {
        public static IServiceCollection AddVersioning(this IServiceCollection services)
        {
            services.AddApiVersioning(options =>
            {
                options.DefaultApiVersion = new ApiVersion(1,0);
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.ReportApiVersions = true;

                options.ApiVersionReader = ApiVersionReader.Combine(
		            new UrlSegmentApiVersionReader(), 
                    new HeaderApiVersionReader("api-version"), 
                    new QueryStringApiVersionReader("api-version"),
                    new MediaTypeApiVersionReader("version"));
                


            });

            services.AddVersionedApiExplorer(options =>
            {
                options.GroupNameFormat = "'v'VVV";
                options.SubstituteApiVersionInUrl = true;
            });



            return services;
        }
    }
}