#pragma checksum "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c848bdd9a934ed798db4fa2e7f47a93646f79b90"
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
#nullable restore
#line 3 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/_ViewImports.cshtml"
using OnlineBookstore.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c848bdd9a934ed798db4fa2e7f47a93646f79b90", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"757d9d002e23348a2adc58d3f41d0e74920f3827", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class", "btn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-normal", "btn-outline-dark", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-selected", "btn-primary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-group pull-right m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::OnlineBookstore.Infrastructure.PageLinkTagHelper __OnlineBookstore_Infrastructure_PageLinkTagHelper;
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
            WriteLiteral("\n<div class=\"container\">\n    <div class=\"row justify-content-md-center\">\n        <!--Never usedthis type of justify before combined with the rows-->\n\n");
#nullable restore
#line 11 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml"
         foreach (var book in Model.Books)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-sm-3 m-4"">
                <!--Never used this type of column before-->
                <div class=""card border-white mb-3 bg-dark"" style=""width: 20rem;"">

                    <div class=""card-title text-white text-center mt-2 mb-0"">
                        <h2>");
#nullable restore
#line 18 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml"
                       Write(book.BookTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                    </div>\n\n                    <div class=\"row mb-2\">\n                        <div class=\"col ml-5\">\n                            <span class=\"badge badge-pill badge-success m-1\">");
#nullable restore
#line 23 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml"
                                                                        Write(book.Classification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                        </div>\n                        <div class=\"col mr-5\">\n                            <!--Never used mr before-->\n                            <span class=\"badge badge-pill badge-primary m-1\">");
#nullable restore
#line 27 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml"
                                                                        Write(book.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                        </div>\n                    </div>\n\n                    <ul class=\"text-white\">\n                        <li><b>Author:</b> ");
#nullable restore
#line 32 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml"
                                      Write(book.AuthorFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 32 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml"
                                                            Write(book.AuthorMiddleName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 32 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml"
                                                                                   Write(book.AuthorLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                        <li><b>ISBN-13:</b> ");
#nullable restore
#line 33 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml"
                                       Write(book.ISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                        <li><b>Publisher:</b> ");
#nullable restore
#line 34 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml"
                                         Write(book.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                        <li><b>Print Length:</b> ");
#nullable restore
#line 35 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml"
                                            Write(book.PagesInBook);

#line default
#line hidden
#nullable disable
            WriteLiteral(" pages</li>\n                        <li><b>Price:</b> $ ");
#nullable restore
#line 36 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml"
                                       Write(book.BookPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\n                    </ul>\n\n                </div>\n            </div>\n");
#nullable restore
#line 41 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>\n\n\n<div class=\"text-center mt-5\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c848bdd9a934ed798db4fa2e7f47a93646f79b909572", async() => {
            }
            );
            __OnlineBookstore_Infrastructure_PageLinkTagHelper = CreateTagHelper<global::OnlineBookstore.Infrastructure.PageLinkTagHelper>();
            __tagHelperExecutionContext.Add(__OnlineBookstore_Infrastructure_PageLinkTagHelper);
#nullable restore
#line 47 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml"
__OnlineBookstore_Infrastructure_PageLinkTagHelper.PageModel = Model.PagingInfo;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __OnlineBookstore_Infrastructure_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __OnlineBookstore_Infrastructure_PageLinkTagHelper.PageAction = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 47 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml"
__OnlineBookstore_Infrastructure_PageLinkTagHelper.PageClassesEnabled = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-classes-enabled", __OnlineBookstore_Infrastructure_PageLinkTagHelper.PageClassesEnabled, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __OnlineBookstore_Infrastructure_PageLinkTagHelper.PageClass = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __OnlineBookstore_Infrastructure_PageLinkTagHelper.PageClassNormal = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __OnlineBookstore_Infrastructure_PageLinkTagHelper.PageClassSelected = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__OnlineBookstore_Infrastructure_PageLinkTagHelper.PageUrlValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("page-url-category", "OnlineBookstore.Infrastructure.PageLinkTagHelper", "PageUrlValues"));
            }
#nullable restore
#line 49 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml"
__OnlineBookstore_Infrastructure_PageLinkTagHelper.PageUrlValues["category"] = Model.CurrentCategory;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-url-category", __OnlineBookstore_Infrastructure_PageLinkTagHelper.PageUrlValues["category"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n\n    <br />\n    <br />\n    <br />\n    <br />\n    <br />\n    <br />\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
