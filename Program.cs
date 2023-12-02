using Microsoft.EntityFrameworkCore;
using minozas_catering_api_dotnet.Context;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddEnvironmentVariables();
builder.Services.AddDbContext<StoreContext>(o => o.UseNpgsql(builder.Configuration["ASPNETCORE_DB"]));
var app = builder.Build();

app.Run();
