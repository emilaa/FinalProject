#pragma checksum "C:\Users\Emil Abdullayev\Desktop\Programming\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Areas\Admin\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "694c104d15817b9275e35825cbc243b07d874751"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/Detail.cshtml")]
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
#line 1 "C:\Users\Emil Abdullayev\Desktop\Programming\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Areas\Admin\Views\_ViewImports.cshtml"
using Online_Shop___BackEnd.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Emil Abdullayev\Desktop\Programming\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Areas\Admin\Views\_ViewImports.cshtml"
using Online_Shop___BackEnd.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Emil Abdullayev\Desktop\Programming\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Areas\Admin\Views\_ViewImports.cshtml"
using Online_Shop___BackEnd.ViewModels.CategoryViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Emil Abdullayev\Desktop\Programming\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Areas\Admin\Views\_ViewImports.cshtml"
using Online_Shop___BackEnd.ViewModels.SubCategoryViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Emil Abdullayev\Desktop\Programming\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Areas\Admin\Views\_ViewImports.cshtml"
using Online_Shop___BackEnd.ViewModels.ProductViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Emil Abdullayev\Desktop\Programming\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Areas\Admin\Views\_ViewImports.cshtml"
using Online_Shop___BackEnd.ViewModels.BlogViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"694c104d15817b9275e35825cbc243b07d874751", @"/Areas/Admin/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cea1d8282a6d2505ebdd2f9369418d2ee70e1d86", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDetailVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius: 5px; width: 150px; height: 200px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container"">
    <div class=""col-lg-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Product detail</h4>
                <div class=""table-responsive pt-3"">
                    <table class=""table table-bordered my-3"">
                        <thead>
                            <tr>
                                <th>
                                    Image
                                </th>
                                <th>
                                    Name
                                </th>
                                <th>
                                    Description
                                </th>
                                <th>
                                    Price
                                </th>
                                <th>
                                    Brand
                                </th>
                              ");
            WriteLiteral(@"  <th>
                                    Category
                                </th>
                                <th>
                                    Size
                                </th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "694c104d15817b9275e35825cbc243b07d8747516778", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1537, "~/assets/images/home/products/", 1537, 30, true);
#nullable restore
#line 38 "C:\Users\Emil Abdullayev\Desktop\Programming\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Areas\Admin\Views\Product\Detail.cshtml"
AddHtmlAttributeValue("", 1567, Model.Images.Where(m => m.IsMain).FirstOrDefault()?.Name, 1567, 57, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                                <td style=\"font-size: 25px;\">\r\n                                    ");
#nullable restore
#line 41 "C:\Users\Emil Abdullayev\Desktop\Programming\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Areas\Admin\Views\Product\Detail.cshtml"
                               Write(Html.Raw(Model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td style=\"font-size: 18px;\">\r\n                                    ");
#nullable restore
#line 44 "C:\Users\Emil Abdullayev\Desktop\Programming\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Areas\Admin\Views\Product\Detail.cshtml"
                               Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 47 "C:\Users\Emil Abdullayev\Desktop\Programming\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Areas\Admin\Views\Product\Detail.cshtml"
                               Write(Html.Raw(Model.Price.ToString("N2")));

#line default
#line hidden
#nullable disable
            WriteLiteral("$\r\n                                </td>\r\n                                <td style=\"font-size: 18px;\">\r\n                                    ");
#nullable restore
#line 50 "C:\Users\Emil Abdullayev\Desktop\Programming\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Areas\Admin\Views\Product\Detail.cshtml"
                               Write(Html.Raw(Model.Brand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td style=\"font-size: 18px;\">\r\n                                    ");
#nullable restore
#line 53 "C:\Users\Emil Abdullayev\Desktop\Programming\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Areas\Admin\Views\Product\Detail.cshtml"
                               Write(Html.Raw(Model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td style=\"font-size: 18px;\">\r\n");
#nullable restore
#line 56 "C:\Users\Emil Abdullayev\Desktop\Programming\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Areas\Admin\Views\Product\Detail.cshtml"
                                     foreach (var size in Model.Size)
                                    {
                                        if (size.SubCategory.CategoryId == 1)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <p>");
#nullable restore
#line 60 "C:\Users\Emil Abdullayev\Desktop\Programming\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Areas\Admin\Views\Product\Detail.cshtml"
                                          Write(Html.Raw(size.SubCategory.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 61 "C:\Users\Emil Abdullayev\Desktop\Programming\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Areas\Admin\Views\Product\Detail.cshtml"
                                        }
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <table class=""table table-bordered my-3"">
                        <thead>
                            <tr>
                                <th>
                                    Images
                                </th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>
");
#nullable restore
#line 78 "C:\Users\Emil Abdullayev\Desktop\Programming\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Areas\Admin\Views\Product\Detail.cshtml"
                                     foreach (var image in Model.Images)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "694c104d15817b9275e35825cbc243b07d87475113176", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3735, "~/assets/images/home/products/", 3735, 30, true);
#nullable restore
#line 80 "C:\Users\Emil Abdullayev\Desktop\Programming\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Areas\Admin\Views\Product\Detail.cshtml"
AddHtmlAttributeValue("", 3765, image.Name, 3765, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 81 "C:\Users\Emil Abdullayev\Desktop\Programming\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Areas\Admin\Views\Product\Detail.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                            </tr>\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDetailVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
