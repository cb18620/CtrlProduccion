#pragma checksum "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22e85f92689ffa5773127e9467f53a1af82350af"
// <auto-generated/>
#pragma warning disable 1591
namespace Server.Pages.Afiliacion
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Afiliacion/Afiliaciones")]
    public partial class Afiliaciones : MainLayout
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "b-64cobo81m8");
            __builder.OpenComponent<MudBlazor.MudDivider>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n    ");
            __builder.OpenComponent<MudBlazor.MudItem>(4);
            __builder.AddAttribute(5, "Class", "d-flex mt-2 mb-2");
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudText>(7);
                __builder2.AddAttribute(8, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 9 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                       Typo.h5

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(10, "Afiliaciones");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudButton>(12);
                __builder2.AddAttribute(13, "Link", "Afiliacion/AfiliacionesNuevo");
                __builder2.AddAttribute(14, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 10 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                                                Variant.Filled

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 10 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                                                                       Color.Success

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "Class", "ml-auto");
                __builder2.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(18, "Nueva Persona");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(19, "\r\n\r\n    ");
            __builder.OpenComponent<MudBlazor.MudDivider>(20);
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\r\n\r\n    ");
            __builder.OpenComponent<MudBlazor.MudItem>(22);
            __builder.AddAttribute(23, "Class", "d-flex");
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "ml-auto");
                __builder2.AddAttribute(27, "b-64cobo81m8");
                __Blazor.Server.Pages.Afiliacion.Afiliaciones.TypeInference.CreateMudTextField_0(__builder2, 28, 29, "Buscar", 30, 
#nullable restore
#line 19 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                     Adornment.Start

#line default
#line hidden
#nullable disable
                , 31, "width:200px;", 32, 
#nullable restore
#line 21 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                     true

#line default
#line hidden
#nullable disable
                , 33, 
#nullable restore
#line 22 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                   Variant.Text

#line default
#line hidden
#nullable disable
                , 34, 
#nullable restore
#line 23 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                     true

#line default
#line hidden
#nullable disable
                , 35, 
#nullable restore
#line 24 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                          Icons.Material.Filled.Search

#line default
#line hidden
#nullable disable
                , 36, 
#nullable restore
#line 25 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                          Color.Secondary

#line default
#line hidden
#nullable disable
                , 37, 
#nullable restore
#line 26 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                    Size.Small

#line default
#line hidden
#nullable disable
                , 38, 
#nullable restore
#line 17 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                        searchString1

#line default
#line hidden
#nullable disable
                , 39, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => searchString1 = __value, searchString1)));
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(40, "\r\n\r\n    ");
            __Blazor.Server.Pages.Afiliacion.Afiliaciones.TypeInference.CreateMudTable_1(__builder, 41, 42, 
#nullable restore
#line 31 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                      Afiliacion

#line default
#line hidden
#nullable disable
            , 43, 
#nullable restore
#line 31 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                             0

#line default
#line hidden
#nullable disable
            , 44, 
#nullable restore
#line 31 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                                            Breakpoint.None

#line default
#line hidden
#nullable disable
            , 45, (context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTd>(46);
                __builder2.AddAttribute(47, "Style", "width:40px");
                __builder2.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudAvatar>(49);
                    __builder3.AddAttribute(50, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 34 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                  Color.Secondary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(51, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 34 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                                            Variant.Outlined

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(52, "Style", "font-size:1rem");
                    __builder3.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(54, "1/21");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(55, "\r\n\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTd>(56);
                __builder2.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudLink>(58);
                    __builder3.AddAttribute(59, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 38 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                               Typo.subtitle1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(60, "Href", "#");
                    __builder3.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(62, 
#nullable restore
#line 38 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                                          context.Nombre

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(63, "<br b-64cobo81m8>\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(64);
                    __builder3.AddAttribute(65, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 39 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                      Color.Error

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(66, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                                          Icons.Filled.LocationOn

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(67, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 39 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                                                                         Size.Small

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.OpenComponent<MudBlazor.MudText>(68);
                    __builder3.AddAttribute(69, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 39 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                                                                                                      Typo.caption

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(71, 
#nullable restore
#line 39 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                                                                                                                     context.Direccion

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(72, "<br b-64cobo81m8>\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(73);
                    __builder3.AddAttribute(74, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 40 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                      Color.Success

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(75, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 40 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                                           Icons.Filled.PermIdentity

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(76, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 40 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                                                                            Size.Small

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.OpenComponent<MudBlazor.MudText>(77);
                    __builder3.AddAttribute(78, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 40 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                                                                                                        Typo.caption

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(80, 
#nullable restore
#line 40 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                                                                                                                       context.Cedula

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(81, "<br b-64cobo81m8>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(82, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTd>(83);
                __builder2.AddAttribute(84, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(85, "div");
                    __builder3.AddAttribute(86, "class", "d-flex");
                    __builder3.AddAttribute(87, "b-64cobo81m8");
                    __builder3.OpenElement(88, "div");
                    __builder3.AddAttribute(89, "class", "m-auto");
                    __builder3.AddAttribute(90, "b-64cobo81m8");
                    __builder3.OpenComponent<MudBlazor.MudTooltip>(91);
                    __builder3.AddAttribute(92, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 46 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                           context.EstadoTitular

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(93, "Color", "Color.Secondary");
                    __builder3.AddAttribute(94, "Placement", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Placement>(
#nullable restore
#line 46 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                                                                                     Placement.Top

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(95, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 47 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                             if (context.IdcestadoTitular == 72)
                            {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<MudBlazor.MudIconButton>(96);
                        __builder4.AddAttribute(97, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 49 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                                      Color.Warning

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(98, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 49 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                                                            Icons.Material.Outlined.Pause

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(99, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 49 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                                                                                                 Size.Small

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
#nullable restore
#line 50 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                            }

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<MudBlazor.MudIconButton>(100);
                        __builder4.AddAttribute(101, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 51 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                                  Icons.Material.Outlined.Block

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(102, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 51 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                                                                       Size.Small

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(103, "\r\n                        ");
                    __builder3.OpenComponent<MudBlazor.MudTooltip>(104);
                    __builder3.AddAttribute(105, "Text", "Tipo subsdidio Lactancia");
                    __builder3.AddAttribute(106, "Color", "Color.Secondary");
                    __builder3.AddAttribute(107, "Placement", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Placement>(
#nullable restore
#line 53 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                                                                                       Placement.Top

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(108, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudIconButton>(109);
                        __builder4.AddAttribute(110, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 54 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                                  Icons.Material.Outlined.ChildFriendly

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(111, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 54 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                                                                               Size.Small

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(112, "\r\n                        ");
                    __builder3.OpenComponent<MudBlazor.MudTooltip>(113);
                    __builder3.AddAttribute(114, "Text", "Pagado");
                    __builder3.AddAttribute(115, "Color", "Color.Secondary");
                    __builder3.AddAttribute(116, "Placement", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Placement>(
#nullable restore
#line 56 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                                                                     Placement.Top

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(117, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudIconButton>(118);
                        __builder4.AddAttribute(119, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 57 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                                  Icons.Material.Outlined.DoneAll

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(120, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 57 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                                                                         Size.Small

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(121, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTd>(122);
                __builder2.AddAttribute(123, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(124, "div");
                    __builder3.AddAttribute(125, "class", "d-flex");
                    __builder3.AddAttribute(126, "b-64cobo81m8");
                    __builder3.OpenElement(127, "div");
                    __builder3.AddAttribute(128, "class", "ml-auto");
                    __builder3.AddAttribute(129, "b-64cobo81m8");
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(130);
                    __builder3.AddAttribute(131, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 65 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                              Icons.Material.Outlined.Edit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(132, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 65 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                                                                   Color.Warning

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(133, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 65 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                                                                                        Size.Medium

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(134, "Class", "ma-1");
                    __builder3.AddAttribute(135, "Title", "Cancelar");
                    __builder3.AddAttribute(136, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                                                                                                                                              () => ShowBtnEdit(context.IdadmPersona)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(137, "\r\n                        ");
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(138);
                    __builder3.AddAttribute(139, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 66 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                              Icons.Material.Outlined.Delete

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(140, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 66 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                                                                     Color.Error

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(141, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 66 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Afiliacion\Afiliaciones.razor"
                                                                                                        Size.Medium

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(142, "Class", "ma-1");
                    __builder3.AddAttribute(143, "Title", "Eliminar");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            , 144, (context) => (__builder2) => {
            }
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IManagerAuthorize _auth { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService DialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar _snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ManagerRest _Rest { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Loading _Loading { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navMgr { get; set; }
    }
}
namespace __Blazor.Server.Pages.Afiliacion.Afiliaciones
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Adornment __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::MudBlazor.Variant __arg4, int __seq5, global::System.Boolean __arg5, int __seq6, global::System.String __arg6, int __seq7, global::MudBlazor.Color __arg7, int __seq8, global::MudBlazor.Size __arg8, int __seq9, T __arg9, int __seq10, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg10)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Placeholder", __arg0);
        __builder.AddAttribute(__seq1, "Adornment", __arg1);
        __builder.AddAttribute(__seq2, "Style", __arg2);
        __builder.AddAttribute(__seq3, "Immediate", __arg3);
        __builder.AddAttribute(__seq4, "Variant", __arg4);
        __builder.AddAttribute(__seq5, "Clearable", __arg5);
        __builder.AddAttribute(__seq6, "AdornmentIcon", __arg6);
        __builder.AddAttribute(__seq7, "AdornmentColor", __arg7);
        __builder.AddAttribute(__seq8, "IconSize", __arg8);
        __builder.AddAttribute(__seq9, "Value", __arg9);
        __builder.AddAttribute(__seq10, "ValueChanged", __arg10);
        __builder.CloseComponent();
        }
        public static void CreateMudTable_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.Int32 __arg1, int __seq2, global::MudBlazor.Breakpoint __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Elevation", __arg1);
        __builder.AddAttribute(__seq2, "Breakpoint", __arg2);
        __builder.AddAttribute(__seq3, "RowTemplate", __arg3);
        __builder.AddAttribute(__seq4, "ChildRowContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
