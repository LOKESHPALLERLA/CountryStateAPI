using WebApplication1.Data;
using Microsoft.EntityFrameworkCore;
using CountryStateApi.Services.Interfaces;
using CountryStateApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<TaskDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("TaskDB"));
});
#region dependency injection resolver
builder.Services.AddScoped<IData, DataService>();
#endregion

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
