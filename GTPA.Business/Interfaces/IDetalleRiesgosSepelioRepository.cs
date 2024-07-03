using GTPA.Business.Models.TramaSepelio;

namespace GTPA.Business.Interfaces
{
    public interface IDetalleRiesgosSepelioRepository
    {
        List<DetalleRiesgosSepelios> ObtenerDatosPorFechas(DateTime fechaInicial, DateTime fechaFinal);
    }
}
