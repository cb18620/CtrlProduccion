#pragma checksum "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Planillado\PlanillaNuevo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0dbf8f85066745a1f18e63f821f4220c9a4acba1"
// <auto-generated/>
#pragma warning disable 1591
namespace Server.Pages.Planillado
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
#nullable restore
#line 4 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Planillado\PlanillaNuevo.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Planillado/Planillas/Nuevo")]
    public partial class PlanillaNuevo : MainLayout
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudDivider>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n<br b-k73y9jnqn6>\r\n");
            __builder.OpenComponent<MudBlazor.MudGrid>(2);
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudItem>(4);
                __builder2.AddAttribute(5, "lg", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Planillado\PlanillaNuevo.razor"
                 3

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Planillado\PlanillaNuevo.razor"
                        12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Planillado\PlanillaNuevo.razor"
                                12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Planillado\PlanillaNuevo.razor"
                                        3

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "xl", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Planillado\PlanillaNuevo.razor"
                                               3

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudText>(11);
                    __builder3.AddAttribute(12, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 12 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Planillado\PlanillaNuevo.razor"
                       Typo.subtitle1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(14, "Nueva Planilla ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(15, "<br b-k73y9jnqn6>\r\n\t\t");
                    __builder3.OpenComponent<MudBlazor.MudText>(16);
                    __builder3.AddAttribute(17, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 13 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Planillado\PlanillaNuevo.razor"
                       Typo.caption

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(19, "\r\n\t\t\tUna planilla representa al listado de beneficirios o beneficiarias que seran habilitados para el recogo de subsidio, una vez generada y pagada el subsidiario.\r\n\t\t");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(20, "<br b-k73y9jnqn6>\r\n\t\t<br b-k73y9jnqn6>\r\n\t\t");
                    __builder3.OpenComponent<MudBlazor.MudText>(21);
                    __builder3.AddAttribute(22, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 17 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Planillado\PlanillaNuevo.razor"
                       Typo.caption

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(24, "<strong b-k73y9jnqn6>\r\n\t\t\t\tNota.-\r\n\t\t\t</strong>\r\n\t\t\tVerifique los datos solicitados por que una vez registrados la planilla que este en estado aprobado y pagado no podra revirtir cambios\r\n\t\t");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(25, "<br b-k73y9jnqn6>\r\n\t\t<br b-k73y9jnqn6>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n\r\n\t");
                __builder2.OpenComponent<MudBlazor.MudItem>(27);
                __builder2.AddAttribute(28, "lg", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 28 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Planillado\PlanillaNuevo.razor"
                 9

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 28 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Planillado\PlanillaNuevo.razor"
                        12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 28 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Planillado\PlanillaNuevo.razor"
                                12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 28 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Planillado\PlanillaNuevo.razor"
                                        9

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "xl", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 28 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Planillado\PlanillaNuevo.razor"
                                               9

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudCard>(34);
                    __builder3.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudCardContent>(36);
                        __builder4.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudCardHeader>(38);
                            __builder5.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudText>(40);
                                __builder6.AddAttribute(41, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 34 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Planillado\PlanillaNuevo.razor"
                                   Typo.subtitle1

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(43, "Registro Inicial");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(44, "<br b-k73y9jnqn6>\r\n\t\t\t\t\t");
                                __builder6.OpenComponent<MudBlazor.MudDivider>(45);
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(46, "\r\n\r\n\t\t\t\t");
                            __builder5.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(47);
                            __builder5.AddAttribute(48, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 38 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Planillado\PlanillaNuevo.razor"
                                    OnSubmit

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddAttribute(49, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 39 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Planillado\PlanillaNuevo.razor"
                                  oPlanilla

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder6) => {
                                __builder6.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(51);
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(52, "\r\n\t\t\t\t\t");
                                __builder6.OpenComponent<MudBlazor.MudGrid>(53);
                                __builder6.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<MudBlazor.MudItem>(55);
                                    __builder7.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.OpenComponent<MudBlazor.MudText>(57);
                                        __builder8.AddAttribute(58, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 44 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Planillado\PlanillaNuevo.razor"
                                           Typo.caption

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder9) => {
                                            __builder9.AddMarkupContent(60, "<strong b-k73y9jnqn6>\r\n\t\t\t\t\t\t\t\t\tPeriodo\r\n\t\t\t\t\t\t\t\t</strong><br b-k73y9jnqn6>\r\n\t\t\t\t\t\t\t\tMes - Gestión Correspondiente\r\n\t\t\t\t\t\t\t");
                                        }
                                        ));
                                        __builder8.CloseComponent();
                                        __builder8.AddMarkupContent(61, "<br b-k73y9jnqn6>\r\n\r\n\t\t\t\t\t\t\t");
                                        __builder8.OpenComponent<Syncfusion.Blazor.Calendars.SfDatePicker<DateTime?>>(62);
                                        __builder8.AddAttribute(63, "Placeholder", "Periodo");
                                        __builder8.AddAttribute(64, "Format", "MMMM - yyyy");
                                        __builder8.AddAttribute(65, "style", "text-transform:capitalize");
                                        __builder8.AddAttribute(66, "AllowEdit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 56 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Planillado\PlanillaNuevo.razor"
                                                     false

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(67, "Min", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#nullable restore
#line 57 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Planillado\PlanillaNuevo.razor"
                                               new DateTime(2000,1,1)

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(68, "Max", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#nullable restore
#line 58 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Planillado\PlanillaNuevo.razor"
                                               new DateTime(DateTime.UtcNow.Year,DateTime.UtcNow.Month,DateTime.UtcNow.Day)

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(69, "Start", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Calendars.CalendarView>(
#nullable restore
#line 59 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Planillado\PlanillaNuevo.razor"
                                                 CalendarView.Year

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(70, "Depth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Calendars.CalendarView>(
#nullable restore
#line 60 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Planillado\PlanillaNuevo.razor"
                                                 CalendarView.Year

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(71, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DateTime?>(
#nullable restore
#line 54 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Planillado\PlanillaNuevo.razor"
                                                       DateValue

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(72, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<DateTime?>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<DateTime?>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => DateValue = __value, DateValue))));
                                        __builder8.AddAttribute(73, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<DateTime?>>>(() => DateValue));
                                        __builder8.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder9) => {
                                            __builder9.OpenComponent<Syncfusion.Blazor.Calendars.DatePickerEvents<DateTime?>>(75);
                                            __builder9.AddAttribute(76, "ValueChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Calendars.ChangedEventArgs<DateTime?>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Calendars.ChangedEventArgs<DateTime?>>(this, 
#nullable restore
#line 61 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Planillado\PlanillaNuevo.razor"
                                                                                  onChangeDate

#line default
#line hidden
#nullable disable
                                            )));
                                            __builder9.CloseComponent();
                                        }
                                        ));
                                        __builder8.CloseComponent();
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(77, "\r\n\t\t\t\t\t\t");
                                    __builder7.OpenComponent<MudBlazor.MudItem>(78);
                                    __builder7.AddAttribute(79, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 65 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Planillado\PlanillaNuevo.razor"
                                     12

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(80, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.OpenComponent<MudBlazor.MudText>(81);
                                        __builder8.AddAttribute(82, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 67 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Planillado\PlanillaNuevo.razor"
                                           Typo.caption

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(83, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder9) => {
                                            __builder9.AddMarkupContent(84, "<strong b-k73y9jnqn6>\r\n\t\t\t\t\t\t\t\t\tDescripción\r\n\t\t\t\t\t\t\t\t</strong><br b-k73y9jnqn6>\r\n\t\t\t\t\t\t\t\tRegistre una descripción acorde al periodo correspondiente. Si desea el sistema puede\r\n\t\t\t\t\t\t\t\t");
                                            __builder9.OpenComponent<MudBlazor.MudLink>(85);
                                            __builder9.AddAttribute(86, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 72 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Planillado\PlanillaNuevo.razor"
                                               Typo.caption

#line default
#line hidden
#nullable disable
                                            ));
                                            __builder9.AddAttribute(87, "Style", "cursor:pointer");
                                            __builder9.AddAttribute(88, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Planillado\PlanillaNuevo.razor"
                                                                                              onSugerir

#line default
#line hidden
#nullable disable
                                            ));
                                            __builder9.AddAttribute(89, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder10) => {
                                                __builder10.AddMarkupContent(90, "<strong b-k73y9jnqn6>sugerir</strong>");
                                            }
                                            ));
                                            __builder9.CloseComponent();
                                            __builder9.AddMarkupContent(91, "\r\n\t\t\t\t\t\t\t\tuna descripción ejemplo\r\n\t\t\t\t\t\t\t");
                                        }
                                        ));
                                        __builder8.CloseComponent();
                                        __builder8.AddMarkupContent(92, "<br b-k73y9jnqn6>\r\n\r\n\t\t\t\t\t\t\t");
                                        __builder8.OpenComponent<MudBlazor.MudTextField<string>>(93);
                                        __builder8.AddAttribute(94, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 79 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Planillado\PlanillaNuevo.razor"
                                                   Variant.Outlined

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(95, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(
#nullable restore
#line 81 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Planillado\PlanillaNuevo.razor"
                                                 () => oPlanilla.Descripcion

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(96, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 80 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Planillado\PlanillaNuevo.razor"
                                                       oPlanilla.Descripcion

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(97, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oPlanilla.Descripcion = __value, oPlanilla.Descripcion))));
                                        __builder8.CloseComponent();
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(98, "\r\n\t\t\t\t\t");
                                __builder6.OpenComponent<MudBlazor.MudGrid>(99);
                                __builder6.AddAttribute(100, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<MudBlazor.MudItem>(101);
                                    __builder7.AddAttribute(102, "Class", "d-flex");
                                    __builder7.AddAttribute(103, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.OpenElement(104, "div");
                                        __builder8.AddAttribute(105, "class", "ml-2");
                                        __builder8.AddAttribute(106, "b-k73y9jnqn6");
                                        __builder8.OpenComponent<MudBlazor.MudButton>(107);
                                        __builder8.AddAttribute(108, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.ButtonType>(
#nullable restore
#line 87 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Planillado\PlanillaNuevo.razor"
                                                       ButtonType.Submit

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(109, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 87 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Planillado\PlanillaNuevo.razor"
                                                                                   Variant.Filled

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(110, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 87 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Planillado\PlanillaNuevo.razor"
                                                                                                          Color.Success

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(111, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder9) => {
                                            __builder9.AddContent(112, "Guardar");
                                        }
                                        ));
                                        __builder8.CloseComponent();
                                        __builder8.CloseElement();
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(113, "\r\n\t\t\t\t\t\t");
                                    __builder7.OpenComponent<MudBlazor.MudItem>(114);
                                    __builder7.AddAttribute(115, "Class", "d-flex ml-auto");
                                    __builder7.AddAttribute(116, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.OpenElement(117, "div");
                                        __builder8.AddAttribute(118, "class", "ml-2");
                                        __builder8.AddAttribute(119, "b-k73y9jnqn6");
                                        __builder8.OpenComponent<MudBlazor.MudButton>(120);
                                        __builder8.AddAttribute(121, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 92 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Planillado\PlanillaNuevo.razor"
                                                    Variant.Filled

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(122, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 92 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Planillado\PlanillaNuevo.razor"
                                                                           Color.Error

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(123, "Link", "/Planillado/Planillas");
                                        __builder8.AddAttribute(124, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder9) => {
                                            __builder9.AddContent(125, "Cancelar");
                                        }
                                        ));
                                        __builder8.CloseComponent();
                                        __builder8.CloseElement();
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(126, "\r\n\t\t\t");
                        __builder4.OpenComponent<MudBlazor.MudCardActions>(127);
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
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
#pragma warning restore 1591
