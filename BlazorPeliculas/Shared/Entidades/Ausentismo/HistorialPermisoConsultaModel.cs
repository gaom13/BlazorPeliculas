using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPeliculas.Shared.Entidades.Ausentismo
{
    public class HistorialPermisoConsultaModel
    {
        public string PgId { get; set; }
        public DateTime Desde { get; set; } = DateTime.Now;
        public DateTime Hasta { get; set; } = DateTime.Now;
    }
}
