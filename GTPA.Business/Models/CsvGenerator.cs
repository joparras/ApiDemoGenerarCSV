using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTPA.Business.Models.TramaAutomovil;

namespace GTPA.Business.Models
{
    public static class CsvGenerator
    {
        public static byte[] GenerateCsv(List<DetalleRiesgosAutomoviles> data)
        {
            // Crear una cadena de texto para el contenido del CSV
            StringBuilder sb = new StringBuilder();

            // Agregar encabezados
            sb.AppendLine("COD_CIA,NUM_POLIZA_GRUPO,TIP_MOVIMIENTO,NUM_UNICO_ITEM,NUM_RIESGO,COD_PLAN,TIP_CODIFICACION,COD_MARCA,COD_MODELO,COD_SUB_MODELO,NOM_MARCA,NOM_MODELO,NOM_SUB_MODELO,TXT_MODELO,VAL_VEHICULO,COD_USO_VEHI,ANIO_FAB,NUM_MATRICULA,NUM_SERIE,NUM_MOTOR,COD_TIP_VEHI,NUM_OCUPANTES,COD_COLOR,TXT_COLOR,MCA_TIMON_CAMBIADO,MCA_GPS,MCA_SISTEMA_GAS,VAL_TASA_CANAL,IMP_GROSS_UP,NUM_CERTIFICADO_SOAT,IMP_PRIMA_TECNICA_CANAL,IMP_PRIMA_NETA_CANAL,TXT_OBSERVACION,TIP_DOCUM_ASEGURADO,COD_DOCUM_ASEGURADO,NOM_ASEGURADO,APE1_ASEGURADO,APE2_ASEGURADO,FEC_NACIMIENTO_ASEG,MCA_SEXO_ASEG,COD_EST_CIVIL_ASEG,PCT_DCTO_COM_CANAL,IMP_DCTO_COM_CANAL,COD_ESTADO_ASEG,COD_PROV_ASEG,COD_LOCALIDAD_ASEG,NOM_DIRECCION_ASEG,NUM_TELF_FIJO,NUM_TELF_MOVIL,TXT_EMAIL");

            // Agregar datos
            foreach (var item in data)
            {
                sb.AppendLine($"{item.CodCia},{item.NumPolizaGrupo},{item.TipMovimiento},{item.NumUnicoItem},{item.NumRiesgo},{item.CodPlan},{item.TipCodificacion},{item.CodMarca},{item.CodModelo},{item.CodSubModelo},{item.NomMarca},{item.NomModelo},{item.NomSubModelo},{item.TxtModelo},{item.ValVehiculo},{item.CodUsoVehi},{item.AnioFab},{item.NumMatricula},{item.NumSerie},{item.NumMotor},{item.CodTipVehi},{item.NumOcupantes},{item.CodColor},{item.TxtColor},{item.McaTimonCambiado},{item.McaGPS},{item.McaSistemaGas},{item.ValTasaCanal},{item.ImpGrossUp},{item.NumCertificadoSOAT},{item.ImpPrimaTecnicaCanal},{item.ImpPrimaNetaCanal},{item.TxtObservacion},{item.TipDocumAsegurado},{item.CodDocumAsegurado},{item.NomAsegurado},{item.Ape1Asegurado},{item.Ape2Asegurado},{item.FecNacimientoAseg},{item.McaSexoAseg},{item.CodEstCivilAseg},{item.PctDctoComCanal},{item.ImpDctoComCanal},{item.CodEstadoAseg},{item.CodProvAseg},{item.CodLocalidadAseg},{item.NomDireccionAseg},{item.NumTelfFijo},{item.NumTelfMovil},{item.TxtEmail}");
            }

            // Convertir la cadena de texto a bytes (UTF-8) para el archivo CSV
            byte[] csvBytes = Encoding.UTF8.GetBytes(sb.ToString());

            return csvBytes;
        }
    }
}
