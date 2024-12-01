using Microsoft.EntityFrameworkCore;
using ToDoList.Models;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();
string connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ToDoContext>(options => options.UseSqlServer(connection));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
