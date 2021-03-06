#pragma checksum "D:\Blazor\HappySnailJavascriptInBlazor\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02160561693b712876589f3e59a4208ade321c08"
// <auto-generated/>
#pragma warning disable 1591
namespace HappySnailJavascriptInBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Blazor\HappySnailJavascriptInBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Blazor\HappySnailJavascriptInBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Blazor\HappySnailJavascriptInBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Blazor\HappySnailJavascriptInBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Blazor\HappySnailJavascriptInBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Blazor\HappySnailJavascriptInBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Blazor\HappySnailJavascriptInBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Blazor\HappySnailJavascriptInBlazor\_Imports.razor"
using HappySnailJavascriptInBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Blazor\HappySnailJavascriptInBlazor\_Imports.razor"
using HappySnailJavascriptInBlazor.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"text-center\"><h1>Hello, snails!</h1>\r\n\r\n    Let\'s add some Javascript!\r\n</div>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "text-center");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "class", "btn btn-primary");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "D:\Blazor\HappySnailJavascriptInBlazor\Pages\Index.razor"
                                              AlertBox

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(6, "Alert Window!");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    <br>\r\n    <br>\r\n    <input type=\"text\" id=\"text_input\" style=\"margin: 5px;\">\r\n    <br>\r\n    ");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "class", "btn btn-primary");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "D:\Blazor\HappySnailJavascriptInBlazor\Pages\Index.razor"
                                              PrintTextBox

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(11, "Print Text Box");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    <br>\r\n    Fahrenheit: ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "type", "number");
            __builder.AddAttribute(15, "min", "-1000");
            __builder.AddAttribute(16, "style", "margin: 5px;");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "D:\Blazor\HappySnailJavascriptInBlazor\Pages\Index.razor"
                                                                                   fahrenheit

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(18, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => fahrenheit = __value, fahrenheit, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "class", "btn btn-primary");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "D:\Blazor\HappySnailJavascriptInBlazor\Pages\Index.razor"
                                              () => ConvertToCelsius(fahrenheit)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, "Convert to Celsius");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "D:\Blazor\HappySnailJavascriptInBlazor\Pages\Index.razor"
       
    float celsius = 0.0f;
    float fahrenheit = 0.0f;

    private void AlertBox()
    {
        iJSRuntime.InvokeVoidAsync("alert", "JS Alert box appeared!");
    }

    private void PrintTextBox()
    {
        iJSRuntime.InvokeVoidAsync("PrintTextBox", "text_input");
    }

    private async void ConvertToCelsius(float far)
    {
        celsius = await iJSRuntime.InvokeAsync<float>("ConvertToCelsius", fahrenheit);
        await iJSRuntime.InvokeVoidAsync("alert", fahrenheit + "F is " + celsius + "C");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime iJSRuntime { get; set; }
    }
}
#pragma warning restore 1591
