#pragma checksum "C:\Users\aynur\Desktop\ВКР_цветочный\Программа\Цветочная лавка\Shop\Shop\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c94a410d9e3b3db1d7e61beb693edc912186895"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c94a410d9e3b3db1d7e61beb693edc912186895", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Shop.Models.ProductViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\aynur\Desktop\ВКР_цветочный\Программа\Цветочная лавка\Shop\Shop\Views\Product\Index.cshtml"
  
    ViewData["Title"] = @Model.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""album py-5"">
    <div class=""row"">
        <div class=""col-md-6 mb-4 mb-md-0"">
            <div class=""mdb-lightbox"">
                <div class=""row product-gallery mx-1"">
                    <div class=""col-12 mb-0"">
                        <img class=""card-img-top""");
            BeginWriteAttribute("src", " src=\"", 360, "\"", 395, 1);
#nullable restore
#line 13 "C:\Users\aynur\Desktop\ВКР_цветочный\Программа\Цветочная лавка\Shop\Shop\Views\Product\Index.cshtml"
WriteAttributeValue("", 366, Url.Content(Model.ImagePath), 366, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Изображение товара\" onError=\"this.src=\'/images/NotFound.jpg\'\"/>\n                    </div>\n                </div>\n            </div>\n        </div>\n        <div class=\"col-md-6\">\n            <h5>");
#nullable restore
#line 19 "C:\Users\aynur\Desktop\ВКР_цветочный\Программа\Цветочная лавка\Shop\Shop\Views\Product\Index.cshtml"
           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n            <h5><span style=\"color:#987654\" class=\"mr-1\"><strong>");
#nullable restore
#line 20 "C:\Users\aynur\Desktop\ВКР_цветочный\Программа\Цветочная лавка\Shop\Shop\Views\Product\Index.cshtml"
                                                            Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &#8381;</strong></span></h5>\n            <p class=\"pt-1\"> ");
#nullable restore
#line 21 "C:\Users\aynur\Desktop\ВКР_цветочный\Программа\Цветочная лавка\Shop\Shop\Views\Product\Index.cshtml"
                        Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <div class=\"table-responsive mb-2\">\n            </div>\n            <a class=\"btn btn-info\" href=\"/home/index?page=1\" role=\"button\">На главную</a>\n            <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 966, "\"", 992, 2);
            WriteAttributeValue("", 973, "/cart/add/", 973, 10, true);
#nullable restore
#line 25 "C:\Users\aynur\Desktop\ВКР_цветочный\Программа\Цветочная лавка\Shop\Shop\Views\Product\Index.cshtml"
WriteAttributeValue("", 983, Model.Id, 983, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\">К оформлению заказа</a>\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shop.Models.ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
