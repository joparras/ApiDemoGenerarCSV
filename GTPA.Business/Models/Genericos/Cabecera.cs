
namespace GTPA.Business.Models.Genericos
{
    public abstract class Cabecera 
    {
        private const string marcaEmision = "N";

        public string TipoTrama { get; private set; }
        public string MarcaEmision { get => marcaEmision; }
        public string FechaLote { get => DateTime.Now.ToString("yyyyMMdd"); }
        public int NumeroLote { get; private set; }
        public int NumeroRegistros { get; private set; }
        public int NumeroAltas { get; private set; }
        public int NumeroBajas { get; private set; }
        public int NumeroCambios { get; private set; }
        public int NumeroRehabilitados { get; private set; }

        public Cabecera(string tipoTrama, int numLote, int numeroRegistros, int numeroAltas, int numeroBajas, int numeroCambios, int numeroRehabilitados)
        {
            TipoTrama = tipoTrama;
            NumeroLote = numLote;
            NumeroRegistros = numeroRegistros;
            NumeroAltas = numeroAltas;
            NumeroBajas = numeroBajas;
            NumeroCambios = numeroCambios;
            NumeroRehabilitados = numeroRehabilitados;
        }
    }
}
