// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LifecycleBlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\LENOVO\source\repos\LifecycleBlazorApp\LifecycleBlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO\source\repos\LifecycleBlazorApp\LifecycleBlazorApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\LENOVO\source\repos\LifecycleBlazorApp\LifecycleBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\LENOVO\source\repos\LifecycleBlazorApp\LifecycleBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\LENOVO\source\repos\LifecycleBlazorApp\LifecycleBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\LENOVO\source\repos\LifecycleBlazorApp\LifecycleBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\LENOVO\source\repos\LifecycleBlazorApp\LifecycleBlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\LENOVO\source\repos\LifecycleBlazorApp\LifecycleBlazorApp\_Imports.razor"
using LifecycleBlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\LENOVO\source\repos\LifecycleBlazorApp\LifecycleBlazorApp\_Imports.razor"
using LifecycleBlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO\source\repos\LifecycleBlazorApp\LifecycleBlazorApp\Pages\Counter.razor"
using LifecycleBlazorApp.Store.CounterStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\LENOVO\source\repos\LifecycleBlazorApp\LifecycleBlazorApp\Pages\Counter.razor"
using LifecycleBlazorApp.Store;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\LENOVO\source\repos\LifecycleBlazorApp\LifecycleBlazorApp\Pages\Counter.razor"
      
    private void IncrementCount()
    {
        dispatcher.Dispatcher(new IncrementAction());
    }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        counterstore.AddStateChangeListener(() => { StateHasChanged(); });
    }

    public void Dispose()
    {
        counterstore.RemoveStateChangeListener(() => { StateHasChanged(); });
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IActionDispatcher dispatcher { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CounterStore counterstore { get; set; }
    }
}
#pragma warning restore 1591
