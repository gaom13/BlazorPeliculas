using BlazorPeliculas.Shared.Entidades;
namespace BlazorPeliculas.Client.Repositorios
{
    class Repositorio : IRepositorio
    {
        public List<Pelicula> ObtenerPeliculas()
        {
            return new List<Pelicula>()
            {
                new Pelicula{
                    Titulo = "Wakanda Forever",
                    Lanzamiento = new DateTime(2023, 12, 1),
                    Poster = "https://m.media-amazon.com/images/W/MEDIAX_792452-T1/images/I/71cChJTTPaL._AC_SX679_.jpg"
                },
                new Pelicula{
                    Titulo = "Moana",
                    Lanzamiento = new DateTime(2016, 11, 11),
                    Poster = "https://m.media-amazon.com/images/W/MEDIAX_792452-T1/images/I/71cChJTTPaL._AC_SX679_.jpg"
                },
                new Pelicula{
                    Titulo = "Inception",
                    Lanzamiento = new DateTime(2010, 7, 16),
                    Poster = "https://m.media-amazon.com/images/W/MEDIAX_792452-T1/images/I/71cChJTTPaL._AC_SX679_.jpg"
                },
            };
        }
    }
}
