#pragma checksum "D:\Git\BookStoreRepository\BookStore\Views\Purchases\Bought.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77faf1d7206953844019a30a91ae032ebae63cff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Purchases_Bought), @"mvc.1.0.view", @"/Views/Purchases/Bought.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Purchases/Bought.cshtml", typeof(AspNetCore.Views_Purchases_Bought))]
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
#line 1 "D:\Git\BookStoreRepository\BookStore\Views\_ViewImports.cshtml"
using BookStore;

#line default
#line hidden
#line 2 "D:\Git\BookStoreRepository\BookStore\Views\_ViewImports.cshtml"
using BookStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77faf1d7206953844019a30a91ae032ebae63cff", @"/Views/Purchases/Bought.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"970ad2232b60c18355d1b72e2ff9366751045b67", @"/Views/_ViewImports.cshtml")]
    public class Views_Purchases_Bought : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookStore.Models.Purchase>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Git\BookStoreRepository\BookStore\Views\Purchases\Bought.cshtml"
  
    ViewData["Title"] = "Buy";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(120, 24, true);
            WriteLiteral("<br />\r\n<strong>Thanks, ");
            EndContext();
            BeginContext(145, 10, false);
#line 7 "D:\Git\BookStoreRepository\BookStore\Views\Purchases\Bought.cshtml"
           Write(Model.User);

#line default
#line hidden
            EndContext();
            BeginContext(155, 9, true);
            WriteLiteral("</strong>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookStore.Models.Purchase> Html { get; private set; }
    }
}
#pragma warning restore 1591
