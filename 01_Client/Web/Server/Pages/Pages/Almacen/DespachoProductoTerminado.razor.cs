using Infraestructura.Abstract;
using Infraestructura.Component;
using Infraestructura.Models.Almacen;
using Infraestructura.Models.Transporte;
using Infraestructura.Models.Clasificador;
using Microsoft.AspNetCore.Components.Forms;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.JSInterop;
using Syncfusion.Blazor.Lists;
using System;
using System.Collections.Generic;
using MudBlazor;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Infraestructura.Models.Empresas;
using Dominio.Entities.Almacen;


namespace Server.Pages.Pages.Almacen
{
    public partial class DespachoProductoTerminado
    {
        private HashSet<VpalletalmacenDto> selectedItems1 = new HashSet<VpalletalmacenDto>();
        //private HashSet<VpalletalmacendDto> selectedItems2 = new HashSet<VpalletalmacendDto>();
        private List<VpalletalmacenDto> Palletalmacen = new List<VpalletalmacenDto>();
        private List<VpalletalmacenDto> Palletalmacenn { get; set; }
        public AlmSalidadespachoDto _almsalidadespachonuevo = new AlmSalidadespachoDto();
        public DespachoDto _almsalidadespachopos = new DespachoDto();
        public List<AlmSalidadespachoDto> AlmSalidaDespachoListaTabla { get; set; }
        public static List<TransporteDto> TransporteList { get; set; }
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



        //AGREGAR EL DETALLE

        private static List<AlmSalidadespachodetalleDto> AlmSalidadespachodetalle { get; set; }


        public AlmSalidadespachodetalleDto _AlmSalidadespachodetalleNuevo = new AlmSalidadespachodetalleDto();
        string _TituloPopup; string _TituloPopup1; int _TituloPopup2;
        private bool popupAdmViewPallets { get; set; } = false;

       
        private HashSet<AlmSalidadespachodetalleDto> selectedItems2 = new HashSet<AlmSalidadespachodetalleDto>();
        protected void OpenDialog1(int v_IdEmpresa)
        {
            var vAfiliacion = AlmSalidaDespachoListaTabla.First(f => f.IdalmSalidadespacho == v_IdEmpresa);
            //vAfiliacion.VerDetalle = !vAfiliacion.VerDetalle;
            _TituloPopup = vAfiliacion.IdalmSalidadespacho.ToString();
            //this.popupAdmViewExtractoVerificados = true;

        }
        protected async Task onTablaAsyncPallets(int idorden)
        {
            try
            {
                _Loading.Show();
                var _result = await _Rest.GetAsync<List<AlmSalidadespachodetalleDto>>($"AlmSalidadespachodetalle/palletalmacen/{idorden}");
                _Loading.Hide();
                if (_result.State != State.Success)
                {
                    _DialogShow(_result.Message, _result.State);
                }
                AlmSalidadespachodetalle = _result.Data;
            }
            catch (Exception e)
            {
                _MessageShow(e.Message, State.Error);
            }
        }
        protected async void ShowBtnadd(int v_IdEmpresa)
        {
            var vAfiliacion = AlmSalidaDespachoListaTabla.First(f => f.IdalmSalidadespacho == v_IdEmpresa);

            _TituloPopup = "REGISTRO - DETALLE DE SALIDA DE PALLETS DE ALMACEN DE PT";
            _TituloPopup1 = "PALLETS ASIGNADOS";
            // _TituloPopup = vAfiliacion.IdalmSalidadespacho.ToString();
            // vAfiliacion.VerDetalle = !vAfiliacion.VerDetalle;
            await onTablaAsyncPallets(vAfiliacion.IdalmSalidadespacho);
            _TituloPopup2 = vAfiliacion.IdalmSalidadespacho;
            this.popupAdmViewPallets = true;
        }
        protected async Task btnCancelPop()
        {
           this.popupAdmViewPallets = false;
        }

        protected async Task btnSelecEliminarDetalle()

        {
           
        }

        protected async Task btnSelecGuardarDetalle()
        {




            String valores = (selectedItems1 == null ? "" : string.Join(", ", selectedItems1.Select(x => x.IdAlmContenidoPallets)));
            String[] arreglo = valores.Split(',');



            _AlmSalidadespachodetalleNuevo.IdalmSalidadespacho = _TituloPopup2;
            _AlmSalidadespachodetalleNuevo.IdalmSalidadespachodetalle = 0;
            _Loading.Show();
            foreach (var l in arreglo)
            {
                int price = Int32.Parse(l);
                _AlmSalidadespachodetalleNuevo.NumeroPallet = Int32.Parse(l);
                var s = Palletalmacen.Where(x => x.IdAlmContenidoPallets == price).ToList();
                _AlmSalidadespachodetalleNuevo.CantidadBotellasSalida = s[0].CantidadBotellasSalida;
                try
                {

                    var vrespost = await _Rest.PostAsync<int?>("AlmSalidadespachodetalle", new { _AlmSalidadespachodetalle = _AlmSalidadespachodetalleNuevo });

                    _MessageShow(vrespost.Message, vrespost.State);

                    if (vrespost.State != State.Success)
                    {
                        vrespost.Errors.ForEach(x =>
                        {
                            _MessageShow(x, State.Warning);
                        });
                        return;
                    }

                    // _navMgr.NavigateTo("/Afiliacion/Empresas", true);
                }
                catch (Exception e)
                {
                    _Loading.Hide();
                    _MessageShow(e.Message, State.Error);
                }


            }


            //await onTablaAlmacenV();
            await onTablaAlmacenV();
            StateHasChanged();
            StateHasChanged();
            HashSet<VpalletalmacenDto> selectedItems1clear = new HashSet<VpalletalmacenDto>();
            selectedItems1 = selectedItems1clear;
            _Loading.Hide();

        }

        protected async Task onTablaAlmacenV()
        {
            try
            {
                _Loading.Show();
                var _result = await _Rest.GetAsync<List<VpalletalmacenDto>>("AlmSalidadespachodetalle/Vpalletalmacen");
                _Loading.Hide();

                if (_result.State != State.Success)
                {
                    _DialogShow(_result.Message, _result.State);
                    return; // Detiene la ejecución si el estado no es exitoso
                }

                Palletalmacen = _result.Data;
                StateHasChanged();
            }
            catch (HttpRequestException httpEx)
            {
                // Captura errores específicos de las solicitudes HTTP
                _MessageShow("Error de solicitud HTTP: " + httpEx.Message, State.Error);
            }
            catch (JsonException jsonEx)
            {
                // Captura errores de deserialización JSON
                _MessageShow("Error de procesamiento JSON: " + jsonEx.Message, State.Error);
            }
            catch (Exception e)
            {
                // Captura cualquier otro tipo de error general
                _MessageShow("Error: " + e.Message, State.Error);
            }
            finally
            {
                // Asegura que _Loading.Hide() se ejecute siempre, incluso si hay un error
                _Loading.Hide();
            }
        }



    }
}
