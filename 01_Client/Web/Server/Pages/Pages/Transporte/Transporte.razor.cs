using Infraestructura.Abstract;
using Infraestructura.Models.Empresas;
using Infraestructura.Models.Transporte;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Pages.Pages.Transporte
{
    public partial class Transporte
    {

       
        private static List<TransporteDto> TransporteList { get; set; }
        public TransporteDto _TransporteNuevo = new TransporteDto();



        private bool dense = true;
        private bool hover = true;
        private bool striped = true;
        private bool bordered = true;

        private bool visible;
        void Submit() => visible = false;
        private void OpenDialog() => visible = true;

        private string searchString = "";


        private bool FilterFunc1(TransporteDto element) => FilterFunc(element, searchString);

        private bool FilterFunc(TransporteDto element, string searchString1)
        {
            if (string.IsNullOrWhiteSpace(searchString1))
                return true;
            if (element.Matricula.Contains(searchString1, StringComparison.OrdinalIgnoreCase))
                return true;
            if (element.Marca.Contains(searchString1, StringComparison.OrdinalIgnoreCase))
                return true;
            if (element.Color.Contains(searchString1, StringComparison.OrdinalIgnoreCase))
                return true;
            if ($"{element.IdinsTransporte}".Contains(searchString1))
                return true;
            return false;
        }

        private async Task OnValidTransporteNuevo(EditContext context)
        {
            await SaveTransporte();
            //Console.WriteLine("OnValidAMedidaNuevo");

        }
        protected override async void OnInitialized()
        {
            //await GetTipoEmpresa();
            await onTablaAsyncTransporte();
           
          
            //jsonTipoEmpresa = JsonSerializer.Serialize(EmpresaList);
        }

        protected async Task SaveTransporte()
        {
            try
            {
                _Loading.Show();
                var vrespost = await _Rest.PostAsync<int?>("_Transporte", new { _Transporte = _TransporteNuevo });
                _Loading.Hide();
                _MessageShow(vrespost.Message, vrespost.State);

                if (vrespost.State != State.Success)
                {
                    vrespost.Errors.ForEach(x =>
                    {
                        _MessageShow(x, State.Warning);
                    });
                    return;
                }
                await onTablaAsyncTransporte();
                //_navMgr.NavigateTo("/Afiliacion/Empresas", true);
            }
            catch (Exception e)
            {
                _Loading.Hide();
                _MessageShow(e.Message, State.Error);
            }
        }

        protected async Task onTablaAsyncTransporte()
        {
            try
            {
                _Loading.Show();
                var _result = await _Rest.GetAsync<List<TransporteDto>>("Transporte/GetTransporte");
                _Loading.Hide();
                if (_result.State != State.Success)
                {
                    _DialogShow(_result.Message, _result.State);
                }
                TransporteList = _result.Data;
            }
            catch (Exception e)
            {
                _MessageShow(e.Message, State.Error);
            }
        }


        protected void ShowBtnEdit(int v_IdTransporte)
        {
            var vAfiliacion = TransporteList.First(f => f.IdinsTransporte == v_IdTransporte);
            vAfiliacion.VerDetalle = !vAfiliacion.VerDetalle;
        }

        public async Task EliminaTransporte(int idTransporte)
        {


            await _MessageConfirm("Esta seguro de eliminar el registro...?", async () =>
            {
                var vrespost = await _Rest.DeleteAsync<int>("Transporte", idTransporte);
                if (!vrespost.Succeeded)
                {
                    _MessageShow(vrespost.Message, State.Error);
                }
                else
                {
                    _MessageShow(vrespost.Message, vrespost.State);
                    //_RowIdsubPlanificaciondetalle = 0;
                    await onTablaAsyncTransporte();
                    StateHasChanged();
                }
            });
        }


        protected async Task EditTrasporte(TransporteDto DtoTransporte)
        {
            try
            {
                _Loading.Show();
                var _update = await _Rest.PutAsync<int>("Transporte", DtoTransporte, DtoTransporte.IdinsTransporte);
                if (_update.State == State.Success)
                {
                    _MessageShow(_update.Message, _update.State);
                    DtoTransporte.IdinsTransporte = _update.Data;
                    DtoTransporte.VerDetalle = !DtoTransporte.VerDetalle;
                }
                else
                {
                    _MessageShow(_update.Message, _update.State);
                }
            }
            catch (Exception e)
            {
                _DialogShow(e.Message, State.Error);
            }
            finally
            {
                _Loading.Hide();
            }
        }


        protected async void EditCancelTransporte(int v_IdproMedida)
        {
            var vAfiliacion = TransporteList.First(f => f.IdinsTransporte == v_IdproMedida);
            vAfiliacion.VerDetalle = !vAfiliacion.VerDetalle;
        }



    }
}
