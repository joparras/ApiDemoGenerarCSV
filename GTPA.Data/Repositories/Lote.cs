using GTPA.Business.Interfaces;
using GTPA.Business.Models.Enums;

namespace GTPA.Data.Repositories
{
    public class Lote : ILote
    {
        public int ObtenerNumeroLote(TipoLote tipoLote)
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 10000001);

            return numeroAleatorio;
        }
    }
}
