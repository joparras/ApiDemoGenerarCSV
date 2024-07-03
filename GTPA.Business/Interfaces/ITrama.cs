using GTPA.Business.Models.Dto;
using GTPA.Business.Models.Enums;

namespace GTPA.Business.Interfaces
{
    public interface ITrama
    {
        TipoLote TipoLote { get; }
        TramaResponse GenerarTrama(DateTime fechaInicial, DateTime fechaFinal);
    }
}
