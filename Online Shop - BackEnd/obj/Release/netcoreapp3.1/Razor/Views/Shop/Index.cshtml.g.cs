#pragma checksum "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Shop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26ba264ab2b4776ea5eafb25e8874bc348a34de5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Index), @"mvc.1.0.view", @"/Views/Shop/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26ba264ab2b4776ea5eafb25e8874bc348a34de5", @"/Views/Shop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18e07f2957cad4badc5c3ee141397521b9d73daa", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/shop/shop.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: black;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ProductsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/script.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/shop.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("Links", async() => {
                WriteLiteral("\r\n    <link href=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css\"\r\n      rel=\"stylesheet\"\r\n      crossorigin=\"anonymous\" />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "26ba264ab2b4776ea5eafb25e8874bc348a34de56874", async() => {
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
                WriteLiteral(@"
    <title>Shop</title>

    <style>
        .show-more {
            width: 100%;
            display: flex;
            justify-content: center;
            padding-top: 30px;
        }

            .show-more .button {
                width: 150px;
                padding: 10px;
                border: none;
                outline: none;
                border-radius: 5px;
                text-align: center;
                font-size: 15px;
                color: #fff;
                cursor: pointer;
                transition: all 0.5s;
            }

        .hover-btn {
            background-color: #C72121;
        }

            .hover-btn span {
                position: relative;
                display: inline-block;
                cursor: pointer;
                transition: 0.5s;
            }

                .hover-btn span::after {
                    position: absolute;
                    content: ""\00bb"";
                    opacity: 0;
           ");
                WriteLiteral(@"         top: 0;
                    right: -25px;
                    transition: 0.5s;
                }

            .hover-btn:hover span {
                padding-right: 25px;
            }

                .hover-btn:hover span::after {
                    opacity: 1;
                    right: 0;
                }

        ");
                WriteLiteral("@media(max-width: 1200px) {\r\n            #parent-products {\r\n                padding-left: 50px;\r\n            }\r\n\r\n                #parent-products .price span {\r\n                    margin-left: 70px;\r\n                }\r\n        }\r\n    </style>\r\n");
            }
            );
            WriteLiteral("\r\n<main>\r\n");
#nullable restore
#line 73 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Shop\Index.cshtml"
     foreach (var banner in Model.PageHeaders)
    {
        if (banner.Id == 3)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <section id=\"shop-bg\"");
            BeginWriteAttribute("style", "\r\n             style=\"", 2004, "\"", 2083, 4);
            WriteAttributeValue("", 2026, "background-image:", 2026, 17, true);
            WriteAttributeValue(" ", 2043, "url(./assets/images/shop/", 2044, 26, true);
#nullable restore
#line 78 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Shop\Index.cshtml"
WriteAttributeValue("", 2069, banner.Image, 2069, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2082, ")", 2082, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <h2>");
#nullable restore
#line 79 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Shop\Index.cshtml"
               Write(banner.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            </section>\r\n");
#nullable restore
#line 81 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Shop\Index.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <section id=""shop-product"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-3 col-md-6 col-sm-12"">
                    <div class=""filter-product"">
                        <h2>Filters</h2>
                        <div class=""search"">
                            <input id=""search-box"" type=""text"" placeholder=""Search"" />
                        </div>
                        <ul style=""padding: 0;"" id=""search-list-product"" class=""d-block "">
                        </ul>

                        <div class=""brand"">
                            <h5>Size</h5>
");
#nullable restore
#line 98 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Shop\Index.cshtml"
                             foreach (var brand in Model.SubCategories)
                            {
                                if (brand.CategoryId == 1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <input type=\"checkbox\" id=\"_checkbox-8\" />\r\n                                    <label for=\"_checkbox-8\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26ba264ab2b4776ea5eafb25e8874bc348a34de512680", async() => {
                WriteLiteral("<p>");
#nullable restore
#line 104 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Shop\Index.cshtml"
                                                                                                           Write(brand.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 104 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Shop\Index.cshtml"
                                                                WriteLiteral(brand.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        <div class=\"tick-mark\"></div>\r\n                                    </label>\r\n                                    <br />\r\n");
#nullable restore
#line 108 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Shop\Index.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n\r\n                        <div class=\"brand\">\r\n                            <h5>Brand</h5>\r\n");
#nullable restore
#line 114 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Shop\Index.cshtml"
                             foreach (var brand in Model.SubCategories)
                            {
                                if (brand.CategoryId == 2)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <input type=\"checkbox\" id=\"_checkbox-8\" />\r\n                                    <label for=\"_checkbox-8\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26ba264ab2b4776ea5eafb25e8874bc348a34de516551", async() => {
                WriteLiteral("<p>");
#nullable restore
#line 120 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Shop\Index.cshtml"
                                                                                                           Write(brand.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 120 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Shop\Index.cshtml"
                                                                WriteLiteral(brand.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        <div class=\"tick-mark\"></div>\r\n                                    </label>\r\n                                    <br />\r\n");
#nullable restore
#line 124 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Shop\Index.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                </div>
                <div class=""col-9"">
                    <section id=""products"">
                        <div class=""container"">
                            <div class=""row pt-5"">
                                <div class=""col-12""
                                     style=""
                        display: flex !important;
                        justify-content: center !important;
                      "">
                                    <ul class=""category-mobile d-md-none list-unstyled"">
                                        <li>
                                            <a");
            BeginWriteAttribute("href", " href=\"", 5011, "\"", 5018, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""categories mr-2"">Categories</a>
                                            <i class=""fas fa-caret-down""></i>
                                            <ul class=""category list-unstyled""
                                                style=""display: none"">
                                                <li><a");
            BeginWriteAttribute("href", " href=\"", 5345, "\"", 5352, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"All\">All</a></li>\r\n");
#nullable restore
#line 145 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Shop\Index.cshtml"
                                                 foreach (var category in Model.SubCategories)
                                                {
                                                    if (category.CategoryId == 5)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 5729, "\"", 5736, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 149 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Shop\Index.cshtml"
                                                                           Write(category.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 149 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Shop\Index.cshtml"
                                                                                         Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 150 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Shop\Index.cshtml"
                                                    }
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </ul>
                                        </li>
                                    </ul>

                                    <ul class=""category d-none d-md-flex list-unstyled"">
                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 6171, "\"", 6178, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"All\">All</a></li>\r\n");
#nullable restore
#line 158 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Shop\Index.cshtml"
                                         foreach (var category in Model.SubCategories)
                                        {
                                            if (category.CategoryId == 5)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li><a");
            BeginWriteAttribute("href", " href=\"", 6515, "\"", 6522, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 162 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Shop\Index.cshtml"
                                                                   Write(category.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 162 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Shop\Index.cshtml"
                                                                                 Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 163 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Shop\Index.cshtml"
                                            }
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </ul>\r\n                                </div>\r\n                            </div>\r\n                            <input type=\"hidden\" id=\"product-count\" name=\"name\"");
            BeginWriteAttribute("value", " value=\"", 6860, "\"", 6882, 1);
#nullable restore
#line 168 "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Shop\Index.cshtml"
WriteAttributeValue("", 6868, ViewBag.count, 6868, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            <div class=\"row\" id=\"parent-products\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "26ba264ab2b4776ea5eafb25e8874bc348a34de525607", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                    </section>
                    <div class=""show-more"">
                        <button class=""button hover-btn""><span>Show more</span></button>
                    </div>
                </div>
            </div>
        </div>
    </section>
</main>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"    <script src=""https://cdnjs.cloudflare.com/ajax/libs/fslightbox/3.3.1/index.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.3/jquery.min.js"" integrity=""sha512-STof4xm1wgkfm7heWqFJVn58Hm3EtS31XFaagaa8VMReCXAkQnJZ+jEy8PCC/iT18dFy95WcExNHFTqLyp72eQ=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26ba264ab2b4776ea5eafb25e8874bc348a34de527571", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.1/jquery.min.js""
        crossorigin=""anonymous""
        referrerpolicy=""no-referrer""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js""
        crossorigin=""anonymous""></script>
    <script src=""https://code.jquery.com/jquery-1.12.4.min.js""
        crossorigin=""anonymous""></script>
    <script src=""https://kit.fontawesome.com/b39b112ecb.js""
        crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/sweetalert2@7.12.15/dist/sweetalert2.all.min.js""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26ba264ab2b4776ea5eafb25e8874bc348a34de529312", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopVM> Html { get; private set; }
    }
}
#pragma warning restore 1591