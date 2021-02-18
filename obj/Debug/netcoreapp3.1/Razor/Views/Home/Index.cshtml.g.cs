#pragma checksum "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "272f9c5e2274bbd4ae42fc5e85cc58a2779709ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"272f9c5e2274bbd4ae42fc5e85cc58a2779709ae", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc8334d051a2e18116ddfdcf75a4a36e58453fa8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<Book>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Online Bookstore";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral(@"
<div class=""card border-white mb-3 mx-auto bg-dark"" style=""width: 100rem;"">

    <div class=""card-title text-white text-center"" style=""padding: 15px"">
        <h2>Take a look at our new books!</h2>
    </div>

    <table class=""table table-striped table-dark"" style=""width: auto"">
        <thead>
            <tr><th>Book ID</th><th>Title</th><th>ISBN #</th><th>Author's First Name</th><th>Middle Name</th><th>Last Name</th><th>Classification</th><th>Category</th><th>Publisher</th><th>Price</th></tr>
        </thead>

        <tbody>
");
#nullable restore
#line 19 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml"
             foreach (var book in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 22 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml"
                   Write(book.BookId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 23 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml"
                   Write(book.BookTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                    <td>");
#nullable restore
#line 24 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml"
                   Write(book.ISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                    <td>");
#nullable restore
#line 25 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml"
                   Write(book.AuthorFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                    <td>");
#nullable restore
#line 26 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml"
                   Write(book.AuthorMiddleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 27 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml"
                   Write(book.AuthorLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                    <td>");
#nullable restore
#line 28 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml"
                   Write(book.Classification);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                    <td>");
#nullable restore
#line 29 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml"
                   Write(book.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                    <td>");
#nullable restore
#line 30 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml"
                   Write(book.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                    <td>");
#nullable restore
#line 31 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml"
                   Write(book.BookPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n");
#nullable restore
#line 33 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n</div>\n<br />\n<br />\n<br />\n<br />\n<br />\n<br />\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
