using GTPA.Business.Models.TramaAutomovil;

namespace GTPA.Business.Interfaces
{
    public interface IDetalleRiesgosAutomovilesRepository
    {
        List<DetalleRiesgosAutomoviles> ObtenerDatosPorFechas(DateTime fechaInicial, DateTime fechaFinal);
    }
}
