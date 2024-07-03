using ApiTramasGTPA.Factory;
using Microsoft.AspNetCore.Mvc;

namespace ApiTramasGTPA.Controllers.Tramas
{
    [Route("api/[controller]")]
    [ApiController]
    public class TramasController: ControllerBase
    {
        private readonly TramaFactory _tramaFactory;

        public TramasController(TramaFactory tramaFactory) //inyeccion de independencias 
        {
            _tramaFactory = tramaFactory; 
        }

        [HttpPost("GenerarTrama")]
        public IActionResult GenerarTrama([FromBody]TramaRequest request)
        {
            var tramaService = _tramaFactory.GetTrama(request.tipoLote);
            var tramaResponse = tramaService.GenerarTrama(request.fechaInicio, request.fechaFin);

            // Devolver archivo CSV como respuesta
            MemoryStream ms = new MemoryStream(tramaResponse.File);
            return File(ms, "text/csv", tramaResponse.NombreArchivo);
        }
    }
}
