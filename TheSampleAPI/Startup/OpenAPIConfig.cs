using Scalar.AspNetCore;

namespace TheSampleAPI.Startup
{
    public static class OpenAPIConfig
    {
        public static void AddOpenAPIServices(this IServiceCollection services)
        {
            services.AddOpenApi();
        }

        public static void UseOpenApi(this WebApplication app)
        {

            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.MapScalarApiReference(options => {

                    options.Title = "The Sample API";
                    options.Theme = ScalarTheme.BluePlanet;
                    options.Layout = ScalarLayout.Classic;
                    options.HideClientButton = true;


                });
            }
        }
    }
}
