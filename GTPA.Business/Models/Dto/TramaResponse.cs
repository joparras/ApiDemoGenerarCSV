

namespace GTPA.Business.Models.Dto
{
    public class TramaResponse
    {
        public string NombreArchivo { get; private set; }
        public byte[] File { get; private set; }

        public TramaResponse(string nombreArchivo, byte[] file)
        {
            NombreArchivo = nombreArchivo;
            File = file;
        }
    }

}
