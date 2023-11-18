using Blazored.FluentValidation;
using Infraestructura.Abstract;
using Infraestructura.Models.Authentication;
using Infraestructura.Models.Clasificador;
using Infraestructura.Models.Empresas;

using Microsoft.AspNetCore.Components.Forms;
using Microsoft.JSInterop;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text.Json;
using System.Threading.Tasks;

namespace Server.Pages.Pages.Afiliacion
{
    public partial class Empresas
    {
        private static List<EmpresaDto> Empresa { get; set; }
        public EmpresaDto _EmpresaNuevo = new EmpresaDto();
        private static List<GenClasificadorDto> EmpresaList { get; set; }
        public string jsonTipoEmpresa { get; set; }



        private bool visible;
        private int rating;
        private void OpenDialog() => visible = true;
        void Submit() => visible = false;

        private DialogOptions dialogOptions = new() { FullWidth = true };



        bool fixed_header = true;
        bool fixed_footer = false;

        private bool dense = true;
        private bool hover = true;
        private bool striped = true;
        private bool bordered = true;

        private string searchString = "";
        private string searchString1 = "";
        private bool FilterFunc1(EmpresaDto element) => FilterFunc(element, searchString);

        private bool FilterFunc(EmpresaDto element, string searchString1)
        {
            if (string.IsNullOrWhiteSpace(searchString1))
                return true;
            if (element.Nit.Contains(searchString1, StringComparison.OrdinalIgnoreCase))
                return true;
            if (element.NombreRepresentante.Contains(searchString1, StringComparison.OrdinalIgnoreCase))
                return true;
            if (element.RazonSocial.Contains(searchString1, StringComparison.OrdinalIgnoreCase))
                return true;
            if ($"{element.IdinsEmpresa}".Contains(searchString1))
                return true;
            return false;
        }

        protected override async void OnInitialized()
        {
            await onTablaAsyncEmpresa();
            await servicio();


        }

        private async Task OnValidEmpresaNuevo(EditContext context)
        {
            await SaveEmpresa();
            Console.WriteLine("OnValidAMedidaNuevo");
        }

        protected async Task SaveEmpresa()
        {
            try
            {
                _Loading.Show();
                var vrespost = await _Rest.PostAsync<int?>("Empresa", new { _Empresa = _EmpresaNuevo });
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
                await onTablaAsyncEmpresa();
            }
            catch (Exception e)
            {
                _Loading.Hide();
                _MessageShow(e.Message, State.Error);
            }
        }

        protected async Task onTablaAsyncEmpresa()
        {
            try
            {
                _Loading.Show();
                var _result = await _Rest.GetAsync<List<EmpresaDto>>("Empresa/Empresa");
                _Loading.Hide();
                if (_result.State != State.Success)
                {
                    _DialogShow(_result.Message, _result.State);
                }
                Empresa = _result.Data;
            }
            catch (Exception e)
            {
                _MessageShow(e.Message, State.Error);
            }
        }


        public async Task ShowBtnEliminaEmpresa(int idEmpresa)
        {


            await _MessageConfirm("Esta seguro de eliminar el registro...?", async () =>
            {
                var vrespost = await _Rest.DeleteAsync<int>("Empresa", idEmpresa);
                if (!vrespost.Succeeded)
                {
                    _MessageShow(vrespost.Message, State.Error);
                }
                else
                {
                    _MessageShow(vrespost.Message, vrespost.State);
                    //_RowIdsubPlanificaciondetalle = 0;
                    await onTablaAsyncEmpresa();
                    StateHasChanged();
                }
            });
        }


        protected async Task EditEmpresa(EmpresaDto DtoEmpresa)
        {
            try
            {
                _Loading.Show();
                var _update = await _Rest.PutAsync<int>("Empresa", DtoEmpresa, DtoEmpresa.IdinsEmpresa);
                if (_update.State == State.Success)
                {
                    _MessageShow(_update.Message, _update.State);
                    DtoEmpresa.IdinsEmpresa = _update.Data;
                    DtoEmpresa.VerDetalle = !DtoEmpresa.VerDetalle;
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


        protected void ShowBtnEdit(int v_IdEmpresa)
        {
            var vAfiliacion = Empresa.First(f => f.IdinsEmpresa == v_IdEmpresa);
            vAfiliacion.VerDetalle = !vAfiliacion.VerDetalle;
        }

        protected async void Reporte()
        {
            await JSRuntime.InvokeVoidAsync("CargaReportePop", new { ruta = "/reports/PAPELBOL/SIPRE/rptBoletaEntrega", pNotaingreso = 108 });
        }


        protected async Task servicio()
        {

        }
    }
}