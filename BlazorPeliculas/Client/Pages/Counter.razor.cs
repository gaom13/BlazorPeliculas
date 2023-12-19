using BlazorPeliculas.Client.Helpers;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using CurrieTechnologies.Razor.SweetAlert2;

namespace BlazorPeliculas.Client.Pages
{
    public partial class Counter
    {
        [Inject] ServiciosSingleton singleton { get; set; } = null!;
        [Inject] ServiciosTransient transient { get; set; } = null!;
        [Inject] IJSRuntime js { get; set; } = null!;
        [Inject] SweetAlertService swal { get; set; } = null!;
        //Recibiendo el parámetro del padre
        //[CascadingParameter(Name = "Color")] protected string Color { get; set; } = null!;
        //[CascadingParameter(Name = "Size")] protected string Size { get; set; } = null!;
        [CascadingParameter] protected AppState appState { get; set; } = null!;

        IJSObjectReference? modulo;


        private int currentCount = 0;
        private static int currentCountStatic = 0;

        [JSInvokable]
        public async Task IncrementCount()
        {
            modulo = await js.InvokeAsync<IJSObjectReference>("import", "./js/Counter.js");
            await swal.FireAsync("Hola Mundo");

            currentCount++;
            currentCountStatic = currentCount;
            singleton.Valor = currentCount;
            transient.Valor = currentCount;
            await js.InvokeVoidAsync("pruebaPuntoNetStatic");
        }

        private async Task IncrementCountJavaScript(){
            await js.InvokeVoidAsync("pruebaPuntoNetInstancia",DotNetObjectReference.Create(this));
        }

        [JSInvokable]
        public static Task<int> ObtenerCurrentCount(){
            return Task.FromResult(currentCountStatic); 
        }
    }
}