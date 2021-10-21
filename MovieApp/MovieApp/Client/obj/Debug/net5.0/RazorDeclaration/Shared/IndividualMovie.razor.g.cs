// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MovieApp.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\CV\Projects\С#\MovieApp\MovieApplication\MovieApp\MovieApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CV\Projects\С#\MovieApp\MovieApplication\MovieApp\MovieApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\CV\Projects\С#\MovieApp\MovieApplication\MovieApp\MovieApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\CV\Projects\С#\MovieApp\MovieApplication\MovieApp\MovieApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\CV\Projects\С#\MovieApp\MovieApplication\MovieApp\MovieApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\CV\Projects\С#\MovieApp\MovieApplication\MovieApp\MovieApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\CV\Projects\С#\MovieApp\MovieApplication\MovieApp\MovieApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\CV\Projects\С#\MovieApp\MovieApplication\MovieApp\MovieApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\CV\Projects\С#\MovieApp\MovieApplication\MovieApp\MovieApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\CV\Projects\С#\MovieApp\MovieApplication\MovieApp\MovieApp\Client\_Imports.razor"
using MovieApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\CV\Projects\С#\MovieApp\MovieApplication\MovieApp\MovieApp\Client\_Imports.razor"
using MovieApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\CV\Projects\С#\MovieApp\MovieApplication\MovieApp\MovieApp\Client\_Imports.razor"
using MovieApp.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\CV\Projects\С#\MovieApp\MovieApplication\MovieApp\MovieApp\Client\_Imports.razor"
using MovieApp.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\CV\Projects\С#\MovieApp\MovieApplication\MovieApp\MovieApp\Client\_Imports.razor"
using MovieApp.Client.Repositories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\CV\Projects\С#\MovieApp\MovieApplication\MovieApp\MovieApp\Client\_Imports.razor"
using MovieApp.Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\CV\Projects\С#\MovieApp\MovieApplication\MovieApp\MovieApp\Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\CV\Projects\С#\MovieApp\MovieApplication\MovieApp\MovieApp\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\CV\Projects\С#\MovieApp\MovieApplication\MovieApp\MovieApp\Client\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\CV\Projects\С#\MovieApp\MovieApplication\MovieApp\MovieApp\Client\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
    public partial class IndividualMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "D:\CV\Projects\С#\MovieApp\MovieApplication\MovieApp\MovieApp\Client\Shared\IndividualMovie.razor"
       
    [Parameter] public Movie Movie { get; set; }
    [Parameter] public EventCallback<Movie> DeleteMovie { get; set; }
    private string movieURL = string.Empty;

    protected override void OnInitialized()
    {
        movieURL = $"movie/{Movie.Id}/{Movie.Title.Replace(" ", "-")}";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
