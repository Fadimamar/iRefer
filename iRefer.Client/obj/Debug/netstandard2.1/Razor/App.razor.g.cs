#pragma checksum "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87d0327518a587291c140cd92409f33b72a4fbb5"
// <auto-generated/>
#pragma warning disable 1591
namespace iRefer.Client
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\_Imports.razor"
using iRefer.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\_Imports.razor"
using iRefer.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\_Imports.razor"
using iRefer.Shared.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\_Imports.razor"
using iRefer.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\_Imports.razor"
using Blazor.FileReader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\App.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\App.razor"
using iRefer.Client.Pages.Auth;

#line default
#line hidden
#nullable disable
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(0);
            __builder.AddAttribute(1, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 4 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\App.razor"
                      typeof(Program).Assembly

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeRouteView>(4);
                __builder2.AddAttribute(5, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 6 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\App.razor"
                                        routeData

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 6 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\App.razor"
                                                                   typeof(MainLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(8, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n    ");
            }
            ));
            __builder.AddAttribute(10, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(12);
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(14, "\r\n            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(15);
                    __builder3.AddAttribute(16, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 14 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\App.razor"
                                 typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(18, "\r\n                ");
                        __builder4.AddMarkupContent(19, "<p>Sorry, there\'s nothing at this address.</p>\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(20, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
