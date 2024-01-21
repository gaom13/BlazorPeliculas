using BlazorPeliculas.Shared.Entidades.Ausentismo;
using System;

namespace BlazorPeliculas.Client.Pages
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public string Text { get; set; } = null!;
        public string Dependencia { get; set; }
        public string Motivo { get; set; }
        public string Justificacion { get; set; }
        public List<DetallePermisoJefeModel> PermisoJefeModel { get; set; }
    }
}