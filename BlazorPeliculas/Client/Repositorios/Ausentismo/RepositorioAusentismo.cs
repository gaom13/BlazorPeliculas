using BlazorPeliculas.Client.Pages;
using BlazorPeliculas.Shared.Entidades.Ausentismo;

namespace BlazorPeliculas.Client.Repositorios.Ausentismo
{
    public class RepositorioAusentismo : IRepositorioAusentismo
    {
        public IList<Appointment> ObtenerPermisos()
        {
            return new List<Appointment>
    {
        new Appointment {
            Start = DateTime.Today.AddDays(-2),
            End = DateTime.Today.AddDays(-2),
            Id = 1,
            Dependencia = "La mejor dependencia (OTI) presente",
            Text = "Birthday",
            Motivo = "La mejor dependencia (OTI) presente",
            PermisoJefeModel = new List<DetallePermisoJefeModel>
            {
                new DetallePermisoJefeModel {JeapNombre = "Jefe Inmediato", CoitColor = "#34AB1E", Estado = false, EstadoNombre="Pendiente"},
                new DetallePermisoJefeModel {JeapNombre = "Jefe Div. Serv. Adtivos", CoitColor = "#34AB1E", Estado = false, EstadoNombre="Pendiente"},
                new DetallePermisoJefeModel {JeapNombre = "...", CoitColor = "#34AB1E"},
            }
        },
        new Appointment {
            Start = DateTime.Today.AddDays(-11),
            End = DateTime.Today.AddDays(-10),
            Text = "Day off",
            Dependencia = "La mejor dependencia (OTI) presente",
            Motivo = "La mejor dependencia (OTI) presente",
            PermisoJefeModel = new List<DetallePermisoJefeModel>
            {
                new DetallePermisoJefeModel {JeapNombre = "Jefe Inmediato", CoitColor = "#34AB1E", Estado = true, EstadoNombre="Aprobado"},
                new DetallePermisoJefeModel {JeapNombre = "Jefe Div. Serv. Adtivos", CoitColor = "#34AB1E", Estado = true, EstadoNombre="Rechazado"},
                new DetallePermisoJefeModel {JeapNombre = "...", CoitColor = "#34AB1E"},
            }
        },
        new Appointment {
            Start = DateTime.Today.AddDays(-10),
            End = DateTime.Today.AddDays(-8),
            Text = "Work from home",
            Dependencia = "La mejor dependencia (OTI) presente",
            Motivo = "La mejor dependencia (OTI) presente",
            PermisoJefeModel = new List<DetallePermisoJefeModel>
            {
                new DetallePermisoJefeModel {JeapNombre = "Jefe Inmediato", CoitColor = "#34AB1E", Estado = false, EstadoNombre="Pendiente"},
                new DetallePermisoJefeModel {JeapNombre = "Jefe Div. Serv. Adtivos", CoitColor = "#34AB1E", Estado = false, EstadoNombre="Pendiente"},
                new DetallePermisoJefeModel {JeapNombre = "...", CoitColor = "#34AB1E"},
            }
        },
        new Appointment {
            Start = DateTime.Today.AddHours(10),
            End = DateTime.Today.AddHours(12),
            Text = "Online meeting",
            Dependencia = "La mejor dependencia (OTI) presente",
            Motivo = "La mejor dependencia (OTI) presente",
            PermisoJefeModel = new List<DetallePermisoJefeModel>
            {
                new DetallePermisoJefeModel {JeapNombre = "Jefe Inmediato", CoitColor = "#34AB1E", Estado = false, EstadoNombre="Pendiente"},
                new DetallePermisoJefeModel {JeapNombre = "Jefe Div. Serv. Adtivos", CoitColor = "#34AB1E", Estado = false, EstadoNombre="Pendiente"},
                new DetallePermisoJefeModel {JeapNombre = "...", CoitColor = "#34AB1E"},
            }

        },
        new Appointment {
            Start = DateTime.Today.AddHours(10),
            End = DateTime.Today.AddHours(13),
            Text = "Skype call",
            Dependencia = "La mejor dependencia (OTI) presente",
            Motivo = "La mejor dependencia (OTI) presente",
            PermisoJefeModel = new List<DetallePermisoJefeModel>
            {
                new DetallePermisoJefeModel {JeapNombre = "Jefe Inmediato", CoitColor = "#34AB1E", Estado = true, EstadoNombre="Aprobado"},
                new DetallePermisoJefeModel {JeapNombre = "Jefe Div. Serv. Adtivos", CoitColor = "#34AB1E", Estado = true, EstadoNombre="Rechazado"},
                new DetallePermisoJefeModel {JeapNombre = "...", CoitColor = "#34AB1E"},
            }
        },
        new Appointment {
            Start = DateTime.Today.AddHours(14),
            End = DateTime.Today.AddHours(14).AddMinutes(30),
            Text = "Dentist appointment",
            Dependencia = "La mejor dependencia (OTI) presente",
            Motivo = "La mejor dependencia (OTI) presente",
            PermisoJefeModel = new List<DetallePermisoJefeModel>
            {
                new DetallePermisoJefeModel {JeapNombre = "Jefe Inmediato", CoitColor = "#34AB1E", Estado = true, EstadoNombre="Aprobado"},
                new DetallePermisoJefeModel {JeapNombre = "Jefe Div. Serv. Adtivos", CoitColor = "#34AB1E", Estado = true, EstadoNombre="Rechazado"},
                new DetallePermisoJefeModel {JeapNombre = "...", CoitColor = "#34AB1E"},
            }
        },
        new Appointment {
            Start = DateTime.Today.AddDays(1),
            End = DateTime.Today.AddDays(12),
            Text = "Vacation",
            Dependencia = "La mejor dependencia (OTI) presente",
            Motivo = "La mejor dependencia (OTI) presente",
            PermisoJefeModel = new List<DetallePermisoJefeModel>
            {
                new DetallePermisoJefeModel {JeapNombre = "Jefe Inmediato", CoitColor = "#34AB1E", Estado = true, EstadoNombre="Aprobado"},
                new DetallePermisoJefeModel {JeapNombre = "Jefe Div. Serv. Adtivos", CoitColor = "#34AB1E", Estado = true, EstadoNombre="Rechazado"},
                new DetallePermisoJefeModel {JeapNombre = "...", CoitColor = "#34AB1E"},
            }
        },
    };
        }
    }
}