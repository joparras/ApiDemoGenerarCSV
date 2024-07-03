using GTPA.Business.Models.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace ApiTramasGTPA.Controllers.Tramas
{
    public class TramaRequest
    {
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public TipoLote tipoLote { get; set; }
    }
}
