#pragma checksum "C:\Users\jaime\Desktop\Peliculas\Client\Pages\Actors\CreateActor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "069f242bc97f813344438a05c8a5220b21f76be8"
// <auto-generated/>
#pragma warning disable 1591
namespace peliculas.Client.Pages.Actors
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\jaime\Desktop\Peliculas\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jaime\Desktop\Peliculas\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jaime\Desktop\Peliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jaime\Desktop\Peliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jaime\Desktop\Peliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jaime\Desktop\Peliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jaime\Desktop\Peliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jaime\Desktop\Peliculas\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jaime\Desktop\Peliculas\Client\_Imports.razor"
using peliculas.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\jaime\Desktop\Peliculas\Client\_Imports.razor"
using peliculas.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\jaime\Desktop\Peliculas\Client\_Imports.razor"
using Peliculas.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\jaime\Desktop\Peliculas\Client\_Imports.razor"
using Peliculas.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jaime\Desktop\Peliculas\Client\Pages\Actors\CreateActor.razor"
using peliculas.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/actors/create")]
    public partial class CreateActor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<peliculas.Client.Pages.Components.FormActors>(0);
            __builder.AddAttribute(1, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 4 "C:\Users\jaime\Desktop\Peliculas\Client\Pages\Actors\CreateActor.razor"
                            Create

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(2, "Actor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Peliculas.Shared.Entity.Actor>(
#nullable restore
#line 4 "C:\Users\jaime\Desktop\Peliculas\Client\Pages\Actors\CreateActor.razor"
                                            Actor

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Users\jaime\Desktop\Peliculas\Client\Pages\Actors\CreateActor.razor"
      
    private Actor Actor = new Actor();
    void Create(){
        Console.WriteLine("");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
