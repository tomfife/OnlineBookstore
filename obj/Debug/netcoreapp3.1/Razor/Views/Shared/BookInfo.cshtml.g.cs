#pragma checksum "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Shared/BookInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e6c74bae73859fecf502ce9a5bbc373c3f28c44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_BookInfo), @"mvc.1.0.view", @"/Views/Shared/BookInfo.cshtml")]
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
#line 1 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/_ViewImports.cshtml"
using OnlineBookstore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/_ViewImports.cshtml"
using OnlineBookstore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/_ViewImports.cshtml"
using OnlineBookstore.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e6c74bae73859fecf502ce9a5bbc373c3f28c44", @"/Views/Shared/BookInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"757d9d002e23348a2adc58d3f41d0e74920f3827", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_BookInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"col-sm-3 m-4\">\n    <!--Never used this type of column before-->\n    <div class=\"card border-white mb-3 bg-dark\" style=\"width: 20rem;\">\n\n        <div class=\"card-title text-white text-center mt-2 mb-0\">\n            <h2>");
#nullable restore
#line 8 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Shared/BookInfo.cshtml"
           Write(Model.BookTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n        </div>\n\n        <div class=\"row mb-2\">\n            <div class=\"col ml-5\">\n                <span class=\"badge badge-pill badge-success m-1\">");
#nullable restore
#line 13 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Shared/BookInfo.cshtml"
                                                            Write(Model.Classification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n            </div>\n            <div class=\"col mr-5\">\n                <!--Never used mr before-->\n                <span class=\"badge badge-pill badge-primary m-1\">");
#nullable restore
#line 17 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Shared/BookInfo.cshtml"
                                                            Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n            </div>\n        </div>\n\n        <ul class=\"text-white\">\n            <li><b>Author:</b> ");
#nullable restore
#line 22 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Shared/BookInfo.cshtml"
                          Write(Model.AuthorFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 22 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Shared/BookInfo.cshtml"
                                                 Write(Model.AuthorMiddleName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 22 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Shared/BookInfo.cshtml"
                                                                         Write(Model.AuthorLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n            <li><b>ISBN-13:</b> ");
#nullable restore
#line 23 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Shared/BookInfo.cshtml"
                           Write(Model.ISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n            <li><b>Publisher:</b> ");
#nullable restore
#line 24 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Shared/BookInfo.cshtml"
                             Write(Model.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n            <li><b>Print Length:</b> ");
#nullable restore
#line 25 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Shared/BookInfo.cshtml"
                                Write(Model.PagesInBook);

#line default
#line hidden
#nullable disable
            WriteLiteral(" pages</li>\n            <li><b>Price:</b> $ ");
#nullable restore
#line 26 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Shared/BookInfo.cshtml"
                           Write(Model.BookPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\n        </ul>\n\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; }
    }
}
#pragma warning restore 1591