#pragma checksum "D:\1Ozan\DeveloperTools\hizlianaliz\UIProject\Views\SearchProduct\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad26f34a7fd195af27f6f20b241565f0f20f92bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SearchProduct_Index), @"mvc.1.0.view", @"/Views/SearchProduct/Index.cshtml")]
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
#line 1 "D:\1Ozan\DeveloperTools\hizlianaliz\UIProject\Views\_ViewImports.cshtml"
using UIProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\1Ozan\DeveloperTools\hizlianaliz\UIProject\Views\_ViewImports.cshtml"
using UIProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad26f34a7fd195af27f6f20b241565f0f20f92bb", @"/Views/SearchProduct/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"616188975a1f3b0fb4e5776c2a9cb5e3e818b2f5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_SearchProduct_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\1Ozan\DeveloperTools\hizlianaliz\UIProject\Views\SearchProduct\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_DashboardLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""collapse show pb-5"" id=""collapseExample"">
    <div class=""row filter bg-white rounded-3"">
        <div class=""col-md-6"">
            <div class=""dashboard-box mt-4  px-md-3 px-1"">
                <div class=""dashboard-box-inner row m-0 mt-md-2 mt-0 px-4"" id=""CategoryFilterDiv"">
                    <div class=""head-text col-md-12 p-0"">
                        <h1 class=""anakategoritext"">Ana Kategoriler</h1>
                        <h1 style=""display:none;"" class=""altkategoritext"">Alt Kategoriler</h1>
                        <p class=""anakategoritext"">trendyol.com'a ait ana kategorileri görüntülüyorsunuz. Detaylı alt kategori seçmek için <a onclick=""change()"" href=""#"">alt kategorileri görüntüleyin</a></p>
                        <p style=""display:none;"" class=""altkategoritext"">trendyol.com'a ait alt kategorileri görüntülüyorsunuz. Ana kategori seçmek için <a onclick=""change()"" href=""#"">ana kategorileri görüntüleyin</a></p>
                    </div>
                    <div id=""anakateg");
            WriteLiteral("oriler\" class=\"row col-md-12\">\r\n                        <div class=\"col-md-6 p-0\">\r\n                            <div class=\"form-check\">\r\n                                <input class=\"form-check-input categoryFilters\" data-id=\"368\" type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 1370, "\"", 1378, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""flexCheckDefault"">
                                <label class=""form-check-label"" for=""flexCheckDefault"">
                                    Aksesuar
                                </label>
                            </div>
                        </div>
                        <div class=""col-md-6 p-0"">
                            <div class=""form-check"">
                                <input class=""form-check-input categoryFilters"" data-id=""1071"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 1865, "\"", 1873, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""check2"">
                                <label class=""form-check-label"" for=""check2"">
                                    Elektronik
                                </label>
                            </div>
                        </div>
                        <div class=""col-md-6 p-0"">
                            <div class=""form-check"">
                                <input class=""form-check-input categoryFilters"" data-id=""403"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 2341, "\"", 2349, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""check3"">
                                <label class=""form-check-label"" for=""check3"">
                                    Ayakkabı
                                </label>
                            </div>
                        </div>
                               
                        <div class=""col-md-6 p-0"">
                            <div class=""form-check"">
                                <input class=""form-check-input categoryFilters"" data-id=""1070"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 2849, "\"", 2857, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""check5"">
                                <label class=""form-check-label"" for=""check5"">
                                    Kozmetik & Kişisel Bakım
                                </label>
                            </div>
                        </div>
                        <div class=""col-md-6 p-0"">
                            <div class=""form-check"">
                                <input class=""form-check-input categoryFilters"" data-id=""1219"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 3340, "\"", 3348, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""check6"">
                                <label class=""form-check-label"" for=""check6"">
                                    Süpermarket
                                </label>
                            </div>
                        </div>
                        <div class=""col-md-6 p-0"">
                            <div class=""form-check"">
                                <input class=""form-check-input categoryFilters"" data-id=""758"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 3817, "\"", 3825, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""check7"">
                                <label class=""form-check-label"" for=""check7"">
                                    Ev & Mobilya
                                </label>
                            </div>
                        </div>
                                
                        <div class=""col-md-6 p-0"">
                            <div class=""form-check"">
                                <input class=""form-check-input categoryFilters"" data-id=""2862"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 4330, "\"", 4338, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""check9"">
                                <label class=""form-check-label"" for=""check9"">
                                    Anne & Bebek & Çocuk
                                </label>
                            </div>
                        </div>

                        <div class=""col-md-6 p-0"">
                            <div class=""form-check"">
                                <input class=""form-check-input categoryFilters"" data-id=""2859"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 4819, "\"", 4827, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""check10"">
                                <label class=""form-check-label"" for=""check10"">
                                    Yaşam
                                </label>
                            </div>
                        </div>

                        <div class=""col-md-6 p-0"">
                            <div class=""form-check"">
                                <input class=""form-check-input categoryFilters"" data-id=""522"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 5294, "\"", 5302, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""check11"">
                                <label class=""form-check-label"" for=""check11"">
                                    Giyim
                                </label>
                            </div>
                        </div>

                        <div class=""col-md-6 p-0"">
                            <div class=""form-check"">
                                <input class=""form-check-input categoryFilters"" data-id=""3186"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 5770, "\"", 5778, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""check12"">
                                <label class=""form-check-label"" for=""check12"">
                                    Spor & Outdoor
                                </label>
                            </div>
                        </div>
                    </div>

                    <div id=""altkategoriler"" style=""display:none;"" class=""row col-md-12"">
                        <div class=""col-md-12"">
                            <select id=""Kategoriler"" class=""altkategoriler js-example-basic-multiple"" onchange=""KategoriSelectTo()"" name=""state"" style=""width: 100%""></select>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-md-6 mt-2"">
            <div class=""row bg-white m-0 mt-4"" id=""OtherFilterDiv"">
                <div class=""head-text col-md-12"">
                    <h1>Filtreler</h1>
                    <p>Aşağıdaki alanda filtre başlıklarına göre minimum ve maksimum değer girerek sonu");
            WriteLiteral(@"ç görüntüleyebilirsiniz </p>
                </div>
                <div class=""col-md-6"">
                    <div class=""input-group mb-4"">
                        <span class=""input-group-text"" id=""inputName""><i class=""bi bi-tag me-2""></i>Fiyat &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span>
                        <input type=""text"" placeholder=""Min"" class=""form-control productFilters"" data-name=""minprice"" aria-label=""Sizing example input"" aria-describedby=""inputName"">
                        <input type=""text"" placeholder=""Max"" class=""form-control productFilters"" data-name=""maxprice"" aria-label=""Sizing example input"" aria-describedby=""inputName"">
                    </div>
                </div>
                <div class=""col-md-6"">
                    <div class=""input-group mb-4"">
                        <span class=""input-group-text"" id=""inputName""><i class=""bi bi-cart-check me-2""></i>Ürün Yorum&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span>
       ");
            WriteLiteral(@"                 <input type=""text"" placeholder=""Min"" class=""form-control productFilters"" data-name=""minreviews"" aria-label=""Sizing example input"" aria-describedby=""inputName"">
                        <input type=""text"" placeholder=""Max"" class=""form-control productFilters"" data-name=""maxreviews"" aria-label=""Sizing example input"" aria-describedby=""inputName"">
                    </div>
                </div>
                <div class=""col-md-6"">
                    <div class=""input-group mb-4"">
                        <span class=""input-group-text"" id=""inputName""><i class=""bi bi-cash-stack me-2""></i>Aylık Satış &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span>
                        <input type=""text"" placeholder=""Min"" class=""form-control productFilters"" data-name=""minsales"" aria-label=""Sizing example input"" aria-describedby=""inputName"">
                        <input type=""text"" placeholder=""Max"" class=""form-control productFilters"" data-name=""maxsales"" aria-label=""Sizing example input"" aria-describedby=""");
            WriteLiteral(@"inputName"">
                    </div>
                </div>
                <div class=""col-md-6"">
                    <div class=""input-group mb-4"">
                        <span class=""input-group-text"" id=""inputName""><i class=""bi bi-chat-text me-2""></i>Ürün Puanı&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span>
                        <input type=""text"" placeholder=""Min"" class=""form-control productFilters"" data-name=""minrating"" aria-label=""Sizing example input"" aria-describedby=""inputName"">
                        <input type=""text"" placeholder=""Max"" class=""form-control productFilters"" data-name=""maxrating"" aria-label=""Sizing example input"" aria-describedby=""inputName"">
                    </div>
                </div>
                <div class=""col-md-6"">
                    <div class=""input-group mb-4"">
                        <span class=""input-group-text"" id=""inputName""><i class=""bi bi-star me-2""></i>Aylık Ciro&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span>
                    ");
            WriteLiteral(@"    <input type=""text"" placeholder=""Min"" class=""form-control productFilters"" data-name=""minciro"" aria-label=""Sizing example input"" aria-describedby=""inputName"">
                        <input type=""text"" placeholder=""Max"" class=""form-control productFilters"" data-name=""maxciro"" aria-label=""Sizing example input"" aria-describedby=""inputName"">
                    </div>
                </div>
                <div class=""col-md-6"">
                    <div class=""input-group mb-4"">
                        <span class=""input-group-text"" id=""inputName""><i class=""bi bi-hand-thumbs-up me-2""></i>Ürün Favori&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span>
                        <input type=""text"" placeholder=""Min"" class=""form-control productFilters"" data-name=""minfavori"" aria-label=""Sizing example input"" aria-describedby=""inputName"">
                        <input type=""text"" placeholder=""Max"" class=""form-control productFilters"" data-name=""maxfavori"" aria-label=""Sizing example input"" aria-describedby=""inputName"">
 ");
            WriteLiteral(@"                   </div>
                </div>
                <div class=""col-md-6"">
                    <div class=""input-group mb-4"">
                        <span class=""input-group-text"" id=""inputName""><i class=""bi bi-hand-thumbs-up me-2""></i>Satıcı Sayısı&nbsp;&nbsp;&nbsp;&nbsp;</span>
                        <input type=""text"" placeholder=""Min"" class=""form-control productFilters"" data-name=""minmerchantcount"" aria-label=""Sizing example input"" aria-describedby=""inputName"">
                        <input type=""text"" placeholder=""Max"" class=""form-control productFilters"" data-name=""maxmerchantcount"" aria-label=""Sizing example input"" aria-describedby=""inputName"">
                    </div>
                </div>

                <div class=""col-md-12"">
                    <div class=""mb-3"">
                        <div id=""select2Div"">
                            <select multiple=""multiple"" id=""listInclude"" style=""padding-left:15px;width:100%;""></select>
                        </div>
      ");
            WriteLiteral(@"                  <div id=""kelime"" class=""text-muted text-size825 mt-2"">
                            <small>
                                **Kelime veya Ürün Numarası Girişi (Kelimeleri dahil edebilir veya başlarına ""-"" koyarak dışarıda bırakabilirsiniz. Örn: ayakkabı,-erkek)
                            </small>
                        </div>
                    </div>
                </div>
                <div class=""col-md-9"">
                    <button onclick=""getFunc()"" type=""submit"" class=""btn-filter w-100 mt-3 mb-4 justify-content-center"" id=""StartButton"">
                        Ürün Analizini Başlat<i class=""bi bi-search"" style="" margin-left: 6px; margin-top: -2px; ""></i>
                    </button>
                </div>
                <div class=""col-md-3"">
                    <button onclick=""toexcel()"" type=""submit"" class=""btn-filter w-100 mt-3 mb-4 justify-content-center"" style=""background-color: #34425A; border: 1px solid #34425A;"" id=""ToExcelButton"">
                      ");
            WriteLiteral("  Excel\'e Aktar<i class=\"bi bi-file-earmark-spreadsheet\" style=\"margin-left: 6px;margin-top: -2px;\"></i>\r\n                    </button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591