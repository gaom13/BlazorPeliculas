namespace BlazorPeliculas.Client
{
    // El valor mantiene vigente para la sesión del Usuario.
    public class ServiciosSingleton
    {
        public int Valor { get; set; }
    }

    //Va a hacer ser diferente siempre y cuando el usuario salga y entre al componente.
    public class ServiciosTransient
    {
        public int Valor { get; set; }
    }
}