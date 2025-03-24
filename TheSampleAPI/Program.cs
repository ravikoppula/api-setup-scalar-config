using Scalar.AspNetCore;
using TheSampleAPI.Endpoints;
using TheSampleAPI.Startup;

var builder = WebApplication.CreateBuilder(args);

builder.AddDependencies();

var app = builder.Build();

app.UseOpenApi();

app.UseHttpsRedirection();

app.AddRootEndPoints();

app.Run();
 