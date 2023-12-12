using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorPeliculas.Client.Pages
{
    public partial class Counter
    {
        [Inject] ServiciosSingleton singleton { get; set; } = null!;
        [Inject] ServiciosTransient transient { get; set; } = null!;
        [Inject] IJSRuntime js { get; set; } = null!;
        private int currentCount = 0;
        private static int currentCountStatic = 0;

        [JSInvokable]
        public async Task IncrementCount()
        {
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