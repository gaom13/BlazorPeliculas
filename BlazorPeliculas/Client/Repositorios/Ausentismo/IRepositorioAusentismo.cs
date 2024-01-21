using BlazorPeliculas.Client.Pages;

namespace BlazorPeliculas.Client.Repositorios.Ausentismo
{
    public interface IRepositorioAusentismo
    {
        IList<Appointment> ObtenerPermisos();
    }
}
