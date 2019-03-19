#pragma checksum "D:\BookStoreRepository\BookStore\Views\Cart\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04523d4269f4949464ce23408f6e7e422ce71dd9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Cart), @"mvc.1.0.view", @"/Views/Cart/Cart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/Cart.cshtml", typeof(AspNetCore.Views_Cart_Cart))]
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
#line 1 "D:\BookStoreRepository\BookStore\Views\_ViewImports.cshtml"
using BookStore;

#line default
#line hidden
#line 2 "D:\BookStoreRepository\BookStore\Views\_ViewImports.cshtml"
using BookStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04523d4269f4949464ce23408f6e7e422ce71dd9", @"/Views/Cart/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"970ad2232b60c18355d1b72e2ff9366751045b67", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CartLine>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Cart/BuyAll/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Books/Index/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\BookStoreRepository\BookStore\Views\Cart\Cart.cshtml"
  
    ViewBag.Title = "BookStore: your cart";

#line default
#line hidden
            BeginContext(75, 366, true);
            WriteLiteral(@"
<h2>Your cart</h2>

    <table  class=""table"">
        <thead>
            <tr>
                <th>Name</th>
                <th>Author</th>
                <th >Genre</th>
                <th >Year</th>
                <th >Quantity</th>
                <th >Price</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 21 "D:\BookStoreRepository\BookStore\Views\Cart\Cart.cshtml"
             foreach (var line in Model)
            {

#line default
#line hidden
            BeginContext(498, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(537, 14, false);
#line 24 "D:\BookStoreRepository\BookStore\Views\Cart\Cart.cshtml"
               Write(line.Book.Name);

#line default
#line hidden
            EndContext();
            BeginContext(551, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(579, 16, false);
#line 25 "D:\BookStoreRepository\BookStore\Views\Cart\Cart.cshtml"
               Write(line.Book.Author);

#line default
#line hidden
            EndContext();
            BeginContext(595, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(623, 15, false);
#line 26 "D:\BookStoreRepository\BookStore\Views\Cart\Cart.cshtml"
               Write(line.Book.Genre);

#line default
#line hidden
            EndContext();
            BeginContext(638, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(666, 14, false);
#line 27 "D:\BookStoreRepository\BookStore\Views\Cart\Cart.cshtml"
               Write(line.Book.Year);

#line default
#line hidden
            EndContext();
            BeginContext(680, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(708, 13, false);
#line 28 "D:\BookStoreRepository\BookStore\Views\Cart\Cart.cshtml"
               Write(line.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(721, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(750, 31, false);
#line 29 "D:\BookStoreRepository\BookStore\Views\Cart\Cart.cshtml"
                Write(line.Book.Price * line.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(782, 49, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(831, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad34ad29524645049d77f02c109a37c8", async() => {
                BeginContext(902, 10, true);
                WriteLiteral("RemoveLine");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 864, "~/Cart/RemoveFromCart//", 864, 23, true);
#line 31 "D:\BookStoreRepository\BookStore\Views\Cart\Cart.cshtml"
AddHtmlAttributeValue("", 887, line.Book.Id, 887, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(916, 46, true);
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 35 "D:\BookStoreRepository\BookStore\Views\Cart\Cart.cshtml"
            }

#line default
#line hidden
            BeginContext(977, 111, true);
            WriteLiteral("        </tbody>\r\n        <tfoot>\r\n            <tr>\r\n                <td colspan=\"3\" class=\"text-right\">Total: ");
            EndContext();
            BeginContext(1089, 15, false);
#line 39 "D:\BookStoreRepository\BookStore\Views\Cart\Cart.cshtml"
                                                     Write(Cart.TotalPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1104, 99, true);
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"3\" class=\"text-right\">  ");
            EndContext();
            BeginContext(1203, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88e87433c1274e41a5a0a94652102a2e", async() => {
                BeginContext(1252, 7, true);
                WriteLiteral("Buy all");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1263, 99, true);
            WriteLiteral("</td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n\r\n    <div class=\"text-center\">\r\n        ");
            EndContext();
            BeginContext(1362, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff8d1d8468a940f0864b8a0ddfa7ffd1", async() => {
                BeginContext(1411, 8, true);
                WriteLiteral("Continue");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1423, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CartLine>> Html { get; private set; }
    }
}
#pragma warning restore 1591
