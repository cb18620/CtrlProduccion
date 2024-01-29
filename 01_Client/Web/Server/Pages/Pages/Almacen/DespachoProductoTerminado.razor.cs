using Infraestructura.Abstract;
using Infraestructura.Component;
using Infraestructura.Models.Almacen;
using Infraestructura.Models.Transporte;
using Infraestructura.Models.Clasificador;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.JSInterop;
using Syncfusion.Blazor.Lists;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Infraestructura.Models.Empresas;

namespace Server.Pages.Pages.Almacen
{
    public partial class DespachoProductoTerminado
    {
        public AlmSalidadespachoDto _almsalidadespachonuevo = new AlmSalidadespachoDto();
        public DespachoDto _almsalidadespachopos = new DespachoDto();
        public List<AlmSalidadespachoDto> AlmSalidaDespachoListaTabla { get; set; }
        public static List <TransporteDto> TransporteList {  get; set; }
        public string jsonTransporteList { get; set; }
        public List<EmpresaDto> EmpresaList { get; set; }
        public string JsonEmpresaList { get; set; }

        private bool dense = true;
        private bool hover = true;
        private bool ronly = true;
        bool fixed_header = true;
        bool fixed_footer = false;
        private bool striped = true;
        private bool bordered = true;
        private bool visible;
        DateTime? date = DateTime.Today;
        void Submit() => visible = false;
        private void OpenDialog() => visible = true;
        protected IJSRuntime JsRuntime { get; set; }
        public bool documento { get; set; } = true;
        private string searchString = "";
        private string ordenProduccionSearchString = "";
 


        private bool popupAdmView { get; set; } = false;
        private async Task OnValidAsyncDespacho(EditContext context)
        {
            await SaveDespacho();
            Console.WriteLine("OnValidAMedidaNuevo");

        }
        protected override async Task OnInitializedAsync()
        {
            var tasks = new List<Task>
             {
                onTablaAsyncCabeceraPallet(),
                GetTransporteo(),
                GetEmpresas(),

        };

            await Task.WhenAll(tasks);
        }

        protected async Task GetTransporteo()
        {
            try
            {

                _Loading.Show();
                var _result = await _Rest.GetAsync<List<TransporteDto>>("Transporte/GetTransporte");
                _Loading.Hide();
                //_MessageShow(_result.Message, _result.State);
                if (_result.State != State.Success)
                    return;
                TransporteList = _result.Data;
                jsonTransporteList = JsonSerializer.Serialize(TransporteList);
            }
            catch (Exception e)
            {
                _MessageShow(e.Message, State.Error);
            }
        }



        protected async Task GetEmpresas()
        {
            try
            {
                _Loading.Show();
                var result = await _Rest.GetAsync<List<EmpresaDto>>("Empresa/Empresa");
                _Loading.Hide();

                if (result.Succeeded)
                {
                    EmpresaList = result.Data;
                    JsonEmpresaList = JsonSerializer.Serialize(EmpresaList);
                }
                else
                {
                    // Manejar el caso de error
                    _MessageShow(result.Message, State.Error);
                }
            }
            catch (Exception e)
            {
                _MessageShow(e.Message, State.Error);
            }
        }

        protected async Task SaveDespacho()
        {
            try
            {
                _Loading.Show();
                Console.WriteLine(JsonSerializer.Serialize(_almsalidadespachopos));

                var vrespost = await _Rest.PostAsync<int?>("AlmSalidadespacho/PosDespacho", new { _DespachoPallets = _almsalidadespachopos });
                _MessageShow(vrespost.Message, vrespost.State);

                if (vrespost.State != State.Success)
                {
                    vrespost.Errors.ForEach(x =>
                    {
                        _MessageShow(x, State.Warning);
                    });
                    return;
                }
                _Loading.Hide();
                await onTablaAsyncCabeceraPallet();
                _almsalidadespachopos = new DespachoDto();
                _MessageShow("<b> agregado correctamente</b>", State.Success);
            }
            catch (Exception e)
            {
                _Loading.Hide();
                _MessageShow(e.Message, State.Error);
            }
        }
        protected async Task onTablaAsyncCabeceraPallet()
        {
            try
            {
                _Loading.Show();
                var _result = await _Rest.GetAsync<List<AlmSalidadespachoDto>>("AlmSalidadespacho/AlmSalidadespacho");
                _Loading.Hide();
                if (_result.State != State.Success)
                {
                    _DialogShow(_result.Message, _result.State);
                }
                AlmSalidaDespachoListaTabla = _result.Data;
            }
            catch (Exception e)
            {
                _MessageShow(e.Message, State.Error);
            }
        }


    }
}
