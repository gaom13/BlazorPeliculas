using BlazorPeliculas.Shared.Entidades.Ausentismo;
using CurrieTechnologies.Razor.SweetAlert2;

namespace BlazorPeliculas.Client.Utilidades
{
    public class SweetAlertServiceUtilidad
    {
        private readonly SweetAlertService _sweetAlertService;

        public SweetAlertServiceUtilidad(SweetAlertService sweetAlertService)
        {
            _sweetAlertService = sweetAlertService;
        }
        public async Task<bool> Confirmacion(string title, string body)
        {
            var resultado = await _sweetAlertService.FireAsync(new SweetAlertOptions
            {
                Title = title,
                Text = body,
                Icon = SweetAlertIcon.Warning,
                ShowCancelButton = true
            });

            return !string.IsNullOrEmpty(resultado.Value);
        }
    }
}
