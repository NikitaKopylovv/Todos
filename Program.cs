using Microsoft.EntityFrameworkCore;
// using TodoApi.Data;
using TodoApi.Models;

var builder = WebApplication.CreateBuilder(args);

// контекст базы данных
builder.Services.AddDbContext<TodoContext>(options =>
    options.UseSqlite("Data Source=TodoDatabase.db"));

var app = builder.Build();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
