using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<PrenumerantContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("PrenumerantDb")));

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();
app.Run();