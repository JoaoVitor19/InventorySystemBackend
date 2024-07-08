using Persistence.Context;
using Application.Services;
using Persistence;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.OpenApi.Models;
using Domain.Interfaces;
using InventorySystem.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigurePesistenceApp(builder.Configuration);
builder.Services.ConfigureApplicationApp();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSingleton<IJwtTokenGenerator>(provider =>
{
    var issuer = "your-issuer-string";
    var audience = "your-audience-string";
    var secretKey = "your-secret-key-string-inventory-db-test-secret-key";
    return new JwtTokenGenerator(issuer, audience, secretKey);
});

builder.Services.AddAuthorization();

var app = builder.Build();

CorsPolicyExtensions.ConfigureCorsPolicy(builder.Services);
SwaggerConfigExtensions.SwaggerConfig(builder.Services, app);

CreateDatabase(app);

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapControllers();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.Run();

static void CreateDatabase(WebApplication app)
{
    var serviceScope = app.Services.CreateScope();
    var dataContext = serviceScope.ServiceProvider.GetService<AppDbContext>();
    dataContext?.Database.EnsureCreated();
}
