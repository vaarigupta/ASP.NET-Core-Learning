#pragma checksum "C:\Users\vaarigupta\source\repos\Assignments\ASP.NET Core Assignment\Nagarro.BookReadingEvent\Views\Home\GetEvent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ded7fecd0f3af6270cb53b2720ce2538dbea641"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetEvent), @"mvc.1.0.view", @"/Views/Home/GetEvent.cshtml")]
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
#line 1 "C:\Users\vaarigupta\source\repos\Assignments\ASP.NET Core Assignment\Nagarro.BookReadingEvent\Views\_ViewImports.cshtml"
using Nagarro.BookReadingEvent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vaarigupta\source\repos\Assignments\ASP.NET Core Assignment\Nagarro.BookReadingEvent\Views\_ViewImports.cshtml"
using Nagarro.BookReadingEvent.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ded7fecd0f3af6270cb53b2720ce2538dbea641", @"/Views/Home/GetEvent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7236c36503def201603eb84ce7be96b8e914bb7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetEvent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<EventModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\vaarigupta\source\repos\Assignments\ASP.NET Core Assignment\Nagarro.BookReadingEvent\Views\Home\GetEvent.cshtml"
  
    ViewData["Title"] = "Event";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <h3 class=\"display-4\">All Events</h3>\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 8 "C:\Users\vaarigupta\source\repos\Assignments\ASP.NET Core Assignment\Nagarro.BookReadingEvent\Views\Home\GetEvent.cshtml"
         foreach (var _event in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""col-md-4"">
        <div class=""card mb-4 shadow-sm"" style=""width: 18rem;"">
            <img class=""bd-placeholder-img card-img-top"" width=""100"" height=""225"" src=""https://janefriedman.com/wp-content/uploads/2016/07/book-reading-1000x750.jpg"" alt=""Card image cap"">
            <div class=""card-body"">
                <h3 class=""card-title"">");
#nullable restore
#line 14 "C:\Users\vaarigupta\source\repos\Assignments\ASP.NET Core Assignment\Nagarro.BookReadingEvent\Views\Home\GetEvent.cshtml"
                                  Write(_event.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <p class=\"card-text\">");
#nullable restore
#line 15 "C:\Users\vaarigupta\source\repos\Assignments\ASP.NET Core Assignment\Nagarro.BookReadingEvent\Views\Home\GetEvent.cshtml"
                                Write(_event.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\">");
#nullable restore
#line 16 "C:\Users\vaarigupta\source\repos\Assignments\ASP.NET Core Assignment\Nagarro.BookReadingEvent\Views\Home\GetEvent.cshtml"
                                Write(_event.date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\">");
#nullable restore
#line 17 "C:\Users\vaarigupta\source\repos\Assignments\ASP.NET Core Assignment\Nagarro.BookReadingEvent\Views\Home\GetEvent.cshtml"
                                Write(_event.startTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                <div class=""d-flex justify-content-between align-items-center"">
                    <div class=""btn-group"">
                        <a href=""#"" class=""btn btn-sm btn-outline-secondary"">View Details</a>
                    </div>
                    <small class=""text-muted"">Vaari Gupta</small>
                </div>

            </div>
        </div>
    </div>
");
#nullable restore
#line 28 "C:\Users\vaarigupta\source\repos\Assignments\ASP.NET Core Assignment\Nagarro.BookReadingEvent\Views\Home\GetEvent.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<EventModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
