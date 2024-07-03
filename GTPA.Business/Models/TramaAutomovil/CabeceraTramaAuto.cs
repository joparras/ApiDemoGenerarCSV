using GTPA.Business.Models.Genericos;

namespace GTPA.Business.Models.TramaAutomovil
{
    public class CabeceraTramaAuto : Cabecera
    {
        private const string tipoTrama = "EDRA";

        public CabeceraTramaAuto(int numeroLote, int numeroRegistros, int numeroAltas, int numeroBajas, int numeroCambios, int numeroRehabilitados)
            : base(tipoTrama, numeroLote, numeroRegistros, numeroAltas, numeroBajas, numeroCambios, numeroRehabilitados)
        {
        }
    }
}
