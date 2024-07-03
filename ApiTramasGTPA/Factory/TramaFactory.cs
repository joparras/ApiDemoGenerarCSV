using System;
using GTPA.Business.Interfaces;
using GTPA.Business.Models.Enums;
using GTPA.Business.Services;

namespace ApiTramasGTPA.Factory
{
	public class TramaFactory
	{
        private readonly IServiceProvider _serviceProvider;

        public TramaFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public ITrama GetTrama(TipoLote tipoTrama)  //implementacion de ITrama pero basandome en el lote
        {
            return tipoTrama switch
            {
                TipoLote.Automovil => _serviceProvider.GetRequiredService<TramaAutomovil>(),
                TipoLote.Sepelio => _serviceProvider.GetRequiredService<TramaSepelio>(),
                _ => throw new ArgumentOutOfRangeException(nameof(tipoTrama), $"No service registered for {tipoTrama}")
            };
        }
    }
}

