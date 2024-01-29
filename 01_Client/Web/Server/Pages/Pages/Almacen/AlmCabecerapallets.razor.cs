using Infraestructura.Abstract;
using Infraestructura.Component;
using Infraestructura.Models.Almacen;
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


namespace Server.Pages.Pages.Almacen
{
    public partial class AlmCabecerapallets 
    {
        public AlmCabeceraPalletsDto _AlmCabeceraNuevo = new AlmCabeceraPalletsDto();
        public List<ValmCabecerapalletsDto> AlmacenCabeceraListaTabla { get; set; }
        //public List<AlmCabeceraPalletsDto> AlmacenCabeceraListaTablas { get; set; }


        private static List<GenClasificadorDto> ProductoList { get; set; }
        public string jsonTipoProducto { get; set; }
        private static List<GenClasificadorDto> ColorList { get; set; }
        public string jsonColorProducto { get; set; }
        private static List<GenClasificadorDto> LineaList { get; set; }
        public string jsonLinea { get; set; }
        public List<GenClasificadorDto> ListTurno = new List<GenClasificadorDto>();
        public List<GenClasificadorDto> TipoList = new List<GenClasificadorDto>();

        private bool dense = true;
        private bool hover = true;
        private bool ronly = true;
        bool fixed_header = true;
        bool fixed_footer = false;
        private bool visible;
        void Submit() => visible = false;
        private void OpenDialog() => visible = true;
        protected IJSRuntime JsRuntime { get; set; }
        public bool documento { get; set; } = true;
        private string searchString = "";
        private string ordenProduccionSearchString = "";
        
