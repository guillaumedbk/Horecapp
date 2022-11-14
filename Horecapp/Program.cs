using Horecapp.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//DB CONTEXT
builder.Services.AddDbContext<HorecappDbContext>(opt =>
{
    string cs = builder.Configuration.GetConnectionString("MyMysqlConnexion");
    opt.UseMySql(cs, ServerVersion.AutoDetect(cs));
});
//Deserialize Json
builder.Services.AddMvc().AddNewtonsoftJson();
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