#pragma checksum "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\Shared\UserStatus.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f71c7c701772385a5f8b557bfc4413484789c4cb"
// <auto-generated/>
#pragma warning disable 1591
namespace iRefer.Client.Shared
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
#line 12 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

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
    public partial class UserStatus : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n    ");
                __builder2.OpenElement(3, "span");
                __builder2.AddContent(4, "Welcome ");
                __builder2.AddContent(5, 
#nullable restore
#line 5 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\Shared\UserStatus.razor"
                   context.User.FindFirst("FirstName").Value

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(6, " ");
                __builder2.CloseElement();
                __builder2.AddContent(7, "   ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(8);
                __builder2.AddAttribute(9, "Text", "Logout");
                __builder2.AddAttribute(10, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\Shared\UserStatus.razor"
                                                                                                               Logout

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(11, "class", "mr-2");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\Shared\UserStatus.razor"
       

    async Task Logout()
    {
        var localStateProvider = (LocalAuthenticationStateProvider)authenticationStateProvider;
        await localStateProvider.LogoutAsync();
        navigationManager.NavigateTo("/auth/login"); 
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
