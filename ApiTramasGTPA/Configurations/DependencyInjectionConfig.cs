
using ApiTramasGTPA.Factory;
using GTPA.Business.Interfaces;
using GTPA.Business.Services;
using GTPA.Data.Repositories;

namespace ApiTramasGTPA.Configurations;

public static class DependencyInjectionConfig
{
    //añadir las dependencias necesarias a la colección de servicios
    public static IServiceCollection ResolveDependencies(this IServiceCollection services)
    {
       //Registramos los repositorios como implementaciones de sus interfaces  
        services.AddScoped<IDetalleRiesgosAutomovilesRepository, DetalleRiesgosAutomovilesRepository>();
        services.AddScoped<IDetalleRiesgosSepelioRepository, DetalleRiesgosSepelioRepository>();

        //Registramos de servicios como implementaciones de interfaces
        services.AddScoped<IFile, GTPA.Data.Repositories.File>();
        services.AddScoped<ILote, Lote>();

        // Registrar las implementaciones de ITrama
        services.AddScoped<TramaAutomovil>();
        services.AddScoped<TramaSepelio>();

        // Registrar la fábrica personalizada
        services.AddScoped<TramaFactory>();

        return services;
    }


}
