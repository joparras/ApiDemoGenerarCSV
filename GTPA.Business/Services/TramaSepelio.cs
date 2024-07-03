using GTPA.Business.Interfaces;
using GTPA.Business.Models.Dto;
using GTPA.Business.Models.Enums;
using GTPA.Business.Models.TramaAutomovil;
using GTPA.Business.Models.TramaSepelio;
using GTPA.Business.Services.Help;

namespace GTPA.Business.Services
{
    public class TramaSepelio : ITrama
    {
        private readonly IDetalleRiesgosSepelioRepository _riesgosSepelioRepository;
        private readonly IFile _file;
        private readonly ILote _lote;


        public TramaSepelio(IDetalleRiesgosSepelioRepository riesgosSepelioRepository, IFile file, ILote lote)
        {
            _riesgosSepelioRepository = riesgosSepelioRepository;
            _file = file;
            _lote = lote;
        }
        public TipoLote TipoLote => TipoLote.Sepelio;

        public TramaResponse GenerarTrama(DateTime fechaInicial, DateTime fechaFinal)
        {
            var numeroLote = _lote.ObtenerNumeroLote(TipoLote);
            var datosBody = _riesgosSepelioRepository.ObtenerDatosPorFechas(fechaInicial, fechaFinal);
            var cabeceraTrama = new CabeceraTramaSepelio(numeroLote, datosBody.Count, 0, 0, 0, 0);
            var tramaSepelio = new GTPA.Business.Models.TramaSepelio.TramaSepelio(cabeceraTrama,datosBody);
            tramaSepelio.SetNombreTramaArchivo();

            var stringCabeceraTrama = Util.DelimitarPropiedadesObjeto(cabeceraTrama, tramaSepelio.Delimitador);
            var stringDatosBody = Util.DelimitarListaPropiedadesObjeto(datosBody, tramaSepelio.Delimitador);

            tramaSepelio.AdicionarCabeceraTrama(stringCabeceraTrama);
            tramaSepelio.AdicionarDatosTrama(stringDatosBody);

            var file = _file.GenerarArchivo(tramaSepelio.DatosTrama);
            tramaSepelio.setFile(file);

            return new TramaResponse(tramaSepelio.GetNombreArchivo(), tramaSepelio.File);
        }
    }
}
