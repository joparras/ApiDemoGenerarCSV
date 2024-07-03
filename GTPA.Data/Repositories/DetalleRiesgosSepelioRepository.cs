using GTPA.Business.Interfaces;
using GTPA.Business.Models.TramaSepelio;

namespace GTPA.Data.Repositories
{
    public class DetalleRiesgosSepelioRepository : IDetalleRiesgosSepelioRepository
    {
        private readonly List<DetalleRiesgosSepelios> _detalleRiesgosSepelios;

        public DetalleRiesgosSepelioRepository()
        {
            _detalleRiesgosSepelios = ObtenerDatosFicticios();
        }

        public List<DetalleRiesgosSepelios> ObtenerDatosPorFechas(DateTime fechaInicial, DateTime fechaFinal)
        {
            return _detalleRiesgosSepelios
            .Where(d => d.Fecha >= fechaInicial && d.Fecha <= fechaFinal)
                .ToList();
        }

        private List<DetalleRiesgosSepelios>? ObtenerDatosFicticios()
        {
            return new List<DetalleRiesgosSepelios>
            {

               new DetalleRiesgosSepelios
               {
                    CodCia = "01",
                    NumPolizaGrupo = "1234567890123",
                    TipMovimiento = "1",
                    NumUnicoItem = "12345678901234567890",
                    NumRiesgo = "001",
                    CodPlan = "12345",
                    McaMancomunado = "S",
                    CodParentesco = "01",
                    TipDocumTitular = "DNI",
                    CodDocumTitular = "12345678A",
                    TipDocumAsegurado = "DNI",
                    CodDocumAsegurado = "87654321B",
                    NombreAsegurado = "Juan",
                    ApellidoPaternoAsegurado = "Pérez",
                    ApellidoMaternoAsegurado = "García",
                    FecNacimiento = new DateTime(1980, 5, 20),
                    McaSexo = 'M',
                    CodEstCivil = 'S',
                    NumMesesFto = 24,
                    NumeroAsegurados = 1,
                    ImpCredito = 15000.00m,
                    FecDesembolso = new DateTime(2022, 1, 1),
                    ImpSaldoCredito = 12000.00m,
                    ImpSueldoBruto = 3000.00m,
                    ValTasaRiesgo = 1.5m,
                    ImpPrimaTecnicaCanal = 200.00m,
                    Fecha = DateTime.Now,
                  
               },
               new DetalleRiesgosSepelios
               {
                    CodCia = "02",
                    NumPolizaGrupo = "9876543210987",
                    TipMovimiento = "2",
                    NumUnicoItem = "09876543210987654321",
                    NumRiesgo = "002",
                    CodPlan = "54321",
                    McaMancomunado = "N",
                    CodParentesco = "02",
                    TipDocumTitular = "NIE",
                    CodDocumTitular = "Y1234567Z",
                    TipDocumAsegurado = "NIE",
                    CodDocumAsegurado = "Z7654321Y",
                    NombreAsegurado = "María",
                    ApellidoPaternoAsegurado = "López",
                    ApellidoMaternoAsegurado = "Martínez",
                    FecNacimiento = new DateTime(1990, 10, 15),
                    McaSexo = 'F',
                    CodEstCivil = 'C',
                    NumMesesFto = 36,
                    NumeroAsegurados = 2,
                    ImpCredito = 20000.00m,
                    FecDesembolso = new DateTime(2023, 2, 15),
                    ImpSaldoCredito = 18000.00m,
                    ImpSueldoBruto = 2500.00m,
                    ValTasaRiesgo = 2.0m,
                    ImpPrimaTecnicaCanal = 300.00m,
                    Fecha = DateTime.Now,

               }

            };
        }

    }
}
