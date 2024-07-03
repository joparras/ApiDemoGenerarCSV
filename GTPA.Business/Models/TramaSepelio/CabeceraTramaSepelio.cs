using GTPA.Business.Models.Genericos;

namespace GTPA.Business.Models.TramaSepelio
{
    public class CabeceraTramaSepelio : Cabecera
    {
        private const string tipoTrama = "EDRV";

        public CabeceraTramaSepelio(int numeroLote, int numeroRegistros, int numeroAltas, int numeroBajas, int numeroCambios, int numeroRehabilitados) 
            : base(tipoTrama, numeroLote, numeroRegistros, numeroAltas, numeroBajas, numeroCambios, numeroRehabilitados)
        {
        }
    }
}
