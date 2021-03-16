#pragma checksum "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Shared/BookInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2da2b9744426ea6874da690901d5801a66d1584c"
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
#nullable restore
#line 4 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/_ViewImports.cshtml"
using OnlineBookstore.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2da2b9744426ea6874da690901d5801a66d1584c", @"/Views/Shared/BookInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d1eafa2596a1da469fb96fcc3bcb441aabd77a9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_BookInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/PurchaseBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
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
            WriteLiteral(" </li>\n        </ul>\n\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2da2b9744426ea6874da690901d5801a66d1584c8117", async() => {
                WriteLiteral("\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2da2b9744426ea6874da690901d5801a66d1584c8383", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 30 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Shared/BookInfo.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.BookId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n            <input type=\"hidden\" name=\"returnUrl\"");
                BeginWriteAttribute("value", " value=\"", 1215, "\"", 1270, 1);
#nullable restore
#line 31 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Shared/BookInfo.cshtml"
WriteAttributeValue("", 1223, ViewContext.HttpContext.Request.PathAndQuery(), 1223, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\n            <span class=\"card-text p-1\">\n                ");
#nullable restore
#line 33 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Shared/BookInfo.cshtml"
           Write(Model.BookTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                <button type=\"submit\" class=\"btn-success btn-sm pull-right\" style=\"float:right\">\n                    Add to Cart\n                </button>\n            </span>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 29 "/Users/thomas.fife/Projects/OnlineBookstore/OnlineBookstore/Views/Shared/BookInfo.cshtml"
AddHtmlAttributeValue("", 1059, Model.BookId, 1059, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n    </div>\n</div>");
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
