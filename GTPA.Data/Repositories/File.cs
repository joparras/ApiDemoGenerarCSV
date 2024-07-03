using GTPA.Business.Interfaces;
using System.Text;

namespace GTPA.Data.Repositories
{
    public class File : IFile
    {
        public byte[] GenerarArchivo(List<string> datos)
        {
            var stringBuilder = new StringBuilder();

            if (datos.Count > 0)
            {
                foreach (var dato in datos) 
                {
                    stringBuilder.AppendLine(dato); //adcionar
                }
            }

            return Encoding.UTF8.GetBytes(stringBuilder.ToString());
        }
    }
}
