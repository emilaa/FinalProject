#pragma checksum "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6703b48702cb9e9d82cb5a9be0920c5b28cfc76f"
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
#line 1 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\_ViewImports.cshtml"
using Online_Shop___BackEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\_ViewImports.cshtml"
using Online_Shop___BackEnd.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\_ViewImports.cshtml"
using Online_Shop___BackEnd.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\_ViewImports.cshtml"
using Online_Shop___BackEnd.ViewModels.AccountViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\_ViewImports.cshtml"
using Online_Shop___BackEnd.ViewModels.BasketViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6703b48702cb9e9d82cb5a9be0920c5b28cfc76f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18e07f2957cad4badc5c3ee141397521b9d73daa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("Links", async() => {
                WriteLiteral("\r\n    <link href=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css\"\r\n      rel=\"stylesheet\"\r\n      crossorigin=\"anonymous\" />\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", "\r\n      href=\"", 208, "\"", 311, 2);
                WriteAttributeValue("", 222, "https://cdn.jsdelivr.net/npm/", 222, 29, true);
                WriteLiteral("@");
                WriteAttributeValue("", 253, "fontawesome/fontawesome-free@6.2.1/css/fontawesome.min.css", 253, 58, true);
                EndWriteAttribute();
                WriteLiteral(@"
      crossorigin=""anonymous"" />
    <link rel=""stylesheet""
      href=""https://cdnjs.cloudflare.com/ajax/libs/owl-carousel/1.3.3/owl.carousel.css""
      crossorigin=""anonymous""
      referrerpolicy=""no-referrer"" />
    <link rel=""stylesheet""
      href=""https://cdn.jsdelivr.net/npm/swiper/swiper-bundle.min.css"" />
    <link rel=""stylesheet"" href=""./assets/css/home/home.css"" />
    <title>Home</title>
");
            }
            );
            WriteLiteral("\r\n<main>\r\n");
#nullable restore
#line 21 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Home\Index.cshtml"
     foreach (var banner in Model.Banners)
    {
        if (banner.Id == 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <section id=\"banner\"");
            BeginWriteAttribute("style", "\r\n             style=\"", 864, "\"", 942, 3);
            WriteAttributeValue("", 886, "background-image:", 886, 17, true);
            WriteAttributeValue(" ", 903, "url(./assets/images/home/", 904, 26, true);
#nullable restore
#line 26 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Home\Index.cshtml"
WriteAttributeValue("", 929, banner.Image, 929, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"container\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-12 col-sm-12 col-md-12 col-lg-12\">\r\n                            <div class=\"banner-detail\">\r\n                                <h1>");
#nullable restore
#line 31 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Home\Index.cshtml"
                               Write(Html.Raw(banner.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                                <button>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6703b48702cb9e9d82cb5a9be0920c5b28cfc76f7287", async() => {
                WriteLiteral("Shop Now");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</button>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </section>\r\n");
#nullable restore
#line 38 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Home\Index.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <section id=\"category\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 44 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Home\Index.cshtml"
                 foreach (var banner in Model.HomeCategories)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4 col-md-12 col-sm-12\">\r\n                        <div class=\"categories\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1817, "\"", 1857, 2);
            WriteAttributeValue("", 1823, "./assets/images/home/", 1823, 21, true);
#nullable restore
#line 48 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Home\Index.cshtml"
WriteAttributeValue("", 1844, banner.Image, 1844, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1858, "\"", 1864, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6703b48702cb9e9d82cb5a9be0920c5b28cfc76f10254", async() => {
#nullable restore
#line 49 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Home\Index.cshtml"
                                                                   Write(Html.Raw(banner.Title));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 52 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </section>\r\n\r\n    <section id=\"global-sale\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-12\">\r\n");
#nullable restore
#line 61 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Home\Index.cshtml"
                     foreach (var banner in Model.Banners)
                    {
                        if (banner.Id == 2)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"global-sale-about\"");
            BeginWriteAttribute("style", "\r\n                         style=\"", 2451, "\"", 2581, 5);
            WriteAttributeValue("\r\n                  ", 2485, "background-image:", 2505, 37, true);
            WriteAttributeValue(" ", 2522, "url(./assets/images/home/", 2523, 26, true);
#nullable restore
#line 67 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Home\Index.cshtml"
WriteAttributeValue("", 2548, banner.Image, 2548, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2561, ");", 2561, 2, true);
            WriteAttributeValue("\r\n                ", 2563, "", 2581, 18, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <div class=\"global-sale-detail\">\r\n                                    <h1>");
#nullable restore
#line 70 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Home\Index.cshtml"
                                   Write(Html.Raw(banner.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                                    <button>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6703b48702cb9e9d82cb5a9be0920c5b28cfc76f14067", async() => {
                WriteLiteral("Shop Now");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</button>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 74 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Home\Index.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </section>

    <section id=""products"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""product-header"">
                        <h2>Popular Products</h2>
                    </div>
                </div>
                <div id=""product-slider"" class=""owl-carousel"">
");
#nullable restore
#line 90 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Home\Index.cshtml"
                     foreach (var product in Model.Products)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-3 col-md-6 col-sm-12\">\r\n                            <div class=\"product\">\r\n                                <div class=\"product-image\"");
            BeginWriteAttribute("product-id", " product-id=\"", 3645, "\"", 3669, 1);
#nullable restore
#line 94 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Home\Index.cshtml"
WriteAttributeValue("", 3658, product.Id, 3658, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("card-id", " card-id=\"", 3670, "\"", 3691, 1);
#nullable restore
#line 94 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Home\Index.cshtml"
WriteAttributeValue("", 3680, product.Id, 3680, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a href=\"product-detail.html\" class=\"image\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 3821, "\"", 3915, 2);
            WriteAttributeValue("", 3827, "./assets/images/home/products/", 3827, 30, true);
#nullable restore
#line 96 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Home\Index.cshtml"
WriteAttributeValue("", 3857, product.ProductImages.FirstOrDefault(m => m.IsMain)?.Name, 3857, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                         class=\"img-1\" />\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 4021, "\"", 4116, 2);
            WriteAttributeValue("", 4027, "./assets/images/home/products/", 4027, 30, true);
#nullable restore
#line 98 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Home\Index.cshtml"
WriteAttributeValue("", 4057, product.ProductImages.FirstOrDefault(m => !m.IsMain)?.Name, 4057, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                         class=\"img-2\" />\r\n                                    </a>\r\n                                    <span class=\"discount\">Sale</span>\r\n                                    <button style=\"border: none;\"");
            BeginWriteAttribute("cart-id", " cart-id=\"", 4357, "\"", 4378, 1);
#nullable restore
#line 102 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Home\Index.cshtml"
WriteAttributeValue("", 4367, product.Id, 4367, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"cart\" id=\"addToCart\">Add To Cart</button>\r\n                                    <div class=\"links\">\r\n                                        <ul>\r\n                                            <li>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 4633, "\"", 4640, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-solid fa-heart\"></i></a>\r\n                                            </li>\r\n                                        </ul>\r\n                                    </div>\r\n                                    <div class=\"content\">\r\n");
#nullable restore
#line 111 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Home\Index.cshtml"
                                         foreach (var category in product.ProductSubCategories)
                                        {
                                            if (category.SubCategory.CategoryId == 2)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"category\"><a");
            BeginWriteAttribute("href", " href=\"", 5229, "\"", 5236, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 115 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Home\Index.cshtml"
                                                                             Write(category.SubCategory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></span>\r\n");
#nullable restore
#line 116 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Home\Index.cshtml"
                                            }
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <h3 class=\"title\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 5473, "\"", 5480, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 119 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Home\Index.cshtml"
                                                  Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        </h3>\r\n                                        <div class=\"price\">$");
#nullable restore
#line 121 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Home\Index.cshtml"
                                                       Write(product.Price.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 126 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </section>

    <section id=""brands"">
        <div class=""container"">
            <div class=""row"">
                <div id=""product-slider-2"" class=""owl-carousel"">
                    <div class=""col-3"">
                        <img src=""./assets/images/home/MANGO.png""
                             style=""width: 300px; height: 100px""");
            BeginWriteAttribute("alt", "\r\n                             alt=\"", 6227, "\"", 6263, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    </div>\r\n                    <div class=\"col-3\">\r\n                        <img src=\"./assets/images/home/BERSHKA.png\"\r\n                             style=\"width: 300px; height: 100px\"");
            BeginWriteAttribute("alt", "\r\n                             alt=\"", 6471, "\"", 6507, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    </div>\r\n                    <div class=\"col-3\">\r\n                        <img src=\"./assets/images/home/ZARA.png\"\r\n                             style=\"width: 300px; height: 100px\"");
            BeginWriteAttribute("alt", "\r\n                             alt=\"", 6712, "\"", 6748, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    </div>\r\n                    <div class=\"col-3\">\r\n                        <img src=\"./assets/images/home/TERRANOVA.png\"\r\n                             style=\"width: 300px; height: 100px\"");
            BeginWriteAttribute("alt", "\r\n                             alt=\"", 6958, "\"", 6994, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    </div>\r\n                    <div class=\"col-3\">\r\n                        <img src=\"./assets/images/home/PULL & BEAR.png\"\r\n                             style=\"width: 300px; height: 100px\"");
            BeginWriteAttribute("alt", "\r\n                             alt=\"", 7206, "\"", 7242, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    </div>\r\n                    <div class=\"col-3\">\r\n                        <img src=\"./assets/images/home/LTB.png\"\r\n                             style=\"width: 300px; height: 100px\"");
            BeginWriteAttribute("alt", "\r\n                             alt=\"", 7446, "\"", 7482, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</main>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdn.jsdelivr.net/npm/swiper/swiper-bundle.min.js""></script>
    <script src=""https://code.jquery.com/jquery-1.12.4.min.js""
        crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/owl-carousel/1.3.3/owl.carousel.min.js""
        crossorigin=""anonymous""
        referrerpolicy=""no-referrer""></script>
    <script src=""https://kit.fontawesome.com/b39b112ecb.js""
        crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js""
        crossorigin=""anonymous""></script>
    <script src=""./assets/js/home.js""></script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
