using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.JSInterop;
using MudBlazor;
using System;
using System.Globalization;
using System.Threading.Tasks;

namespace Server.Pages.Pages.Reportes
{
    public partial class Reportes 
    {
        private DateTime? fechaInicio = DateTime.Today;
        private DateTime? fechaFin = DateTime.Today;
        private bool isDialogOpen = false;
        private DateRange dateRange;
        private DateTime? SelectedDate;

        private void CloseDialog()
        {
            isDialogOpen = false;
        }


        public void OpenDialog()
        {
            var options = new DialogOptions { CloseButton = true, MaxWidth = MaxWidth.Small, FullWidth = true };
            DialogService.Show<DialogReportes>("Formulario 1", options);
        }
        protected async Task Reporte()
        {
            if (!fechaInicio.HasValue || !fechaFin.HasValue)
            {

                return;
            }

            string fechaInicioStr = fechaInicio.Value.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture);
            string fechaFinStr = fechaFin.Value.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture);


            await JSRuntime.InvokeVoidAsync("CargaReportePdf",
            new
            {
                ruta = "/reports/ENVIBOL/PRODUCCION/Almacen/Reporte_actual_dia",
                FechaInicio = fechaInicioStr,
                FechaFin = fechaFinStr
            });
        }

        protected async Task ReporteFormulario4()
        {
           
            if (SelectedDate.HasValue)
            {
                await JSRuntime.InvokeVoidAsync("CargaReportePop", new
                {
                    ruta = "/reports/ENVIBOL/PRODUCCION/Desarrollo/Conforme",
                    fechaFin = SelectedDate.Value.ToString("yyyy-MM-dd"),
                });
            }
            else
            {



            }
        }

        protected async Task ReporteConformes()
        {
            await JSRuntime.InvokeVoidAsync("CargaReportePdf",
            new
            {
                ruta = "/reports/ENVIBOL/PRODUCCION/Desarrollo/Totalconforme",

            });
        }
    }
}
