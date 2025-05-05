using CP2.API.Application.Interfaces;
using CP2.API.Application.Services;
using CP2.API.Domain.Interfaces;
using CP2.API.Infrastructure.Data.Repositories;
using CP2.API.Infrastructure.Data.AppData;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IFornecedorRepository, FornecedorRepository>();
builder.Services.AddScoped<IVendedorRepository, VendedorRepository>();
builder.Services.AddScoped<IFornecedorApplicationService, FornecedorApplicationService>();
builder.Services.AddScoped<IVendedorApplicationService, VendedorApplicationService>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
