using GTPA.Business.Models.Genericos;

namespace GTPA.Business.Models.TramaAutomovil
{
    public class TramaAuto : Trama
    {
        private const string delimitador = ";";
        public CabeceraTramaAuto CaberceraTramaAuto { get; private set; }
        public List<DetalleRiesgosAutomoviles> DetallesRiesgosAutomoviles { get; private set; }

        public TramaAuto(CabeceraTramaAuto caberceraTramaAuto, List<DetalleRiesgosAutomoviles> detallesRiesgosAutomoviles)
            : base(delimitador)
        {
            CaberceraTramaAuto = caberceraTramaAuto;
            DetallesRiesgosAutomoviles = detallesRiesgosAutomoviles;
        }

        public override void SetNombreTramaArchivo()
        {
            NombreArchivo = $"{CaberceraTramaAuto.TipoTrama}{CaberceraTramaAuto.FechaLote}{CaberceraTramaAuto.NumeroLote}.csv";
        }
    }
}
