using Microsoft.EntityFrameworkCore;
using Helseportalen.Api.Data;

var builder = WebApplication.CreateBuilder(args);

// add services
builder.Services.AddControllers(); //for controllers
builder.Services.AddEndpointsApiExplorer(); // openapi/Swagger
builder.Services.AddSwaggerGen();

// add database context (EF Core)
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=helseportalen.db")); // SQLite for simplicity

// build app
var app = builder.Build();

// middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthorization();

// map controllers
app.MapControllers();

// start app
app.Run();
