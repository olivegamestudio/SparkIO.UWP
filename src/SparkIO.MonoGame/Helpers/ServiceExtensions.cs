using Microsoft.Extensions.DependencyInjection;

namespace SparkIO;

public static class ServiceExtensions
{
    public static IServiceCollection AddSparkIOForMonoGameUWP(this IServiceCollection services)
    {
        services.AddSingleton<IFileSystem, FileSystemMonoGame>();
        return services;
    }
}
