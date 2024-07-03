using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTPA.Business.Models.TramaSepelio
{
    public class DetalleRiesgosSepelios
    {
        public string CodCia { get; set; }
        public string NumPolizaGrupo { get; set; } 
        public string TipMovimiento { get; set; }
        public string NumUnicoItem { get; set; }
        public string NumRiesgo { get; set; }
        public string CodPlan { get; set; }
        public string McaMancomunado { get; set; }
        public string CodParentesco { get; set; } 
        public string TipDocumTitular { get; set; } 
        public string CodDocumTitular { get; set; } 
        public string TipDocumAsegurado { get; set; } 
        public string CodDocumAsegurado { get; set; } 
        public string NombreAsegurado { get; set; } 
        public string ApellidoPaternoAsegurado { get; set; } 
        public string ApellidoMaternoAsegurado { get; set; } 
        public DateTime FecNacimiento { get; set; } 
        public char McaSexo { get; set; }
        public char CodEstCivil { get; set; } 
        public int NumMesesFto { get; set; } 
        public int NumeroAsegurados { get; set; }
        public decimal ImpCredito { get; set; } 
        public DateTime FecDesembolso { get; set; } 
        public decimal ImpSaldoCredito { get; set; } 
        public decimal ImpSueldoBruto { get; set; } 
        public decimal ValTasaRiesgo { get; set; } 
        public decimal ImpPrimaTecnicaCanal { get; set; }
        
        [NotMapped]  //no se mapea 
        public DateTime Fecha { get; set; }
        [NotMapped]
        public string TipoTrama { get; set; }
    }
}
