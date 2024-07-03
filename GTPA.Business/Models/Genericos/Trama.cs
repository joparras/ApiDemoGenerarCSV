
using System;

namespace GTPA.Business.Models.Genericos
{
    public abstract class Trama 
    {
        protected Trama(string delimitador)
        {
            Delimitador = delimitador;
            DatosTrama = new List<string>();
        }

        public List<string> DatosTrama { get; private set; } 
        protected string NombreArchivo { get;  set; }
        public byte[] File {get; private set; }
        public string Delimitador { get; private set; }

        public void AdicionarDatosTrama(List<string> datosTrama)
            => DatosTrama.AddRange(datosTrama); //=> llave{} 

        public void AdicionarCabeceraTrama(string cabeceraTrama)
            => DatosTrama.Add(cabeceraTrama);

        public void setFile(byte[] file)
            => File = file;


        public string GetNombreArchivo()
            => NombreArchivo;

        public abstract void SetNombreTramaArchivo();
    }
}
