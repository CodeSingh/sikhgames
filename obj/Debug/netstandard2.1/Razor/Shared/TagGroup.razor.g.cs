#pragma checksum "C:\Users\sony\Documents\blazor\sikhgames\Shared\TagGroup.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "259a7d51f40721f3b7d16c6e21798f7daee2fa1d"
// <auto-generated/>
#pragma warning disable 1591
namespace sikhgames.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sony\Documents\blazor\sikhgames\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sony\Documents\blazor\sikhgames\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sony\Documents\blazor\sikhgames\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sony\Documents\blazor\sikhgames\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sony\Documents\blazor\sikhgames\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sony\Documents\blazor\sikhgames\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sony\Documents\blazor\sikhgames\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sony\Documents\blazor\sikhgames\_Imports.razor"
using sikhgames;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sony\Documents\blazor\sikhgames\_Imports.razor"
using sikhgames.Shared;

#line default
#line hidden
#nullable disable
    public partial class TagGroup : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "tags");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 2 "C:\Users\sony\Documents\blazor\sikhgames\Shared\TagGroup.razor"
 foreach (var item in Tags)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "span");
            __builder.AddAttribute(5, "class", "badge-bg badge-pill badge-warning");
            __builder.AddContent(6, 
#nullable restore
#line 4 "C:\Users\sony\Documents\blazor\sikhgames\Shared\TagGroup.razor"
                                                     item

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 5 "C:\Users\sony\Documents\blazor\sikhgames\Shared\TagGroup.razor"
}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\sony\Documents\blazor\sikhgames\Shared\TagGroup.razor"
       
    // Demonstrates how a parent component can supply parameters
    [Parameter]
    public string[] Tags { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
