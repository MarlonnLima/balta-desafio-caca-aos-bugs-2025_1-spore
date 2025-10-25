using BugStore.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseSqlite(connectionString);
});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.Run();