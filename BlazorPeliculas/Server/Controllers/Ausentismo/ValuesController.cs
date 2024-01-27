using BlazorPeliculas.Shared;
using BlazorPeliculas.Shared.Entidades.Ausentismo;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorPeliculas.Server.Controllers.Ausentismo
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Pendiente", "Rechazado", "Aprobado"
        };

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<HistorialPermisoModel> Get()
        {
            return Enumerable.Range(1, 50).Select(index => new HistorialPermisoModel
            {
                Estado = Summaries[Random.Shared.Next(Summaries.Length)],
                Descripcion = $"Descripción {Summaries[Random.Shared.Next(Summaries.Length)]}",
                Desde = DateTime.Now.AddDays(index),
                Hasta = DateTime.Now.AddDays(Random.Shared.Next(1, 10)),
                Hora = Random.Shared.Next(1, 10),
            })
            .OrderBy(x => x.Desde);
        }
    }
}
