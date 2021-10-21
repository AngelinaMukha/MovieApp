#pragma checksum "C:\Users\User\Desktop\APBD\Tutorial12\tutorial-12-AngelinaMukha\MovieApp\MovieApp\Client\Shared\IndividualMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "697b94baccbb7758cf70952aa6769b579253291b"
// <auto-generated/>
#pragma warning disable 1591
namespace MovieApp.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\Desktop\APBD\Tutorial12\tutorial-12-AngelinaMukha\MovieApp\MovieApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\APBD\Tutorial12\tutorial-12-AngelinaMukha\MovieApp\MovieApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\APBD\Tutorial12\tutorial-12-AngelinaMukha\MovieApp\MovieApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\APBD\Tutorial12\tutorial-12-AngelinaMukha\MovieApp\MovieApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\APBD\Tutorial12\tutorial-12-AngelinaMukha\MovieApp\MovieApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\APBD\Tutorial12\tutorial-12-AngelinaMukha\MovieApp\MovieApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\APBD\Tutorial12\tutorial-12-AngelinaMukha\MovieApp\MovieApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Desktop\APBD\Tutorial12\tutorial-12-AngelinaMukha\MovieApp\MovieApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\Desktop\APBD\Tutorial12\tutorial-12-AngelinaMukha\MovieApp\MovieApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\Desktop\APBD\Tutorial12\tutorial-12-AngelinaMukha\MovieApp\MovieApp\Client\_Imports.razor"
using MovieApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\Desktop\APBD\Tutorial12\tutorial-12-AngelinaMukha\MovieApp\MovieApp\Client\_Imports.razor"
using MovieApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\User\Desktop\APBD\Tutorial12\tutorial-12-AngelinaMukha\MovieApp\MovieApp\Client\_Imports.razor"
using MovieApp.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\User\Desktop\APBD\Tutorial12\tutorial-12-AngelinaMukha\MovieApp\MovieApp\Client\_Imports.razor"
using MovieApp.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\User\Desktop\APBD\Tutorial12\tutorial-12-AngelinaMukha\MovieApp\MovieApp\Client\_Imports.razor"
using MovieApp.Client.Repositories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\User\Desktop\APBD\Tutorial12\tutorial-12-AngelinaMukha\MovieApp\MovieApp\Client\_Imports.razor"
using MovieApp.Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\User\Desktop\APBD\Tutorial12\tutorial-12-AngelinaMukha\MovieApp\MovieApp\Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\User\Desktop\APBD\Tutorial12\tutorial-12-AngelinaMukha\MovieApp\MovieApp\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\User\Desktop\APBD\Tutorial12\tutorial-12-AngelinaMukha\MovieApp\MovieApp\Client\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\User\Desktop\APBD\Tutorial12\tutorial-12-AngelinaMukha\MovieApp\MovieApp\Client\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
    public partial class IndividualMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "individual-movie-container");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.OpenElement(4, "tr");
            __builder.OpenElement(5, "td");
            __builder.AddAttribute(6, "rowspan", "2");
            __builder.AddAttribute(7, "width", "20%");
            __builder.AddAttribute(8, "align", "center");
            __builder.OpenElement(9, "a");
            __builder.AddAttribute(10, "href", 
#nullable restore
#line 6 "C:\Users\User\Desktop\APBD\Tutorial12\tutorial-12-AngelinaMukha\MovieApp\MovieApp\Client\Shared\IndividualMovie.razor"
                          movieURL

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(11, "img");
            __builder.AddAttribute(12, "src", 
#nullable restore
#line 7 "C:\Users\User\Desktop\APBD\Tutorial12\tutorial-12-AngelinaMukha\MovieApp\MovieApp\Client\Shared\IndividualMovie.razor"
                               Movie.Poster

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "alt", "Poster");
            __builder.AddAttribute(14, "class", "movie-poster");
            __builder.AddAttribute(15, "width", "150");
            __builder.AddAttribute(16, "height", "210");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "td");
            __builder.AddAttribute(19, "width", "60%");
            __builder.OpenElement(20, "h3");
            __builder.AddContent(21, 
#nullable restore
#line 10 "C:\Users\User\Desktop\APBD\Tutorial12\tutorial-12-AngelinaMukha\MovieApp\MovieApp\Client\Shared\IndividualMovie.razor"
                                 Movie.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "td");
            __builder.AddAttribute(24, "rowspan", "2");
            __builder.AddAttribute(25, "align", "center");
            __builder.AddAttribute(26, "width", "20%");
            __builder.OpenElement(27, "a");
            __builder.AddAttribute(28, "class", "btn btn-info");
            __builder.AddAttribute(29, "href", "/movies/edit/" + (
#nullable restore
#line 12 "C:\Users\User\Desktop\APBD\Tutorial12\tutorial-12-AngelinaMukha\MovieApp\MovieApp\Client\Shared\IndividualMovie.razor"
                                                            Movie.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(30, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "<br><br>\r\n                ");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "type", "button");
            __builder.AddAttribute(34, "class", "btn btn-danger");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\User\Desktop\APBD\Tutorial12\tutorial-12-AngelinaMukha\MovieApp\MovieApp\Client\Shared\IndividualMovie.razor"
                                    () => DeleteMovie.InvokeAsync(Movie)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(36, "\r\n                    Delete\r\n                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.OpenElement(38, "tr");
            __builder.OpenElement(39, "th");
            __builder.AddAttribute(40, "width", "60%");
            __builder.AddContent(41, 
#nullable restore
#line 20 "C:\Users\User\Desktop\APBD\Tutorial12\tutorial-12-AngelinaMukha\MovieApp\MovieApp\Client\Shared\IndividualMovie.razor"
                             Movie.Summary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n    ");
            __builder.AddMarkupContent(43, "<style>\r\n        th, td {\r\n            font-family: \'Rock Salt\', cursive;\r\n        }\r\n\r\n        table {\r\n            border-collapse: collapse;\r\n            width: 100%;\r\n        }\r\n    </style>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\User\Desktop\APBD\Tutorial12\tutorial-12-AngelinaMukha\MovieApp\MovieApp\Client\Shared\IndividualMovie.razor"
       
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
