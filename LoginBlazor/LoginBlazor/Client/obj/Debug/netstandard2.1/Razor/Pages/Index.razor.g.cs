#pragma checksum "C:\Users\LENOVO\source\repos\LoginBlazor\LoginBlazor\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eab4d125a60e686d0c4bf01d7ed3e3067b397eee"
// <auto-generated/>
#pragma warning disable 1591
namespace LoginBlazor.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\LENOVO\source\repos\LoginBlazor\LoginBlazor\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO\source\repos\LoginBlazor\LoginBlazor\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\LENOVO\source\repos\LoginBlazor\LoginBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\LENOVO\source\repos\LoginBlazor\LoginBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\LENOVO\source\repos\LoginBlazor\LoginBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\LENOVO\source\repos\LoginBlazor\LoginBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\LENOVO\source\repos\LoginBlazor\LoginBlazor\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\LENOVO\source\repos\LoginBlazor\LoginBlazor\Client\_Imports.razor"
using LoginBlazor.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\LENOVO\source\repos\LoginBlazor\LoginBlazor\Client\_Imports.razor"
using LoginBlazor.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\LENOVO\source\repos\LoginBlazor\LoginBlazor\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\LENOVO\source\repos\LoginBlazor\LoginBlazor\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\LENOVO\source\repos\LoginBlazor\LoginBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\LENOVO\source\repos\LoginBlazor\LoginBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "h1");
                __builder2.AddContent(3, "Hi, ");
                __builder2.AddContent(4, 
#nullable restore
#line 5 "C:\Users\LENOVO\source\repos\LoginBlazor\LoginBlazor\Client\Pages\Index.razor"
                 context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(5, ". Welcome back!");
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(6, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(7, "<h1>Welcome to Blazor !</h1>\r\n        ");
                __builder2.OpenComponent<LoginBlazor.Client.Pages.Login>(8);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591