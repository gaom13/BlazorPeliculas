function pruebaPuntoNetStatic(){
    DotNet.invokeMethodAsync("BlazorPeliculas.Client","ObtenerCurrentCount")
    .then(resultado => {
        console.log('Conteo desde JavaScript', resultado);
    });
}