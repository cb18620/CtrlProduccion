#pragma checksum "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b62ee34bc832d9e3ed5f81622d0a703f8d5690a"
// <auto-generated/>
#pragma warning disable 1591
namespace Server.Pages.Pages.Utility
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/pages/utility/faq")]
    public partial class Faq : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudText>(0);
            __builder.AddAttribute(1, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 3 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
               Typo.h5

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 3 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                               Color.Primary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Class", "mb-4");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(5, "FAQ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\n");
            __builder.OpenComponent<MudBlazor.MudGrid>(7);
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudItem>(9);
                __builder2.AddAttribute(10, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 5 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                 12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 5 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                         12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 5 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                                 10

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudPaper>(14);
                    __builder3.AddAttribute(15, "Class", "px-4 pb-3 mb-8");
                    __builder3.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudTextField<string>>(17);
                        __builder4.AddAttribute(18, "Placeholder", "Search");
                        __builder4.AddAttribute(19, "DisableUnderLine", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 7 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                                                                            true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(20, "Adornment", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Adornment>(
#nullable restore
#line 7 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                                                                                             Adornment.End

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(21, "AdornmentIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                                                                                                                            Icons.Filled.Search

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\n    ");
                __builder2.OpenComponent<MudBlazor.MudItem>(23);
                __builder2.AddAttribute(24, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                 12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                         12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                                 2

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\n    ");
                __builder2.OpenComponent<MudBlazor.MudItem>(28);
                __builder2.AddAttribute(29, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 11 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                 12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 11 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                         12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 11 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                                 10

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudText>(33);
                    __builder3.AddAttribute(34, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 12 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                       Typo.h6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(35, "GutterBottom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                                              true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(37, "General");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(38, "\n        ");
                    __builder3.OpenComponent<MudBlazor.MudExpansionPanels>(39);
                    __builder3.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudExpansionPanel>(41);
                        __builder4.AddAttribute(42, "Text", "How do i install MudBlazor?");
                        __builder4.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudText>(44);
                            __builder5.AddAttribute(45, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 15 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                               Typo.body2

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(47, "Please check the installation instructions ");
                                __builder6.OpenComponent<MudBlazor.MudLink>(48);
                                __builder6.AddAttribute(49, "Href", "https://mudblazor.com/getting-started/installation");
                                __builder6.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(51, "here");
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(52, "\n            ");
                        __builder4.OpenComponent<MudBlazor.MudExpansionPanel>(53);
                        __builder4.AddAttribute(54, "Text", "Whats the purpose of this template");
                        __builder4.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudText>(56);
                            __builder5.AddAttribute(57, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 18 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                               Typo.body2

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(59, "Mostly for demonstration purposes but can be stripped and used for any project, in any way.");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(60, "\n            ");
                        __builder4.OpenComponent<MudBlazor.MudExpansionPanel>(61);
                        __builder4.AddAttribute(62, "Text", "How can i get help regarding MudBlazor?");
                        __builder4.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudText>(64);
                            __builder5.AddAttribute(65, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 21 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                               Typo.body2

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(67, "You can find links to our community chats on our main ");
                                __builder6.OpenComponent<MudBlazor.MudLink>(68);
                                __builder6.AddAttribute(69, "Href", "https://mudblazor.com/");
                                __builder6.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(71, "website");
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(72, "\n            ");
                        __builder4.OpenComponent<MudBlazor.MudExpansionPanel>(73);
                        __builder4.AddAttribute(74, "Text", "I have a question or a problem regarding this template");
                        __builder4.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudText>(76);
                            __builder5.AddAttribute(77, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 24 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                               Typo.body2

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(78, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(79, "While we dont offer any real support, you can always try to ask for help in one of our community groups.");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(80, "\n            ");
                        __builder4.OpenComponent<MudBlazor.MudExpansionPanel>(81);
                        __builder4.AddAttribute(82, "Text", "You guys are awesome, how can i support you?");
                        __builder4.AddAttribute(83, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudText>(84);
                            __builder5.AddAttribute(85, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 27 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                               Typo.body2

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(86, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(87, "Helping out others who have questions regarding Mudblazor in our Discord or Gitter chat is highly appreciated! Adding and fixing issues, working on new features that we have planned or you can donate over at ");
                                __builder6.OpenComponent<MudBlazor.MudLink>(88);
                                __builder6.AddAttribute(89, "Href", "https://opencollective.com/mudblazor");
                                __builder6.AddAttribute(90, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(91, "our Open Collective page.");
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(92, "\n\n        ");
                    __builder3.OpenComponent<MudBlazor.MudText>(93);
                    __builder3.AddAttribute(94, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 31 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                       Typo.h6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(95, "GutterBottom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 31 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                                              true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(96, "Class", "mt-8");
                    __builder3.AddAttribute(97, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(98, "Licensing");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(99, "\n        ");
                    __builder3.OpenComponent<MudBlazor.MudExpansionPanels>(100);
                    __builder3.AddAttribute(101, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudExpansionPanel>(102);
                        __builder4.AddAttribute(103, "Text", "Unlimited");
                        __builder4.AddAttribute(104, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudText>(105);
                            __builder5.AddAttribute(106, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 34 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                               Typo.body2

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(107, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(108, "Do what you want, its MIT.");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(109, "\n            ");
                        __builder4.OpenComponent<MudBlazor.MudExpansionPanel>(110);
                        __builder4.AddAttribute(111, "Text", "Commercial");
                        __builder4.AddAttribute(112, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudText>(113);
                            __builder5.AddAttribute(114, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 37 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                               Typo.body2

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(115, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(116, "Duuude, i said MIT!");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(117, "\n            ");
                        __builder4.OpenComponent<MudBlazor.MudExpansionPanel>(118);
                        __builder4.AddAttribute(119, "Text", "Personal");
                        __builder4.AddAttribute(120, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudText>(121);
                            __builder5.AddAttribute(122, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 40 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                               Typo.body2

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(123, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(124, "M.I.T");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(125, "\n\n        ");
                    __builder3.OpenComponent<MudBlazor.MudText>(126);
                    __builder3.AddAttribute(127, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 44 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                       Typo.h6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(128, "GutterBottom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 44 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                                              true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(129, "Class", "mt-8");
                    __builder3.AddAttribute(130, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(131, "Refund Policy");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(132, "\n        ");
                    __builder3.OpenComponent<MudBlazor.MudExpansionPanels>(133);
                    __builder3.AddAttribute(134, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudExpansionPanel>(135);
                        __builder4.AddAttribute(136, "Text", "Can i refund MudBlazor?");
                        __builder4.AddAttribute(137, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudText>(138);
                            __builder5.AddAttribute(139, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 47 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                               Typo.body2

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(140, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(141, "No you cant, since its a open source, MIT project and is free to use.");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(142, "\n            ");
                        __builder4.OpenComponent<MudBlazor.MudExpansionPanel>(143);
                        __builder4.AddAttribute(144, "Text", "What if i still want a refund?");
                        __builder4.AddAttribute(145, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudText>(146);
                            __builder5.AddAttribute(147, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 50 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                               Typo.body2

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(148, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(149, "Well you\'r out of luck here.");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(150, "\n    ");
                __builder2.OpenComponent<MudBlazor.MudItem>(151);
                __builder2.AddAttribute(152, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 54 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                 12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(153, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 54 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                         12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(154, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 54 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                                 2

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(155, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudText>(156);
                    __builder3.AddAttribute(157, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 55 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                       Typo.h6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(158, "GutterBottom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 55 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                                              true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(159, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(160, "Categorys");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(161, "\n        ");
                    __builder3.OpenComponent<MudBlazor.MudButton>(162);
                    __builder3.AddAttribute(163, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 56 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                            Variant.Text

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(164, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 56 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                                                 Color.Secondary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(165, "Class", "d-flex");
                    __builder3.AddAttribute(166, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(167, "General");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(168, "\n        ");
                    __builder3.OpenComponent<MudBlazor.MudButton>(169);
                    __builder3.AddAttribute(170, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 57 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                            Variant.Text

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(171, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 57 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                                                 Color.Secondary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(172, "Class", "d-flex");
                    __builder3.AddAttribute(173, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(174, "Licenses");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(175, "\n        ");
                    __builder3.OpenComponent<MudBlazor.MudButton>(176);
                    __builder3.AddAttribute(177, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 58 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                            Variant.Text

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(178, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 58 "D:\source\SourceCodeCleanArchi\01_Client\Web\Server\Pages\Pages\Utility\Faq.razor"
                                                 Color.Secondary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(179, "Class", "d-flex");
                    __builder3.AddAttribute(180, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(181, "Refund Policy");
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
