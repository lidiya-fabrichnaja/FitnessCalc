using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using FitnessCalc.Commons.Helpers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using FitnessCalc.Commons.Exceptions;
using FitnessCalc.Commons.BaseObjects;
using FitnessCalc.Commons.Extensions;

namespace FitnessCalc.WebApi.DI
{
    public static class AuthorizationDI
    {
        public static IServiceCollection AddJwtAuthorization(this IServiceCollection services)
        {
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidIssuer = AuthManager.ISSUER,
                ValidateAudience = true,
                ValidAudience = AuthManager.AUDIENCE,
                ValidateLifetime = true,
                IssuerSigningKey = AuthManager.GetSymmetricSecurityKey(),
                ValidateIssuerSigningKey = true

            };

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                    .AddJwtBearer(options =>
                    {
                        options.TokenValidationParameters = tokenValidationParameters;
                        options.Events = new JwtBearerEvents()
                        {
                            OnChallenge = context =>
                            {
                                context.HandleResponse();

                                context.Response.StatusCode = (int)HttpStatusCode.OK;
                                context.Response.ContentType = "application/json";
                                return context.Response.WriteJsonAsync(
                                    new AppResponce(
                                        new AppError
                                        {
                                            Message = "Доступ запрещен",
                                            Code = ErrorCode.AccessDenied.ToString()
                                        }
                                    )
                                );
                                
                            }

                        };

                    });

            services.AddAuthorization(options =>
            {
                // foreach (var claim in Enum.GetNames<ClaimType>())
                // {
                    
                // }
                options.AddPolicy("all" ,x =>
                {
                    x.RequireAuthenticatedUser();
                    x.AuthenticationSchemes.Add(JwtBearerDefaults.AuthenticationScheme);
                });
            });

            return services;
        }
    }
}