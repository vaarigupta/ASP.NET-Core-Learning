#pragma checksum "C:\Users\vaarigupta\source\repos\Nagarro.BookReading.Web\Pages\Event\ViewDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f53ef5b8d7bd32c0889f92d35f5434c93cf3abb5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Nagarro.BookReading.WebPages.Event.Pages_Event_ViewDetails), @"mvc.1.0.razor-page", @"/Pages/Event/ViewDetails.cshtml")]
namespace Nagarro.BookReading.WebPages.Event
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
#line 1 "C:\Users\vaarigupta\source\repos\Nagarro.BookReading.Web\Pages\_ViewImports.cshtml"
using Nagarro.BookReading.Web;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f53ef5b8d7bd32c0889f92d35f5434c93cf3abb5", @"/Pages/Event/ViewDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"595a446a88427ea5ea8147a6192c6f9e6a2ca044", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Event_ViewDetails : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\vaarigupta\source\repos\Nagarro.BookReading.Web\Pages\Event\ViewDetails.cshtml"
  
    var _event = Model._eventViewModel;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""col-md-12"" align =""center"">
        <div class=""card mb-12 shadow-sm"" style=""width: 50%;"" align =""center"">
            <img class=""bd-placeholder-img card-img-top"" width=""100"" height=""225"" src=""https://janefriedman.com/wp-content/uploads/2016/07/book-reading-1000x750.jpg"" alt=""Card image cap"">
            <div class=""card-body"">
                <h3 class=""card-title"">");
#nullable restore
#line 10 "C:\Users\vaarigupta\source\repos\Nagarro.BookReading.Web\Pages\Event\ViewDetails.cshtml"
                                  Write(_event.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <h6> Description</h6>\r\n                <p class=\"card-text\">");
#nullable restore
#line 12 "C:\Users\vaarigupta\source\repos\Nagarro.BookReading.Web\Pages\Event\ViewDetails.cshtml"
                                Write(_event.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <h6> Event Date</h6>\r\n                <p class=\"card-text\">");
#nullable restore
#line 14 "C:\Users\vaarigupta\source\repos\Nagarro.BookReading.Web\Pages\Event\ViewDetails.cshtml"
                                Write(_event.date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <h6> Start Time </h6>\r\n                <p class=\"card-text\">");
#nullable restore
#line 16 "C:\Users\vaarigupta\source\repos\Nagarro.BookReading.Web\Pages\Event\ViewDetails.cshtml"
                                Write(_event.startTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <div class=\"d-flex justify-content-between align-items-center\">\r\n                    \r\n                    <small class=\"text-muted\">Vaari Gupta</small>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Nagarro.BookReading.Web.Pages.Event.ViewDetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Nagarro.BookReading.Web.Pages.Event.ViewDetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Nagarro.BookReading.Web.Pages.Event.ViewDetailsModel>)PageContext?.ViewData;
        public Nagarro.BookReading.Web.Pages.Event.ViewDetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591