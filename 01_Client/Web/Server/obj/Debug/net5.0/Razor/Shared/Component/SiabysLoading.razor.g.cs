#pragma checksum "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Shared\Component\SiabysLoading.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c32fe5f8c7e0abab369fbef3eea4f47ee450c08"
// <auto-generated/>
#pragma warning disable 1591
namespace Server.Shared.Component
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
    public partial class SiabysLoading : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudOverlay>(0);
            __builder.AddAttribute(1, "DarkBackground", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 3 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Shared\Component\SiabysLoading.razor"
                                                             true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ZIndex", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 3 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Shared\Component\SiabysLoading.razor"
                                                                           9999

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "AutoClose", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 3 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Shared\Component\SiabysLoading.razor"
                                                                                            false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 3 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Shared\Component\SiabysLoading.razor"
                           _Loading.vVisble

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "VisibleChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _Loading.vVisble = __value, _Loading.vVisble))));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudProgressCircular>(7);
                __builder2.AddAttribute(8, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 4 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Shared\Component\SiabysLoading.razor"
                                Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 4 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Shared\Component\SiabysLoading.razor"
                                                     Size.Large

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "Indeterminate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 4 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Shared\Component\SiabysLoading.razor"
                                                                                true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n\r\n\r\n\r\n");
            __builder.AddMarkupContent(12, "<style>\r\n\r\n    .mud-overlay-content {\r\n        background-image: url(svg/logosubsidio.svg);\r\n        background-repeat: no-repeat;\r\n        background-size: 28px;\r\n        background-position-x: 15px;\r\n        background-position-y: 8px;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Shared\Component\SiabysLoading.razor"
       

    protected override void OnInitialized()
    {
        _Loading.CambiarEstado += StateHasChanged;
    }

    public void Dispose()
    {
        _Loading.CambiarEstado -= StateHasChanged;
    }

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
#pragma warning restore 1591
