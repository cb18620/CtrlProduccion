using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.JSInterop;
using MudBlazor;
using System.Threading.Tasks;
using System;

namespace Server.Pages.Pages.Reportes
{
    public partial class DialogReportes
    {

        private DateRange dateRange;
        private int filtroOpcion = 65;

        [CascadingParameter] MudDialogInstance MudDialogInstance { get; set; }


        private void Cancel()
        {
            Console.WriteLine("Cancelar presionado");
            MudDialogInstance.Cancel();
        }

        protected async Task Reporte()
        {
            if (dateRange.Start == null || dateRange.End == null)
            {
                Console.WriteLine("Fechas de inicio y fin son requeridas");
                return;
            }
            if (dateRange.Start > dateRange.End)
            {
                Console.WriteLine("La fecha de inicio debe ser anterior a la fecha de fin");
                return;
            }

            await JSRuntime.InvokeVoidAsync("CargaReportePop",
            new
            {
                ruta = "/reports/ENVIBOL/PRODUCCION/Desarrollo/Formulario1",
                fechaInicio = dateRange.Start.Value.ToString("yyy-MM-dd"),
                fechaFin = dateRange.End.Value.ToString("yyy-MM-dd"),
                filtroOpcion = filtroOpcion,
            });
        }


    }
}
