#pragma checksum "C:\Users\sony\Documents\blazor\sikhgames\Shared\Modal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e61a8767c5759bf600b467864b691ca10a4a940"
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
    public partial class Modal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<button type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#myModal\">\r\n  Open modal\r\n</button>\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, @"<div class=""modal"" id=""myModal"">
  <div class=""modal-dialog"">
    <div class=""modal-content"">

      
      <div class=""modal-header"">
        <h4 class=""modal-title"">Modal Heading</h4>
        <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
      </div>

      
      <div class=""modal-body"">
        Modal body..
      </div>

      
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Close</button>
      </div>

    </div>
  </div>
</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591