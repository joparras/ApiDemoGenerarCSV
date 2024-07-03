using System.ComponentModel;
using System.Runtime.Serialization;

namespace GTPA.Business.Models.Enums
{
    public enum TipoLote
    {
        [EnumMember(Value = "Automovil")]
        Automovil = 0,
        [EnumMember(Value = "Sepelio")]
        Sepelio = 1
    }
}
