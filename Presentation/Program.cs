using Persistence.Context;
using Application.Services;
using Persistence;
using Microsoft.OpenApi.Models;
using Domain.Interfaces;
using InventorySystem.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigurePesistenceApp(builder.Configuration);
builder.Services.ConfigureApplicationApp();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddAuthorization();
builder.Services.AddLogging();

builder.Services.ConfigureCorsPolicy();

builder.Services.AddSingleton<IJwtTokenGenerator>(provider =>
{
    var issuer = "your-issuer-string";
    var audience = "your-audience-string";
    var secretKey = "your-secret-key-string-inventory-db-test-secret-key";
    return new JwtTokenGenerator(issuer, audience, secretKey);
});

builder.Services.AddAuthorization();

CorsPolicyExtensions.ConfigureCorsPolicy(builder.Services);

builder.Services.AddSwaggerGen(option =>
{
    option.SwaggerDoc("v1", new OpenApiInfo { Title = "Inventory API", Version = "v1" });
    option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter a valid token",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "Bearer"
    });
    option.AddSecurityRequirement(new OpenApiSecurityRequirement()
    {
      {
            new OpenApiSecurityScheme()
            {
                Reference = new OpenApiReference
                {
                    Type=ReferenceType.SecurityScheme,
                    Id="Bearer"
                }
            },
            new string[]{}
       }
    });
});

var app = builder.Build();


builder.Services.AddSwaggerGen();

builder.Services.AddSwaggerGen(option =>
{
    option.SwaggerDoc("v1", new OpenApiInfo { Title = "Inventory API", Version = "v1" });
    option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter a valid token",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "Bearer"
    });
    option.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type=ReferenceType.SecurityScheme,
                                Id="Bearer"
                            }
                        },
                        new string[]{}
                    }
            });
});

app.UseSwagger();
app.UseSwaggerUI();

app.UseSwagger();
app.UseSwaggerUI();
app.UseCors();

CreateDatabase(app);

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapControllers();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

//app.UseMiddleware<ExceptionHandlingMiddleware>();

app.Run();

static void CreateDatabase(WebApplication app)
{
    var serviceScope = app.Services.CreateScope();
    var dataContext = serviceScope.ServiceProvider.GetService<AppDbContext>();
    dataContext?.Database.EnsureCreated();
}
