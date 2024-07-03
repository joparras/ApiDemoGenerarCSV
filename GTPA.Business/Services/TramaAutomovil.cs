using GTPA.Business.Interfaces;
using GTPA.Business.Models.Dto;
using GTPA.Business.Models.Enums;
using GTPA.Business.Models.TramaAutomovil;
using GTPA.Business.Services.Help;

namespace GTPA.Business.Services
{
    public class TramaAutomovil : ITrama
    {
        private readonly IDetalleRiesgosAutomovilesRepository _riesgosAutomoviesRepository;
        private readonly IFile _file;
        private readonly ILote _lote;

        public TramaAutomovil(IDetalleRiesgosAutomovilesRepository riesgosAutomoviesRepository, IFile file, ILote lote)
        {
            _riesgosAutomoviesRepository = riesgosAutomoviesRepository;
            _file = file;
            _lote = lote;
        }

        public TipoLote TipoLote => TipoLote.Automovil;

        public TramaResponse GenerarTrama(DateTime fechaInicial, DateTime fechaFinal)
        {
            var numeroLote = _lote.ObtenerNumeroLote(TipoLote);
            var datosBody = _riesgosAutomoviesRepository.ObtenerDatosPorFechas(fechaInicial, fechaFinal);
            var cabeceraTrama = new CabeceraTramaAuto(numeroLote, datosBody.Count, 0, 0, 0, 0);
            var tramaAuto = new TramaAuto(cabeceraTrama, datosBody);
            tramaAuto.SetNombreTramaArchivo();

            var stringCabeceraTrama = Util.DelimitarPropiedadesObjeto(cabeceraTrama, tramaAuto.Delimitador);
            var stringDatosBody = Util.DelimitarListaPropiedadesObjeto(datosBody, tramaAuto.Delimitador);

            tramaAuto.AdicionarCabeceraTrama(stringCabeceraTrama);
            tramaAuto.AdicionarDatosTrama(stringDatosBody);

            var file = _file.GenerarArchivo(tramaAuto.DatosTrama);
            tramaAuto.setFile(file);

            return new TramaResponse(tramaAuto.GetNombreArchivo(), tramaAuto.File);
        }
    }
}
