using System.Reflection;
using FilterLists.Api;
using FilterLists.Api.Queries.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(o =>
{
    o.SwaggerDoc(
        "v1",
        new OpenApiInfo
        {
            Title = "FilterLists API",
            Description = "An RESTful API serving the FilterList information.",
            Version = "v1",
            Contact = new OpenApiContact { Name = "FilterLists", Url = new Uri("https://filterlists.com") },
            License = new OpenApiLicense
            {
                Name = "MIT License",
                Url = new Uri("https://github.com/collinbarrett/FilterLists/blob/main/LICENSE")
            }
        });

    o.IncludeXmlComments(
        Path.Combine(AppContext.BaseDirectory, $"{Assembly.GetExecutingAssembly().GetName().Name}.xml"));
});

builder.Services.AddDbContext<QueryDbContext>(options =>
    options.UseSqlServer("name=ConnectionStrings:FilterListsReadOnly"));
builder.Services.AddScoped<IQueryContext, QueryContext>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapRoutes();

app.Run();