        private bool popupAdmView { get; set; } = false;
        private bool FilterFunc1(ValmCabecerapalletsDto element) => FilterFunc2(element, searchString);
        private bool FilterFunc2(ValmCabecerapalletsDto element, string searchString)
        {
            if (string.IsNullOrWhiteSpace(searchString))
                return true;
            if (element.Descripcionmolde.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            if ((element.OrdenProduccion != null && element.OrdenProduccion != "") && element.OrdenProduccion.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            return false;
        }

        protected override async Task OnInitializedAsync()
        {
            var tasks = new List<Task>
    {
        onTablaAsyncCabeceraPallet(),
        GetTipoProducto(),
        GetColorProducto(),
        GetLinea(),
        onTablaAsyncCabecera(),
        GetTurno(),
        GetTipo()
    };

            await Task.WhenAll(tasks);
        }


        protected async Task SaveAlmCaberaPallet()
        {
            try
            {
                _Loading.Show();
                var vrespost = await _Rest.PostAsync<int?>("AlmCabeceraPallets", new { _AlmCabeceraPallets = _AlmCabeceraNuevo });
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
                _AlmCabeceraNuevo = new AlmCabeceraPalletsDto();
                _MessageShow("<b>Produccion agregado correctamente</b>", State.Success);
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
                var _result = await _Rest.GetAsync<List<ValmCabecerapalletsDto>>("AlmCabeceraPallets");
                _Loading.Hide();
                if (_result.State != State.Success)
                {
                    _DialogShow(_result.Message, _result.State);
                }
                AlmacenCabeceraListaTabla = _result.Data;
            }
            catch (Exception e)
            {
                _MessageShow(e.Message, State.Error);
            }
        }
        private void ShowBtnEditCabecer(int vCabecera)
        {
            var vfila = AlmacenCabeceraListaTabla.First(x => x.IdAlmCabeceraPallets == vCabecera);
            vfila.VerDetalle = !vfila.VerDetalle;
        }
        private async Task OnValidAlmCabeceraNuevo(EditContext context)
        {
            await SaveAlmCaberaPallet();
            //Console.WriteLine("OnValidAMedidaNuevo");

        }
        protected void ShowBtnEditCabecera(int v_Almcabecera)
        {
            var vAlmcabecera = AlmacenCabeceraListaTabla.First(f => f.IdAlmCabeceraPallets == v_Almcabecera);
            vAlmcabecera.VerDetalle = !vAlmcabecera.VerDetalle;
        }
        public async Task EliminarAlmCabecera(int idTransporte)
        {


            await _MessageConfirm("Esta seguro de eliminar el registro...?", async () =>
            {
                var vrespost = await _Rest.DeleteAsync<int>("AlmCabeceraPallets", idTransporte);
                if (!vrespost.Succeeded)
                {
                    _MessageShow(vrespost.Message, State.Error);
                }
                else
                {
                    _MessageShow(vrespost.Message, vrespost.State);
                    //_RowIdsubPlanificaciondetalle = 0;
                    await onTablaAsyncCabeceraPallet();
                    StateHasChanged();
                }
            });
        }

        protected async Task GetTipo()
        {
            try
            {

                _Loading.Show();
                var _result = await _Rest.GetAsync<List<GenClasificadorDto>>("Clasificador/Tipo");
                _Loading.Hide();
                //_MessageShow(_result.Message, _result.State);
                if (_result.State != State.Success)
                    return;
                TipoList = _result.Data;
            }
            catch (Exception e)
            {
                _MessageShow(e.Message, State.Error);
            }
        }
        protected async Task GetTurno()
        {
            try
            {

                _Loading.Show();
                var _result = await _Rest.GetAsync<List<GenClasificadorDto>>("Clasificador/Turno");
                _Loading.Hide();
                //_MessageShow(_result.Message, _result.State);
                if (_result.State != State.Success)
                    return;
                ListTurno = _result.Data;
            }
            catch (Exception e)
            {
                _MessageShow(e.Message, State.Error);
            }
        }
        protected async Task GetTipoProducto()
        {
            try
            {

                _Loading.Show();
                var _result = await _Rest.GetAsync<List<GenClasificadorDto>>("Clasificador/Producto");
                _Loading.Hide();
                //_MessageShow(_result.Message, _result.State);
                if (_result.State != State.Success)
                    return;
                ProductoList = _result.Data;
                jsonTipoProducto = JsonSerializer.Serialize(ProductoList);
            }
            catch (Exception e)
            {
                _MessageShow(e.Message, State.Error);
            }
        }
        protected async Task GetColorProducto()
        {
            try
            {

                _Loading.Show();
                var _result = await _Rest.GetAsync<List<GenClasificadorDto>>("Clasificador/ColorEnvase");
                _Loading.Hide();
                //_MessageShow(_result.Message, _result.State);
                if (_result.State != State.Success)
                    return;
                ColorList = _result.Data;
                jsonColorProducto = JsonSerializer.Serialize(ColorList);
            }
            catch (Exception e)
            {
                _MessageShow(e.Message, State.Error);
            }
        }
        protected async Task GetLinea()
        {
            try
            {

                _Loading.Show();
                var _result = await _Rest.GetAsync<List<GenClasificadorDto>>("Clasificador/Linea");
                _Loading.Hide();
                //_MessageShow(_result.Message, _result.State);
                if (_result.State != State.Success)
                    return;
                LineaList = _result.Data;
                jsonLinea = JsonSerializer.Serialize(LineaList);
            }
            catch (Exception e)
            {
                _MessageShow(e.Message, State.Error);
            }
        }

        protected async Task SaveEditCabecera(ValmCabecerapalletsDto DtoCabecera)
        {

            try
            {
                _Loading.Show();
                var _update = await _Rest.PutAsync<int>("AlmCabeceraPallets", DtoCabecera, DtoCabecera.IdAlmCabeceraPallets);
                if (_update.State == State.Success)
                {
                    _MessageShow(_update.Message, _update.State);
                    DtoCabecera.IdAlmCabeceraPallets = _update.Data;
                    DtoCabecera.VerDetalle = !DtoCabecera.VerDetalle;
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
        protected async Task onTablaAsyncCabecera()
        {
            try
            {
                _Loading.Show();
                var _result = await _Rest.GetAsync<List<ValmCabecerapalletsDto>>("AlmCabeceraPallets/ListaCabecera");
                _Loading.Hide();
                if (_result.State != State.Success)
                {
                    _DialogShow(_result.Message, _result.State);
                }
                AlmacenCabeceraListaTabla = _result.Data;
            }
            catch (Exception e)
            {
                _MessageShow(e.Message, State.Error);
                _Loading.Hide();
            }
        }







        //AGREGAR DETALLE ADDD
        public AlmContenidoPalletsDto _AlmContenidoPalletsNew = new AlmContenidoPalletsDto();
        public List<AlmContenidoPalletsDto> ListAlmContenidoPallets = new List<AlmContenidoPalletsDto>();
        public List<AlmContenidoPalletsDto> ListAlmContenidoPalletstot = new List<AlmContenidoPalletsDto>();
        public List<AlmContenidoPalletsDto> ListAlmContenidoPalletsproceso = new List<AlmContenidoPalletsDto>();
        private HashSet<AlmContenidoPalletsDto> selectedItems2 = new HashSet<AlmContenidoPalletsDto>();
        private string searchString1 = "";
        private string numPalletSearchString = "";
        string _TituloPopup;
        int _TituloPopup2;
        string _TituloPopup1;
        DateTime? date = DateTime.Today;
        public CultureInfo _en = CultureInfo.GetCultureInfo("en-US");
        private void Expand()
        {
            popupAdmView = true;
        }
        protected async Task btnCancelPop()
        {

            await onTablaAsyncCabecera();
            this.popupAdmView = false;
        }
        private bool FilterByNumPallet(AlmContenidoPalletsDto element)
        {
            if (string.IsNullOrWhiteSpace(numPalletSearchString))
                return true;

            return element.NumPallet.ToString().Contains(numPalletSearchString, StringComparison.OrdinalIgnoreCase);
        }
        protected async void ShowBtnadd(int v_Id)
        {
            var vDatPop = AlmacenCabeceraListaTabla.First(f => f.IdAlmCabeceraPallets == v_Id);
            Expand();
            _TituloPopup = "REGISTRO - DETALLE ";
            _TituloPopup1 = "PALLETS ";
            _TituloPopup2 = vDatPop.IdAlmCabeceraPallets;


            var _result = await _Rest.GetAsync<List<AlmContenidoPalletsDto>>($"AlmContenidoPallets/DetallePallet/{v_Id}");
            StateHasChanged();
            var _result1 = await _Rest.GetAsync<List<AlmContenidoPalletsDto>>($"AlmContenidoPallets/DetallePalletproceso/{v_Id}");
            StateHasChanged();
            ListAlmContenidoPallets = _result.Data.OrderByDescending(x => x.NumPallet).ToList();
            ListAlmContenidoPalletsproceso = _result1.Data.OrderByDescending(x => x.NumPallet).ToList();

            ListAlmContenidoPalletstot.AddRange(ListAlmContenidoPallets);
            ListAlmContenidoPalletstot.AddRange(ListAlmContenidoPalletsproceso);

            var d = ListAlmContenidoPalletstot.OrderByDescending(x => x.NumPallet).ToList();
            if (d.Count() > 0)
            {
                _AlmContenidoPalletsNew.NumPalletinicial = d[0].NumPallet + 1;
                _AlmContenidoPalletsNew.NumPalletFinal = d[0].NumPallet + 1;
            }
            else
            {
                _AlmContenidoPalletsNew.NumPalletinicial = 1;
                _AlmContenidoPalletsNew.NumPalletFinal = 1;
            }




            StateHasChanged();
        }

        private async Task OnTableContenidoPallet()
        {

        }
        protected async Task onTablaAsyncContenido(int idCab)
        {
            try { 
            var _result = await _Rest.GetAsync<List<AlmContenidoPalletsDto>>($"AlmContenidoPallets/DetallePallet/{idCab}");

            ListAlmContenidoPallets = _result.Data;
                this.popupAdmView = true;
            }
            catch (Exception e)
            {
                _MessageShow(e.Message, State.Error);
            }
        }
        protected async Task onTablaAsyncContenidoProceso(int idCab)
        {
            try
            {

                var _result = await _Rest.GetAsync<List<AlmContenidoPalletsDto>>($"AlmContenidoPallets/DetallePalletproceso/{idCab}");

                ListAlmContenidoPalletsproceso = _result.Data;
                this.popupAdmView = true;
            }
            catch (Exception e)
            {
                _MessageShow(e.Message, State.Error);
            }
        }

        private async Task SaveContenidoPallets()
        {

            int inicial = _AlmContenidoPalletsNew.NumPalletinicial;
            int final = _AlmContenidoPalletsNew.NumPalletFinal;
            int cantiddadbot = _AlmContenidoPalletsNew.CantidadBotellas;
            string guardados = "";
            string noguardados = "";
            _AlmContenidoPalletsNew.Fecha = date;
            if (inicial > final)
            {
                _MessageShow("Numero Inicial no puede ser mayor al final", State.Error);
                return;
            }

            if (inicial == 0)
            {
                _MessageShow("Numero Inicial no puede ser 0", State.Error);
                return;
            }
            if (final == 0)
            {
                _MessageShow("Numero Final no puede ser 0", State.Error);
                return;
            }
            if (cantiddadbot == 0)
            {
                _MessageShow("Cantidad de botellas no puede ser 0", State.Error);
                return;
            }

            if (_AlmContenidoPalletsNew.Tipo == 0)
            {
                _MessageShow("Debe seleccionar un Tipo de Pallet", State.Error);
                return;
            }
            if (_AlmContenidoPalletsNew.Turno == 0)
            {
                _MessageShow("Debe seleccionar un Turno", State.Error);
                return;
            }
            if (_AlmContenidoPalletsNew.Fecha == null)
            {
                _MessageShow("Debe seleccionar una fecha", State.Error);
                return;
            }


            _Loading.Show();
            for (int i = inicial; i <= final; i++)
            {

                _AlmContenidoPalletsNew.IdalmCabeceraPallets = _TituloPopup2;
                _AlmContenidoPalletsNew.NumPallet = i;
                _AlmContenidoPalletsNew.Observacion = "";
                _AlmContenidoPalletsNew.Analisis = "";
                _AlmContenidoPalletsNew.Estadolectura = 1;
                _AlmContenidoPalletsNew.DescripcionTurno = "";
                _AlmContenidoPalletsNew.DescripcionTipo = "";



                try
                {
                    _Loading.Show();
                    var _result = await _Rest.GetAsync<List<AlmContenidoPalletsDto>>($"AlmContenidoPallets/DetalleControl/{_AlmContenidoPalletsNew.IdalmCabeceraPallets},{_AlmContenidoPalletsNew.NumPallet}");


                    if (_result.Data.Count() > 0)
                    {
                        noguardados = noguardados + "," + i.ToString();
                    }
                    else
                    {
                        var vrespost = await _Rest.PostAsync<int?>("AlmCabeceraConPallets", new { _AlmContenidoPallets = _AlmContenidoPalletsNew });
                        guardados = guardados + "," + i.ToString();
                        //_MessageShow(vrespost.Message, vrespost.State);

                    }


                }
                catch (Exception e)
                {
                    _Loading.Hide();
                    _MessageShow(e.Message, State.Error);
                }

            }
            _Loading.Hide();
            if (noguardados != "")
            {
                _MessageShow(" Pallets No guardados" + noguardados, State.Error);
            }
            if (guardados != "")
            {
                _MessageShow("Pallets Guardados: " + guardados, State.Success);
            }

            await onTablaAsyncContenido(_TituloPopup2);

            await onTablaAsyncContenidoProceso(_TituloPopup2);



        }
        public async Task ShowBtnEliminarContenido(int idContenido)
        {
            await _MessageConfirm("Esta seguro de eliminar el registro...?", async () =>
            {
                var vrespost = await _Rest.DeleteAsync<int>("AlmContenidoPallets", idContenido);
                if (!vrespost.Succeeded)
                {
                    _MessageShow(vrespost.Message, State.Error);
                }
                else
                {
                    _MessageShow(vrespost.Message, vrespost.State);
                    await onTablaAsyncContenido(_TituloPopup2);
                    await onTablaAsyncContenidoProceso(_TituloPopup2);
                    StateHasChanged();
                }
            });
        }

        private async Task btnSelecGuardarConforme()
        {


            String valores = (selectedItems2 == null ? "" : string.Join(", ", selectedItems2.Select(x => x.IdAlmContenidoPallets)));
            String[] arreglo = valores.Split(',');

            _Loading.Show();
            foreach (var l in arreglo)
            {
                try
                {
                    _AlmContenidoPalletsNew.IdAlmContenidoPallets = Int32.Parse(l);
                    _AlmContenidoPalletsNew.Tipo = 15;
                    _AlmContenidoPalletsNew.Estadolectura = 2; // conforme
                    var _update = await _Rest.PutAsync<int>("AlmContenidoPallets", _AlmContenidoPalletsNew, _AlmContenidoPalletsNew.IdAlmContenidoPallets);
                    if (_update.State == State.Success)
                    {


                        // DtoZfriReprocesoRepaletizado.IdalmAlmacenlpallets = _update.Data;
                        //DtoZfriReprocesoRepaletizado.VerDetalle = !DtoZfriReprocesoRepaletizado.VerDetalle;
                    }
                    else
                    {
                        //  _MessageShow(_update.Message, _update.State);
                    }
                }
                catch (Exception e)
                {
                    _DialogShow(e.Message, State.Error);
                }

            }
            _Loading.Hide();
            await onTablaAsyncContenido(_TituloPopup2);
            StateHasChanged();
            await onTablaAsyncContenidoProceso(_TituloPopup2);
            StateHasChanged();
            HashSet<AlmContenidoPalletsDto> selectedItems3 = new HashSet<AlmContenidoPalletsDto>();
            selectedItems2 = selectedItems3;
            _MessageShow("Modificados de Manera correcta", State.Success);
            _Loading.Hide();


        }

        private async Task btnSelecGuardarNoReprocesar()
        {
            ;

            String valores = (selectedItems2 == null ? "" : string.Join(", ", selectedItems2.Select(x => x.IdAlmContenidoPallets)));
            String[] arreglo = valores.Split(',');

            _Loading.Show();
            foreach (var l in arreglo)
            {
                try
                {

                    _AlmContenidoPalletsNew.IdAlmContenidoPallets = Int32.Parse(l);
                    _AlmContenidoPalletsNew.Tipo = 13;
                    _AlmContenidoPalletsNew.Estadolectura = 3; /// rEPROCESSAR
                    var _update = await _Rest.PutAsync<int>("AlmContenidoPallets", _AlmContenidoPalletsNew, _AlmContenidoPalletsNew.IdAlmContenidoPallets);
                    if (_update.State == State.Success)
                    {
                        //  _MessageShow(_update.Message, _update.State);

                        // DtoZfriReprocesoRepaletizado.IdalmAlmacenlpallets = _update.Data;
                        //DtoZfriReprocesoRepaletizado.VerDetalle = !DtoZfriReprocesoRepaletizado.VerDetalle;
                    }
                    else
                    {
                        //    _MessageShow(_update.Message, _update.State);
                    }
                }
                catch (Exception e)
                {
                    // _DialogShow(e.Message, State.Error);
                }

            }
            _Loading.Hide();
            await onTablaAsyncContenido(_TituloPopup2);
            StateHasChanged();
            await onTablaAsyncContenidoProceso(_TituloPopup2);
            StateHasChanged();
            HashSet<AlmContenidoPalletsDto> selectedItems3 = new HashSet<AlmContenidoPalletsDto>();
            selectedItems2 = selectedItems3;
            _MessageShow("Modificados de Manera correcta", State.Success);
            _Loading.Hide();

        }

        private async Task btnSelecGuardarNoConforme()
        {


            String valores = (selectedItems2 == null ? "" : string.Join(", ", selectedItems2.Select(x => x.IdAlmContenidoPallets)));
            String[] arreglo = valores.Split(',');

            _Loading.Show();
            foreach (var l in arreglo)
            {
                try
                {
                    _AlmContenidoPalletsNew.IdAlmContenidoPallets = Int32.Parse(l);
                    _AlmContenidoPalletsNew.Tipo = 14;
                    _AlmContenidoPalletsNew.Estadolectura = 4; // NO conforme
                    var _update = await _Rest.PutAsync<int>("AlmContenidoPallets", _AlmContenidoPalletsNew, _AlmContenidoPalletsNew.IdAlmContenidoPallets);
                    if (_update.State == State.Success)
                    {


                        // DtoZfriReprocesoRepaletizado.IdalmAlmacenlpallets = _update.Data;
                        //DtoZfriReprocesoRepaletizado.VerDetalle = !DtoZfriReprocesoRepaletizado.VerDetalle;
                    }
                    else
                    {
                        //  _MessageShow(_update.Message, _update.State);
                    }
                }
                catch (Exception e)
                {
                    _DialogShow(e.Message, State.Error);
                }

            }
            _Loading.Hide();
            await onTablaAsyncContenido(_TituloPopup2);
            StateHasChanged();
            await onTablaAsyncContenidoProceso(_TituloPopup2);
            StateHasChanged();
            HashSet<AlmContenidoPalletsDto> selectedItems3 = new HashSet<AlmContenidoPalletsDto>();
            selectedItems2 = selectedItems3;
            _MessageShow("Modificados de Manera correcta", State.Success);
            _Loading.Hide();



        }

    }
}

