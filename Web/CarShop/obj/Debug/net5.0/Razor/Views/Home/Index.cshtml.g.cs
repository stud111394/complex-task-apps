#pragma checksum "C:\Users\Надя_Пленкина\source\repos\CarShop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47039dfd84bc4773da2e2e8d3d64ed930477e9ba"
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
#line 1 "C:\Users\Надя_Пленкина\source\repos\CarShop\Views\_ViewImports.cshtml"
using CarShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Надя_Пленкина\source\repos\CarShop\Views\_ViewImports.cshtml"
using CarShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Надя_Пленкина\source\repos\CarShop\Views\Home\Index.cshtml"
using CarShop.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47039dfd84bc4773da2e2e8d3d64ed930477e9ba", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe4c0d735d051fba12fbf7807849e7c1ea31600c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Надя_Пленкина\source\repos\CarShop\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Главная";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"text-center d-flex justify-content-center\" >\r\n    <h1>\r\n        Новинки\r\n    </h1>\r\n</div>\r\n\r\n\r\n<div class=\"row\" style=\"margin-top:40px\">\r\n");
#nullable restore
#line 18 "C:\Users\Надя_Пленкина\source\repos\CarShop\Views\Home\Index.cshtml"
     foreach (var item in Model.CarZaps)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-lg-3 col-md-4 col-sm-12\">\r\n        <div class=\"card\" style=\"width: auto\">\r\n            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 441, "\"", 460, 1);
#nullable restore
#line 22 "C:\Users\Надя_Пленкина\source\repos\CarShop\Views\Home\Index.cshtml"
WriteAttributeValue("", 447, item.ImgLink, 447, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 24 "C:\Users\Надя_Пленкина\source\repos\CarShop\Views\Home\Index.cshtml"
                                  Write(item.Nazvanie);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            </div>\r\n            <ul class=\"list-group list-group-flush\">\r\n                <li class=\"list-group-item\">");
#nullable restore
#line 27 "C:\Users\Надя_Пленкина\source\repos\CarShop\Views\Home\Index.cshtml"
                                       Write(item.Cena);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Р.</li>\r\n            </ul>\r\n            <div class=\"card-body\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 794, "\"", 829, 2);
            WriteAttributeValue("", 801, "/Zap/Index?id=", 801, 14, true);
#nullable restore
#line 30 "C:\Users\Надя_Пленкина\source\repos\CarShop\Views\Home\Index.cshtml"
WriteAttributeValue("", 815, item.IdCarZap, 815, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-link\">Подробнее</a><br />\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 888, "\"", 923, 2);
            WriteAttributeValue("", 895, "/Buy/Index?id=", 895, 14, true);
#nullable restore
#line 31 "C:\Users\Надя_Пленкина\source\repos\CarShop\Views\Home\Index.cshtml"
WriteAttributeValue("", 909, item.IdCarZap, 909, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-link\">Купить</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 35 "C:\Users\Надя_Пленкина\source\repos\CarShop\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
