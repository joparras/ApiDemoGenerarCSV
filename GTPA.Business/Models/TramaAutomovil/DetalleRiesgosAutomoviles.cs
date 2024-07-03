
using System.ComponentModel.DataAnnotations.Schema;

namespace GTPA.Business.Models.TramaAutomovil
{
    public class DetalleRiesgosAutomoviles
    {
        public string CodCia { get; set; }
        public string NumPolizaGrupo { get; set; }
        public string TipMovimiento { get; set; }
        public string NumUnicoItem { get; set; }
        public string NumRiesgo { get; set; }
        public string CodPlan { get; set; }
        public string TipCodificacion { get; set; }
        public string CodMarca { get; set; }
        public string CodModelo { get; set; }
        public string CodSubModelo { get; set; }
        public string NomMarca { get; set; }
        public string NomModelo { get; set; }
        public string NomSubModelo { get; set; }
        public string TxtModelo { get; set; }
        public decimal ValVehiculo { get; set; }
        public string CodUsoVehi { get; set; }
        public int AnioFab { get; set; }
        public string NumMatricula { get; set; }
        public string NumSerie { get; set; }
        public string NumMotor { get; set; }
        public string CodTipVehi { get; set; }
        public int NumOcupantes { get; set; }
        public string CodColor { get; set; }
        public string TxtColor { get; set; }
        public string McaTimonCambiado { get; set; }
        public string McaGPS { get; set; }
        public string McaSistemaGas { get; set; }
        public decimal ValTasaCanal { get; set; }
        public decimal ImpGrossUp { get; set; }
        public string NumCertificadoSOAT { get; set; }
        public decimal ImpPrimaTecnicaCanal { get; set; }
        public decimal ImpPrimaNetaCanal { get; set; }
        public string TxtObservacion { get; set; }
        public string TipDocumAsegurado { get; set; }
        public string CodDocumAsegurado { get; set; }
        public string NomAsegurado { get; set; }
        public string Ape1Asegurado { get; set; }
        public string Ape2Asegurado { get; set; }
        public DateTime FecNacimientoAseg { get; set; }
        public string McaSexoAseg { get; set; }
        public string CodEstCivilAseg { get; set; }
        public decimal PctDctoComCanal { get; set; }
        public decimal ImpDctoComCanal { get; set; }
        public int CodEstadoAseg { get; set; }
        public int CodProvAseg { get; set; }
        public int CodLocalidadAseg { get; set; }
        public string NomDireccionAseg { get; set; }
        public string NumTelfFijo { get; set; }
        public string NumTelfMovil { get; set; }
        public string TxtEmail { get; set; }

        [NotMapped]  //no se mapea 
        public DateTime Fecha { get; set; }
        [NotMapped]
        public string TipoTrama { get; set; }
    }
}
