#pragma checksum "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Search\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3543fe7c119e8d51da33b7b751a8f5a8a1cb7757"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_Index), @"mvc.1.0.view", @"/Views/Search/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\_ViewImports.cshtml"
using OnlainStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\_ViewImports.cshtml"
using OlineStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\_ViewImports.cshtml"
using OnlainStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\_ViewImports.cshtml"
using OlineStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\_ViewImports.cshtml"
using Store_Memory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Search\Index.cshtml"
using Store;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Search\Index.cshtml"
using System;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3543fe7c119e8d51da33b7b751a8f5a8a1cb7757", @"/Views/Search/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a11f5182d4a1088deeaa1c6e6a5ab5a9464da4d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Search_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n</div>\r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 10 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Search\Index.cshtml"
     if (Model == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1 class=\"text-center\">Товар не найден</h1>\r\n");
#nullable restore
#line 13 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Search\Index.cshtml"
    }
    else
    {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Search\Index.cshtml"
     foreach (var product in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-4 card shadow\">\r\n            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 385, "\"", 404, 1);
#nullable restore
#line 20 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Search\Index.cshtml"
WriteAttributeValue("", 391, product.Link, 391, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <div class=\"card-body\">\r\n                <a style=\"color: black\"");
            BeginWriteAttribute("href", " href=\"", 486, "\"", 519, 2);
            WriteAttributeValue("", 493, "/product/index/", 493, 15, true);
#nullable restore
#line 22 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Search\Index.cshtml"
WriteAttributeValue("", 508, product.Id, 508, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <h5>");
#nullable restore
#line 23 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Search\Index.cshtml"
                   Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                </a>\r\n                <h5>");
#nullable restore
#line 25 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Search\Index.cshtml"
               Write(product.Cost);

#line default
#line hidden
#nullable disable
            WriteLiteral(" руб </h5>\r\n                <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 676, "\"", 708, 2);
            WriteAttributeValue("", 683, "/Cart/AddItem/", 683, 14, true);
#nullable restore
#line 26 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Search\Index.cshtml"
WriteAttributeValue("", 697, product.Id, 697, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\">В корзину</a>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 29 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Search\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Search\Index.cshtml"
     
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
