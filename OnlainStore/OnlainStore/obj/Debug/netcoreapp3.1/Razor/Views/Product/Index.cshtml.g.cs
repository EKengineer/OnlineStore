#pragma checksum "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fb9d3df5ca1831c0ef91ce309784ac110db77b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 8 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Product\Index.cshtml"
using Store_Memory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Product\Index.cshtml"
using System;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fb9d3df5ca1831c0ef91ce309784ac110db77b7", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58bf4fe43b087d9ecb0adc724b8725102fb54741", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Product\Index.cshtml"
      
        ViewData["Title"] = "Home Page";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n\r\n\r\n    <div class=\"col-4\">\r\n    </div>\r\n        <div class=\"col-4 card shadow\">\r\n        <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 250, "\"", 267, 1);
#nullable restore
#line 15 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Product\Index.cshtml"
WriteAttributeValue("", 256, Model.Link, 256, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <div class=\"card-body\">\r\n                <a style=\"color:black\" >\r\n                    <h5>");
#nullable restore
#line 18 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Product\Index.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h6>");
#nullable restore
#line 19 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Product\Index.cshtml"
                   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                </a>\r\n                <h5>");
#nullable restore
#line 21 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Product\Index.cshtml"
               Write(Model.Cost);

#line default
#line hidden
#nullable disable
            WriteLiteral(" руб </h5>\r\n            <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 546, "\"", 576, 2);
            WriteAttributeValue("", 553, "/Cart/AddItem/", 553, 14, true);
#nullable restore
#line 22 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Product\Index.cshtml"
WriteAttributeValue("", 567, Model.Id, 567, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\">В корзину</a>   <a class=\"btn btn-info\" href=\"/Home/index\" role=\"button\">Продолжить покупки</a>\r\n            </div>\r\n        </div>\r\n\r\n\r\n    </div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
