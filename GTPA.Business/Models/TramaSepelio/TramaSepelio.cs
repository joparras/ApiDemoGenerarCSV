using GTPA.Business.Models.Genericos;

namespace GTPA.Business.Models.TramaSepelio
{
    public class TramaSepelio : Trama
    {
        private const string delimitador = ";";
        public CabeceraTramaSepelio CabeceraTramaSepelio { get; private set; }
        public List<DetalleRiesgosSepelios> DetalleRiesgosSepelios { get; private set; }

        public TramaSepelio(CabeceraTramaSepelio cabeceraTramaSepelio, List<DetalleRiesgosSepelios> detalleRiesgosSepelios)
            : base(delimitador)
        {
            CabeceraTramaSepelio = cabeceraTramaSepelio;
            DetalleRiesgosSepelios = detalleRiesgosSepelios; 
        }

        public override void SetNombreTramaArchivo()
        {
            NombreArchivo = $"{CabeceraTramaSepelio.TipoTrama}{CabeceraTramaSepelio.FechaLote}{CabeceraTramaSepelio.NumeroLote}.csv";
        }
    }
}
