#pragma checksum "C:\Users\Fiifi Ansah\source\repos\etickets\etickets\Views\Movies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d257948c96475e3fe64943dabe050d9aa0f6efe1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Index), @"mvc.1.0.view", @"/Views/Movies/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Fiifi Ansah\source\repos\etickets\etickets\Views\_ViewImports.cshtml"
using etickets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fiifi Ansah\source\repos\etickets\etickets\Views\_ViewImports.cshtml"
using etickets.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d257948c96475e3fe64943dabe050d9aa0f6efe1", @"/Views/Movies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9682f433f500f4096ee2272fdaeb6342f55332df", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Movies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Movie>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Fiifi Ansah\source\repos\etickets\etickets\Views\Movies\Index.cshtml"
  
    ViewData["Title"] = "Display Movies";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Fiifi Ansah\source\repos\etickets\etickets\Views\Movies\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col-md-4 col-xs-6 border-primary mb-3"">
            <div class=""card mb-3"" style=""max-width: 540px;"">
                <div class=""row g-0"">
                    <div class=""col-md-12"">
                        <div class=""card-header text-white bg-info"">
                            <p class=""card-text"">
                                <h5 class=""card-title"">
                                 ");
#nullable restore
#line 17 "C:\Users\Fiifi Ansah\source\repos\etickets\etickets\Views\Movies\Index.cshtml"
                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    <a class=""text-white float-right""><i class=""bi bi-pencil-square""></i></a>
                                </h5>
                            </p>
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <img");
            BeginWriteAttribute("src", " src=\"", 888, "\"", 908, 1);
#nullable restore
#line 24 "C:\Users\Fiifi Ansah\source\repos\etickets\etickets\Views\Movies\Index.cshtml"
WriteAttributeValue("", 894, item.ImageURL, 894, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100%\"");
            BeginWriteAttribute("alt", " alt=\"", 922, "\"", 938, 1);
#nullable restore
#line 24 "C:\Users\Fiifi Ansah\source\repos\etickets\etickets\Views\Movies\Index.cshtml"
WriteAttributeValue("", 928, item.Name, 928, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"col-md-6\">\r\n                        <div class=\"card-body\">\r\n                            <p class=\"card-text\">");
#nullable restore
#line 28 "C:\Users\Fiifi Ansah\source\repos\etickets\etickets\Views\Movies\Index.cshtml"
                                            Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\"><b>Cinema: </b>");
#nullable restore
#line 29 "C:\Users\Fiifi Ansah\source\repos\etickets\etickets\Views\Movies\Index.cshtml"
                                                           Write(item.Cinema.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\"><b>Category: </b>");
#nullable restore
#line 30 "C:\Users\Fiifi Ansah\source\repos\etickets\etickets\Views\Movies\Index.cshtml"
                                                             Write(item.MovieCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\"><b>Start Date: </b>");
#nullable restore
#line 31 "C:\Users\Fiifi Ansah\source\repos\etickets\etickets\Views\Movies\Index.cshtml"
                                                               Write(item.StartDate.ToString("dd MMM yy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\"><b>End Date: </b>");
#nullable restore
#line 32 "C:\Users\Fiifi Ansah\source\repos\etickets\etickets\Views\Movies\Index.cshtml"
                                                             Write(item.EndDate.ToString("dd MMM yy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\">\r\n                                <b>Status: </b>\r\n");
#nullable restore
#line 35 "C:\Users\Fiifi Ansah\source\repos\etickets\etickets\Views\Movies\Index.cshtml"
                                 if(DateTime.Now >= item.StartDate && DateTime.Now <=item.EndDate)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge bg-success text-white\">AVAILABLE </span>\r\n");
#nullable restore
#line 38 "C:\Users\Fiifi Ansah\source\repos\etickets\etickets\Views\Movies\Index.cshtml"
                                }
                                  else if(DateTime.Now > item.EndDate)
                                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge bg-danger text-white\">EXPIRED </span>\r\n");
#nullable restore
#line 42 "C:\Users\Fiifi Ansah\source\repos\etickets\etickets\Views\Movies\Index.cshtml"


                                  }else
                                  {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge bg-primary text-white\"> UPCOMING</span>\r\n");
#nullable restore
#line 48 "C:\Users\Fiifi Ansah\source\repos\etickets\etickets\Views\Movies\Index.cshtml"

                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                              
                            </p>

                        </div>
                    </div>
                    <div class=""col-md-12"">
                        <div class=""card-footer "">
                            <p class=""card-text"">
                                <a class=""btn btn-outline-primary float-right""><i class=""bi bi-eye-fill""></i> Show Details</a>
                                <a class=""btn btn-success text-white""><i class=""bi bi-cart-plus""></i> Add to Cart Price ");
#nullable restore
#line 59 "C:\Users\Fiifi Ansah\source\repos\etickets\etickets\Views\Movies\Index.cshtml"
                                                                                                                   Write(item.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> \r\n");
            WriteLiteral("                            </p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 67 "C:\Users\Fiifi Ansah\source\repos\etickets\etickets\Views\Movies\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Movie>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
