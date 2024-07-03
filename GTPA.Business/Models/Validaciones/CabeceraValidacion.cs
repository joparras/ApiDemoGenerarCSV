using FluentValidation;
using GTPA.Business.Models.Genericos;

namespace GTPA.Business.Models.Validaciones
{
    public class CabeceraValidacion : AbstractValidator<Cabecera>
    {
        public CabeceraValidacion()
        {
            RuleFor(c => c.TipoTrama)
                .NotEmpty().WithMessage("TIP_TRAMA es requerido")
                .Length(1, 4).WithMessage("TIP_TRAMA debe tener una longitud máxima de 4 caracteres");

            RuleFor(c => c.MarcaEmision)
                .NotEmpty().WithMessage("MCA_EMIS_MAPFRE es requerido")
                .Must(value => value == "S" || value == "N").WithMessage("MCA_EMIS_MAPFRE debe ser 'S' o 'N'");

            RuleFor(c => c.FechaLote)
                .NotEmpty().WithMessage("FEC_LOTE es requerido")
                .Matches(@"^\d{8}$").WithMessage("FEC_LOTE debe tener el formato AAAAMMDD");

            RuleFor(c => c.NumeroLote)
                .GreaterThan(0).WithMessage("NUM_LOTE debe ser un número positivo");

            RuleFor(c => c.NumeroRegistros)
                .GreaterThanOrEqualTo(0).WithMessage("NRO_REGISTROS debe ser un número positivo");

            RuleFor(c => c.NumeroAltas)
                .GreaterThanOrEqualTo(0).WithMessage("NRO_ALTAS debe ser un número positivo");

            RuleFor(c => c.NumeroBajas)
                .GreaterThanOrEqualTo(0).WithMessage("NRO_BAJAS debe ser un número positivo");

            RuleFor(c => c.NumeroCambios)
                .GreaterThanOrEqualTo(0).WithMessage("NRO_CAMBIOS debe ser un número positivo");

            RuleFor(c => c.NumeroRehabilitados)
                .GreaterThanOrEqualTo(0).WithMessage("NRO_REHABILITADOS debe ser un número positivo");
        }
    }
}
