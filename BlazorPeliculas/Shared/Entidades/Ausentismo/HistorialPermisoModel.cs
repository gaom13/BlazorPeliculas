using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPeliculas.Shared.Entidades.Ausentismo
{
    public class HistorialPermisoModel
    {
        public string Estado { get; set; }
        public string Descripcion { get; set; }
        public DateOnly Desde { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public DateOnly Hasta { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public int Hora { get; set; }
    }
}
