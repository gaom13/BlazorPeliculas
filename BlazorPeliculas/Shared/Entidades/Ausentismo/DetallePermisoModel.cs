using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPeliculas.Shared.Entidades.Ausentismo
{
    public class DetallePermisoModel
    {
        public int Id { get; set; }
        public string Dependencia { get; set; }
        public string Motivo { get; set; }
        public string Justificacion { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
    }
}
