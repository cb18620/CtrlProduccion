#pragma checksum "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\RegistroPersona\TitularBeneficiario.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25b0ba436d54f74906c74451906a245809dc88a6"
// <auto-generated/>
#pragma warning disable 1591
namespace Server.Pages.RegistroPersona
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\_Imports.razor"
using MudBlazor.ThemeManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\_Imports.razor"
using Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\_Imports.razor"
using Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\_Imports.razor"
using Infraestructura.Abstract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\_Imports.razor"
using Infraestructura.Component;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\_Imports.razor"
using Infraestructura.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\_Imports.razor"
using Server.Shared.Component;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/RegistroPersona/TitularBeneficiario")]
    public partial class TitularBeneficiario : MainLayout
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudExpansionPanels>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudExpansionPanel>(2);
                __builder2.AddAttribute(3, "Text", "Registro de Titular / Beneficiario");
                __builder2.AddAttribute(4, "MaxHeight", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 6 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\RegistroPersona\TitularBeneficiario.razor"
                                                                            150

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudGrid>(6);
                    __builder3.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudItem>(8);
                        __builder4.AddAttribute(9, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 8 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\RegistroPersona\TitularBeneficiario.razor"
                         12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(10, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 8 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\RegistroPersona\TitularBeneficiario.razor"
                                 6

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(11, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 8 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\RegistroPersona\TitularBeneficiario.razor"
                                        4

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __Blazor.Server.Pages.RegistroPersona.TitularBeneficiario.TypeInference.CreateMudTextField_0(__builder5, 13, 14, "Matricula de Seguro Titular", 15, 
#nullable restore
#line 9 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\RegistroPersona\TitularBeneficiario.razor"
                                                                                                            Variant.Text

#line default
#line hidden
#nullable disable
                            , 16, 
#nullable restore
#line 9 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\RegistroPersona\TitularBeneficiario.razor"
                                           txtMatriculaSeguro

#line default
#line hidden
#nullable disable
                            , 17, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => txtMatriculaSeguro = __value, txtMatriculaSeguro)));
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(18, "\r\n        <br>\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudButton>(19);
                    __builder3.AddAttribute(20, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 13 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\RegistroPersona\TitularBeneficiario.razor"
                            Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(21, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 13 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\RegistroPersona\TitularBeneficiario.razor"
                                                   Color.Success

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(22, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\RegistroPersona\TitularBeneficiario.razor"
                                                                              Icons.Material.Filled.Save

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(24, "Guardar");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudExpansionPanel>(26);
                __builder2.AddAttribute(27, "Text", "Panel Two");
                __builder2.AddAttribute(28, "MaxHeight", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 15 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\RegistroPersona\TitularBeneficiario.razor"
                                                   500

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(30, "\r\n        Panel Two Content\r\n    ");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\RegistroPersona\TitularBeneficiario.razor"
           
        bool disabled = false;
        public string txtMatriculaSeguro { get; set; }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IManagerAuthorize _auth { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService DialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar _snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ManagerRest _Rest { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Loading _Loading { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navMgr { get; set; }
    }
}
namespace __Blazor.Server.Pages.RegistroPersona.TitularBeneficiario
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
