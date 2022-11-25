using FitnessCalc.App.Services.UserService;
using FitnessCalc.WebApi.DI;
using FitnessCalc.WebApi.Services;
using FitnessCalc.Commons.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Versioning;
using FitnessCalc.Commons.Extensions;
using FitnessCalc.WebApi.Services.ContractsRefit;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("apisettings.json");
builder.Logging.AddFile(Path.Combine(Directory.GetCurrentDirectory(), "log.txt"));
var services = builder.Services;

// Add services to the container.
services.AddControllers();

services.AddEndpointsApiExplorer();
services.AddJwtAuthorization();
services.AddVersioning();
services.AddSwagger();
services.AddHttpClients();
services.AddRefitClients();
services.AddTransient<FoodDataService>();
services.AddTransient<FoodDataCenterService>();
services.AddTransient<IUserService, UserService>();

services.Configure<ApiSettings>(builder.Configuration.GetSection(nameof(ApiSettings)));
services.Configure<FoodDataSettings>(builder.Configuration.GetSection(nameof(FoodDataSettings)));

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    var provider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();

    app.UseSwaggerGen(provider);
}

app.UseStaticFiles();
app.UseRouting();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.UseEndpoints( e => {e.MapDefaultControllerRoute();});

app.MapControllers();

app.Run();