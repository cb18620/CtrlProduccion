using Infraestructura.Abstract;
using Infraestructura.Component;
using Infraestructura.Models.Almacen;
using Infraestructura.Models.Transporte;
using Infraestructura.Models.Vistas;
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
using static System.Net.WebRequestMethods;
using System.Text;
using System.Net.Http.Headers;



namespace Server.Pages.Pages.Almacen
{
    public partial class DespachoProductoTerminado
    {
        private HashSet<VpalletalmacenDto> selectedItems1 = new HashSet<VpalletalmacenDto>();
        //private HashSet<VpalletalmacendDto> selectedItems2 = new HashSet<VpalletalmacendDto>();
        private List<VpalletalmacenDto> VPalletalmacen = new List<VpalletalmacenDto>();
        private List<VpalletalmacenDto> Palletalmacenn { get; set; }

        private List<VpalletalmacendDto> Despachodetalledes { get; set; }
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
                onTablaAlmacenV(),

                onTablaAsync4(),
                onTablaAsync4des(),
        };

            await Task.WhenAll(tasks);
        }

        protected async Task onTablaAsync4()
        {
            try
            {
                _Loading.Show();
                var _result = await _Rest.GetAsync<List<VsolicitudescomercialDto>>("Despacho/Solicitud");
                _Loading.Hide();
                if (_result.State != State.Success)
                {
                    _DialogShow(_result.Message, _result.State);
                }
                AlmSalidadespacho = _result.Data.OrderByDescending(x => x.IdalmSalidadespacho).ToList();
            }
            catch (Exception e)
            {
                _MessageShow(e.Message, State.Error);
            }
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
                await onTablaAsync4();
                _almsalidadespachopos = new DespachoDto();
                _MessageShow("<b> agregado correctamente</b>", State.Success);
            }
            catch (Exception e)
            {
                _Loading.Hide();
                _MessageShow(e.Message, State.Error);
            }
        }
        protected async Task ShowBtnAprobar(int id)
        {
            try
            {
                var dtoAlmSalidadespacho = new AlmSalidadespachoDto
                {
                    IdalmSalidadespacho = id,
                    Estado = 1 // Establecemos el estado en 1 para "Aprobar"
                };

                var response = await _Rest.PutAsync<int>("AlmSalidadespacho", dtoAlmSalidadespacho, id);

                if (response.State == State.Success)
                {
                    _MessageShow("Se realizo el despacho correctamente", State.Success);
                    await onTablaAsync4();


                }
                else
                {
                    _MessageShow(response.Message, State.Error);
                }
            }
            catch (Exception e)
            {
                _MessageShow(e.Message, State.Error);
            }
        }


        protected async Task ShowBtnRechazarEliminar(int id)
        {
            try
            {
                _Loading.Show();

                // Encuentra el despacho a rechazar y eliminar
                var despacho = AlmSalidadespacho.First(f => f.IdalmSalidadespacho == id);
                await onTablaAsyncPalletsDes(despacho.IdalmSalidadespacho);

                string mess = "";
                foreach (var d in Despachodetalledes)
                {
                    var deleteResponse = await _Rest.DeleteAsync<int>("AlmSalidadespachodetalle", d.IdalmSalidadespachodetalle);
                    if (!deleteResponse.Succeeded)
                    {
                        _MessageShow(deleteResponse.Message, deleteResponse.State);
                    }
                    else
                    {
                        mess += deleteResponse.Data + ",";
                    }
                }

                // Después de eliminar los detalles, cambia el estado del despacho principal
                var updateObject = new
                {
                    DespachoPallets = new
                    {
                        idalmSalidadespacho = despacho.IdalmSalidadespacho,
                        estado = 2, // Asumiendo que 2 es un estado que representa "rechazado"
                        usuarioModificacion = "usuarioRechazo", // Reemplaza con el usuario actual
                        fechaModificacion = DateTime.Now
                    }
                };

                // Envía la solicitud de actualización
                var response = await _Rest.PostAsync<int?>("AlmSalidadespacho/PosDespacho", updateObject);

                if (response.State != State.Success)
                {
                    response.Errors?.ForEach(error =>
                    {
                        _MessageShow(error, State.Warning);
                    });
                }
                else
                {
                    _MessageShow("Despacho rechazado y detalles eliminados correctamente", State.Success);
                }

                await onTablaAsync4();
            }
            catch (Exception e)
            {
                _Loading.Hide();
                _MessageShow($"Error al rechazar y eliminar el despacho: {e.Message}", State.Error);
            }
            finally
            {
                _Loading.Hide();
            }
        }

        protected async Task ShowBtnRechazar(int id)
        {
            try
            {
                _Loading.Show();

                // Encuentra el despacho a rechazar
                var despacho = AlmSalidadespacho.First(f => f.IdalmSalidadespacho == id);

                // Crea el objeto para actualizar el estado a rechazado
                var updateObject = new
                {
                    DespachoPallets = new
                    {
                        idalmSalidadespacho = despacho.IdalmSalidadespacho,
                        estado = 2, // Suponemos que el estado 2 significa rechazado
                        usuarioModificacion = "usuarioRechazo", // Debes obtener el usuario actual
                        fechaModificacion = DateTime.Now
                    }
                };

                // Envía la solicitud de actualización
                var response = await _Rest.PostAsync<int?>("AlmSalidadespacho/PosDespacho", updateObject);

                _MessageShow(response.Message, response.State);

                if (response.State != State.Success)
                {
                    response.Errors?.ForEach(error =>
                    {
                        _MessageShow(error, State.Warning);
                    });
                    return;
                }

                await onTablaAsyncCabeceraPallet();
                _MessageShow("Despacho rechazado correctamente", State.Success);
            }
            catch (Exception e)
            {
                _Loading.Hide();
                _MessageShow($"Error al rechazar el despacho: {e.Message}", State.Error);
            }
            finally
            {
                _Loading.Hide();
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
        private List<VsolicitudescomercialDto> AlmSalidadespacho { get; set; }
        private List<VsolicitudescomercialDto> AlmSalidadespachoDes { get; set; }
        public AlmSalidadespachodetalleDto _AlmSalidadespachodetalleNuevo = new AlmSalidadespachodetalleDto();
        string _TituloPopup; string _TituloPopup1; int _TituloPopup2;
        private bool popupAdmViewPallets { get; set; } = false;
        private bool popupAdmViewPalletsdet { get; set; } = false;
        private bool popupAdmViewPalletsDato { get; set; } = false;

        private HashSet<AlmSalidadespachodetalleDto> selectedItems2 = new HashSet<AlmSalidadespachodetalleDto>();
        protected void OpenDialog1(int v_IdEmpresa)
        {
            var vAfiliacion = AlmSalidaDespachoListaTabla.First(f => f.IdalmSalidadespacho == v_IdEmpresa);
            //vAfiliacion.VerDetalle = !vAfiliacion.VerDetalle;
            _TituloPopup = vAfiliacion.IdalmSalidadespacho.ToString();
            //this.popupAdmViewExtractoVerificados = true;

        }

        
        private void Expand()
        {
            popupAdmViewPallets = true;
        }
        private void Expand2()
        {
            popupAdmViewPalletsdet = true;
        }
        private void Expand1()
        {
            popupAdmViewPalletsDato = true;
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

            StateHasChanged();
            await onTablaAsyncPalletsDes(vAfiliacion.IdalmSalidadespacho);
            StateHasChanged();
        }

        protected async void ShowBtnadd2(int v_IdEmpresa)
        {
            var vAfiliacion = AlmSalidadespachoDes.First(f => f.IdalmSalidadespacho == v_IdEmpresa);
            Expand2();
            _TituloPopup = "REGISTRO - DETALLE DE SALIDA DE PALLETS DE ALMACEN DE PT";
            _TituloPopup1 = "PALLETS ASIGNADOS";
            StateHasChanged();
            await onTablaAsyncPalletsDes(vAfiliacion.IdalmSalidadespacho);
            StateHasChanged();

        }
        protected async Task btnCancelPop()
        {
           this.popupAdmViewPallets = false;
            this.popupAdmViewPallets = false;
            this.popupAdmViewPalletsDato = false;
            this.popupAdmViewPalletsdet = false;
            await onTablaAlmacenV();
            await onTablaAsync4();
            await onTablaAsync4des();
            StateHasChanged();
            StateHasChanged();
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
                var s = VPalletalmacen.Where(x => x.IdAlmContenidoPallets == price).ToList();
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
            await onTablaAsync4();
            await onTablaAlmacenV();
            await onTablaAsync4des();
            StateHasChanged();
            StateHasChanged();
            await onTablaAsyncPalletsDes(_TituloPopup2);
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
                }
                VPalletalmacen = _result.Data;
            }
            catch (Exception e)
            {
                _MessageShow(e.Message, State.Error);
            }
        }

        protected async Task onTablaAsyncPalletsDes(int idorden)
        {
            try
            {

                var _result = await _Rest.GetAsync<List<VpalletalmacendDto>>($"AlmSalidadespachodetalle/Vpalletalmacend/{idorden}");

                if (_result.State != State.Success)
                {
                    _DialogShow(_result.Message, _result.State);
                }
                Despachodetalledes = _result.Data;

            }
            catch (Exception e)
            {
                _MessageShow(e.Message, State.Error);
            }

        }

        protected async Task onTablaAsync4des()
        {
            try
            {
                _Loading.Show();
                var _result = await _Rest.GetAsync<List<VsolicitudescomercialDto>>("Despacho/SolicitudDes");
                _Loading.Hide();
                if (_result.State != State.Success)
                {
                    _DialogShow(_result.Message, _result.State);
                }
                AlmSalidadespachoDes = _result.Data.OrderByDescending(x => x.IdalmSalidadespacho).ToList();
            }
            catch (Exception e)
            {
                _MessageShow(e.Message, State.Error);
            }
        }
        public async Task repjasper(int Iddespacho)
        {

            //Parametros en jasper "orden_produccion"


            await JSRuntime.InvokeVoidAsync("CargaReportePdf",
            new
            {           
                ruta = "/reports/ENVIBOL/PRODUCCION/Desarrollo/DetalleDespacho",
                idAlmSalidaDespachoParam = Iddespacho,

            });
        }

    }
}
