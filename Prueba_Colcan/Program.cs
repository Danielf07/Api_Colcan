using Microsoft.EntityFrameworkCore;
using Prueba_Colcan.Context;

var builder = WebApplication.CreateBuilder(args);

// Add string connection
var connectionString = builder.Configuration.GetConnectionString("ColcanConnection");
builder.Services.AddDbContext<ColcanConext>(option => option.UseSqlServer(connectionString));

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
