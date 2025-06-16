using AluguelDeCarro.Application.UseCase;
using AluguelDeCarro.Domain.Service;
using AluguelDeCarro.Infrastructure.Context;
using AluguelDeCarro.Infrastructure.Login;
using AluguelDeCarro.Infrastructure.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<SqlServerDbContext>();
builder.Services.AddDbContext<SqlServerDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoSql")));

builder.Services.AddScoped<IEmployeeLoginRepository, EmployeeLoginRepository>();
builder.Services.AddScoped<IEmployeeLoginUseCase, EmployeeLoginUseCase>();
builder.Services.AddScoped<IPasswordHasher, PasswordHasher>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
