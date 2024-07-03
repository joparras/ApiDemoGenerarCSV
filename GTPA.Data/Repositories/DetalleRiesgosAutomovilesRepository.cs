using GTPA.Business.Interfaces;
using GTPA.Business.Models.TramaAutomovil;

namespace GTPA.Data.Repositories
{
    public class DetalleRiesgosAutomovilesRepository : IDetalleRiesgosAutomovilesRepository
    {
        private readonly List<DetalleRiesgosAutomoviles> _detallesRiesgosAutomoviles;

        public DetalleRiesgosAutomovilesRepository()
        {
            _detallesRiesgosAutomoviles = ObtenerDatosFicticios();
        }

        public List<DetalleRiesgosAutomoviles> ObtenerDatosPorFechas(DateTime fechaInicial, DateTime fechaFinal)
        {
            return _detallesRiesgosAutomoviles
                .Where(d => d.Fecha >= fechaInicial && d.Fecha <= fechaFinal)
                .ToList();
        }
       
        public List<DetalleRiesgosAutomoviles> ObtenerDatosFicticios()
        {
            return new List<DetalleRiesgosAutomoviles>
            {
                new DetalleRiesgosAutomoviles
                {
                    CodCia = "001",
                    NumPolizaGrupo = "1234567890123",
                    TipMovimiento = "1",
                    NumUnicoItem = "UNICO001",
                    NumRiesgo = "001",
                    CodPlan = "PLAN001",
                    TipCodificacion = "M",
                    CodMarca = "MARCA001",
                    CodModelo = "MODELO001",
                    CodSubModelo = "SUBMODELO001",
                    NomMarca = "Marca1",
                    NomModelo = "Modelo1",
                    NomSubModelo = "SubModelo1",
                    TxtModelo = "Descripción del modelo",
                    ValVehiculo = 25000.50m,
                    CodUsoVehi = "Uso1",
                    AnioFab = 2023,
                    NumMatricula = "ABC123",
                    NumSerie = "SER123",
                    NumMotor = "MOT123",
                    CodTipVehi = "TIP001",
                    NumOcupantes = 5,
                    CodColor = "COL001",
                    TxtColor = "Rojo",
                    McaTimonCambiado = "S",
                    McaGPS = "N",
                    McaSistemaGas = "N",
                    ValTasaCanal = 3.5m,
                    ImpGrossUp = 500.75m,
                    NumCertificadoSOAT = "CERT123",
                    ImpPrimaTecnicaCanal = 1500.25m,
                    ImpPrimaNetaCanal = 1200.50m,
                    TxtObservacion = "Observaciones adicionales",
                    TipDocumAsegurado = "DNI",
                    CodDocumAsegurado = "12345678",
                    NomAsegurado = "Juan",
                    Ape1Asegurado = "Pérez",
                    Ape2Asegurado = "Gómez",
                    FecNacimientoAseg = new DateTime(1985, 5, 15),
                    McaSexoAseg = "1",
                    CodEstCivilAseg = "S",
                    PctDctoComCanal = 10.5m,
                    ImpDctoComCanal = 200.75m,
                    CodEstadoAseg = 1,
                    CodProvAseg = 1,
                    CodLocalidadAseg = 1,
                    NomDireccionAseg = "Calle Principal 123",
                    NumTelfFijo = "123456789",
                    NumTelfMovil = "987654321",
                    TxtEmail = "juan.perez@example.com",
                    Fecha = DateTime.Now.AddDays(-1)

                },
                new DetalleRiesgosAutomoviles
                {
                    CodCia = "002",
                    NumPolizaGrupo = "9876543210987",
                    TipMovimiento = "2",
                    NumUnicoItem = "UNICO002",
                    NumRiesgo = "002",
                    CodPlan = "PLAN002",
                    TipCodificacion = "C",
                    CodMarca = "MARCA002",
                    CodModelo = "MODELO002",
                    CodSubModelo = "SUBMODELO002",
                    NomMarca = "Marca2",
                    NomModelo = "Modelo2",
                    NomSubModelo = "SubModelo2",
                    TxtModelo = "Descripción del modelo 2",
                    ValVehiculo = 30000.75m,
                    CodUsoVehi = "Uso2",
                    AnioFab = 2022,
                    NumMatricula = "XYZ789",
                    NumSerie = "SER456",
                    NumMotor = "MOT456",
                    CodTipVehi = "TIP002",
                    NumOcupantes = 4,
                    CodColor = "COL002",
                    TxtColor = "Azul",
                    McaTimonCambiado = "N",
                    McaGPS = "S",
                    McaSistemaGas = "S",
                    ValTasaCanal = 4.25m,
                    ImpGrossUp = 600.50m,
                    NumCertificadoSOAT = "CERT456",
                    ImpPrimaTecnicaCanal = 1800.75m,
                    ImpPrimaNetaCanal = 1500.25m,
                    TxtObservacion = "Observaciones adicionales 2",
                    TipDocumAsegurado = "RUC",
                    CodDocumAsegurado = "98765432100",
                    NomAsegurado = "María",
                    Ape1Asegurado = "García",
                    Ape2Asegurado = "López",
                    FecNacimientoAseg = new DateTime(1990, 10, 20),
                    McaSexoAseg = "0",
                    CodEstCivilAseg = "C",
                    PctDctoComCanal = 12.75m,
                    ImpDctoComCanal = 300.25m,
                    CodEstadoAseg = 2,
                    CodProvAseg = 2,
                    CodLocalidadAseg = 2,
                    NomDireccionAseg = "Av. Libertad 456",
                    NumTelfFijo = "987654321",
                    NumTelfMovil = "123456789",
                    TxtEmail = "maria.garcia@example.com",
                    Fecha = DateTime.Now.AddDays(-1)
                }
                
            };
        }
    }
}