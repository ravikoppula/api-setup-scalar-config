using System.Runtime.CompilerServices;

namespace TheSampleAPI.Startup
{
    public static class DependenciesConfig
    {
        public static void AddDependencies(this WebApplicationBuilder builder)
        {
            builder.Services.AddOpenAPIServices();
        }
    }
}
