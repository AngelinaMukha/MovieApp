#pragma checksum "C:\Users\User\Desktop\APBD\Tutorial12\tutorial-12-AngelinaMukha\MovieApp\MovieApp\Client\Pages\AddMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28a523062485722a899e44adc5269b9be6051183"
// <auto-generated/>
#pragma warning disable 1591
namespace MovieApp.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddMovie")]
    public partial class AddMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 style=\"font-family: \'Rock Salt\', cursive\">Create movie</h1>\r\n<br>\r\n    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "column");
            __builder.AddMarkupContent(5, "<lable>Title: </lable>\r\n            ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "type", "text");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\User\Desktop\APBD\Tutorial12\tutorial-12-AngelinaMukha\MovieApp\MovieApp\Client\Pages\AddMovie.razor"
                                       movie.Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => movie.Title = __value, movie.Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n            <br>\r\n            <br>\r\n            ");
            __builder.AddMarkupContent(11, "<lable>Summary: </lable>\r\n            ");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "type", "text");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\User\Desktop\APBD\Tutorial12\tutorial-12-AngelinaMukha\MovieApp\MovieApp\Client\Pages\AddMovie.razor"
                                       movie.Summary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => movie.Summary = __value, movie.Summary));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            <br>\r\n            <br>\r\n            ");
            __builder.AddMarkupContent(17, "<lable>InTheaters: </lable>\r\n            ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "type", "checkbox");
            __builder.AddAttribute(20, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\User\Desktop\APBD\Tutorial12\tutorial-12-AngelinaMukha\MovieApp\MovieApp\Client\Pages\AddMovie.razor"
                                           movie.InTheaters

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => movie.InTheaters = __value, movie.InTheaters));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            <br>\r\n            <br>\r\n            ");
            __builder.AddMarkupContent(23, "<lable>ReleaseDate: </lable>\r\n            ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "type", "date");
            __builder.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\User\Desktop\APBD\Tutorial12\tutorial-12-AngelinaMukha\MovieApp\MovieApp\Client\Pages\AddMovie.razor"
                                       movie.ReleaseDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => movie.ReleaseDate = __value, movie.ReleaseDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "column");
            __builder.AddMarkupContent(31, "<lable>Poster: </lable>\r\n            ");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "style", "border-radius: 10px;");
            __builder.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "C:\Users\User\Desktop\APBD\Tutorial12\tutorial-12-AngelinaMukha\MovieApp\MovieApp\Client\Pages\AddMovie.razor"
                                                        movie.Poster

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => movie.Poster = __value, movie.Poster));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            <br><br>\r\n            ");
            __builder.AddMarkupContent(37, "<style>\r\n                lable, input {\r\n                    font-family: \'Rock Salt\', cursive;\r\n                    border-radius: 10px;\r\n                    text-align: center;\r\n                }\r\n            </style>");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "column");
            __builder.AddMarkupContent(41, "<lable>Trailer: </lable>\r\n            ");
            __builder.OpenElement(42, "input");
            __builder.AddAttribute(43, "style", "border-radius: 10px;");
            __builder.AddAttribute(44, "type", "text");
            __builder.AddAttribute(45, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "C:\Users\User\Desktop\APBD\Tutorial12\tutorial-12-AngelinaMukha\MovieApp\MovieApp\Client\Pages\AddMovie.razor"
                                                                     movie.Trailer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => movie.Trailer = __value, movie.Trailer));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "<br><br>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(49, "<style>\r\n        .column {\r\n            float: left;\r\n            width: 30%;\r\n            text-align: center;\r\n        }\r\n\r\n        .lable, input {\r\n            border-radius: 10px;\r\n            text-align: center;\r\n        }\r\n    </style>\r\n    ");
            __builder.OpenElement(50, "button");
            __builder.AddAttribute(51, "class", "btn btn-edit");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "C:\Users\User\Desktop\APBD\Tutorial12\tutorial-12-AngelinaMukha\MovieApp\MovieApp\Client\Pages\AddMovie.razor"
                                           NewForm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "type", "button");
            __builder.AddAttribute(54, "style", "background-color:orangered; border-color: red; color:white; border-radius: 10px; float: left;");
            __builder.AddContent(55, "Return");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n    ");
            __builder.OpenElement(57, "button");
            __builder.AddAttribute(58, "class", "btn btn-edit");
            __builder.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\User\Desktop\APBD\Tutorial12\tutorial-12-AngelinaMukha\MovieApp\MovieApp\Client\Pages\AddMovie.razor"
                                             () => AddingMovie(movie)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "type", "button");
            __builder.AddAttribute(61, "style", "background-color:limegreen; border-color: green; color:white; border-radius: 10px; float: right;");
            __builder.AddContent(62, "Save");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "C:\Users\User\Desktop\APBD\Tutorial12\tutorial-12-AngelinaMukha\MovieApp\MovieApp\Client\Pages\AddMovie.razor"
       
    public List<Movie> Movies { get; set; }
    public Movie movie { get; set; } = new Movie();

    protected override async Task OnInitializedAsync()
    {
        await Task.Delay(1000);

        var result = await httpClient.GetAsync("/api/movies");
        var data = await result.Content.ReadAsStringAsync();
        Movies = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Movie>>(data);
    }

    private async Task NewForm()
    {
        await Task.Run(() => NavManager.NavigateTo("/movies"));
    }

    private async Task AddingMovie(Movie movie)
    {
        Movie NewMovie = new Movie
        {
            Id = movie.Id,
            Title = movie.Title,
            Summary = movie.Summary,
            InTheaters = movie.InTheaters,
            ReleaseDate = movie.ReleaseDate,
            Poster = movie.Poster,
            Trailer = movie.Trailer
        };
        await moviesRepository.CreateMovie(NewMovie);
        await OnInitializedAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMoviesRepository moviesRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591
