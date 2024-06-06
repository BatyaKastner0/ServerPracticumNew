using AutoMapper;
using Managment.Core.Mapping;
using Managment.Core.Repository;
using Managment.Core.Services;
using Managment.Data;
using Managment.Data.Repositories;
using Managment.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Net;
ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IRoleRepository, RoleRepository>();
builder.Services.AddScoped<IRoleService, RoleService>();
builder.Services.AddAutoMapper(typeof(MappingProfile), typeof(Mapper));
builder.Services.AddDbContext<DataContext>();
var policy = "policy";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: policy, policy =>
    {
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

builder.Services.AddAutoMapper(typeof(MappingProfile), typeof(MapperProfile));
builder.Services.AddDbContext<DataContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors(policy);


app.MapControllers();

app.Run();
