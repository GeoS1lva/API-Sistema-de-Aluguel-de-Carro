using System.Text.Json.Serialization;
using AluguelDeCarro.Application.UseCase.CarsUC;
using AluguelDeCarro.Application.UseCase.EmployeeLoginUC;
using AluguelDeCarro.Domain.Entity.cars;
using AluguelDeCarro.Domain.Entity.employeeLogin;
using AluguelDeCarro.Domain.Repository;
using AluguelDeCarro.Infrastructure.Context;
using AluguelDeCarro.Infrastructure.Login;
using AluguelDeCarro.Infrastructure.VehicleCar;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<SqlServerDbContext>();
builder.Services.AddDbContext<SqlServerDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoSql")));

builder.Services.AddScoped<IEmployeeLoginRepository, EmployeeLoginRepository>();
builder.Services.AddScoped<IEmployeeLoginUseCase, EmployeeLoginUseCase>();
builder.Services.AddScoped<IPasswordHasher, PasswordHasher>();
builder.Services.AddScoped<ICarsRepository, CarsRepository>();
builder.Services.AddScoped<ICarsUseCase, CarsUseCase>();
builder.Services.AddScoped<IValidatePlate, ValidatePlate>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirFrontend", policy =>
    {
        policy
            .WithOrigins("http://127.0.0.1:5500")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});


builder.Services.AddControllers();

builder.Services
    .AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("PermitirFrontend");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
