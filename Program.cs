using dotenv.net;
using Microsoft.EntityFrameworkCore;
using minozas_catering_api_dotnet.Constants;
using minozas_catering_api_dotnet.Context;
using minozas_catering_api_dotnet.Schema.Queries;
using minozas_catering_api_dotnet.Services;

// DotEnv Loading
DotEnv.Load();

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddEnvironmentVariables();

// GraphQL Schema
builder.Services.AddGraphQLServer()
    .AddQueryType(q => q.Name("Query"))
    .AddType<FoodQuery>();

// DB Connection
builder.Services.AddPooledDbContextFactory<StoreContext>(o => o.UseNpgsql(builder.Configuration["ASPNETCORE_DB"]));

// Services
builder.Services.AddScoped<FoodService>();

// CORS Config
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: Cors.MyAllowSpecificOrigins,
    policy =>
    {
        policy.WithOrigins("*")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseCors(Cors.MyAllowSpecificOrigins);

// App Routing
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGraphQL();
});

app.MapGet("/", () => "Hello World!");

app.Run();
