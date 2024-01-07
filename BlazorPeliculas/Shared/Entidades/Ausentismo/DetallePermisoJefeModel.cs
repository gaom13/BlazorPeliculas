using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPeliculas.Shared.Entidades.Ausentismo
{
    public class DetallePermisoJefeModel
    {
        public string JeapNombre { get; set; }
        public string CoitColor { get; set; }
        public string EstadoNombre { get; set; } = "Pendiente";
        public bool Estado { get; set; } = false;

    }
}
