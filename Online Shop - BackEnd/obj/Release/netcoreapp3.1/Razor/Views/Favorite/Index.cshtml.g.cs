#pragma checksum "C:\Users\Emil Abdullayev\Desktop\Final project\Online Shop - BackEnd\Online Shop - BackEnd\Views\Favorite\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d71e0d36d8ded8ccc984950632d54576a46b1e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Favorite_Index), @"mvc.1.0.view", @"/Views/Favorite/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d71e0d36d8ded8ccc984950632d54576a46b1e0", @"/Views/Favorite/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18e07f2957cad4badc5c3ee141397521b9d73daa", @"/Views/_ViewImports.cshtml")]
    public class Views_Favorite_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("Links", async() => {
                WriteLiteral(@"
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css""
      rel=""stylesheet""
      crossorigin=""anonymous"" />
    <link rel=""stylesheet"" href=""./assets/css/favorite/favorite.css"" />
    <title>Favorite product</title>
 ");
            }
            );
            WriteLiteral(@"
<main>
    <section id=""favorite-bg""
             style=""background-image: url(./assets/images/shop/breadcumb.jpg)"">
        <h2>FAVORITE PRODUCTS</h2>
    </section>
    <section id=""favorite-table"">
        <div class=""container py-5"">
            <div class=""row"">
                <div class=""col-md-12 d-flex align-items-center h-100"">
                    <div class=""card border-0 w-100"">
                        <div class=""card-body"">
                            <table id=""productTable""
                                   class=""table table-bordered align-middle"">
                                <thead class=""table-color"">
                                    <tr>
                                        <th>Image</th>
                                        <th>Brand</th>
                                        <th>Name</th>
                                        <th>Price</th>
                                        <th>Setting</th>
                                    </tr>
         ");
            WriteLiteral(@"                       </thead>
                                <tbody class=""table-body""></tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</main>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/limonte-sweetalert2/11.4.30/sweetalert2.all.min.js""></script>
    <script src=""https://kit.fontawesome.com/b39b112ecb.js""
        crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js""
        crossorigin=""anonymous""></script>
    <script src=""https://code.jquery.com/jquery-1.12.4.min.js""
        crossorigin=""anonymous""></script>
    <script src=""./assets/js/favorite.js""></script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
