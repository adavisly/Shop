#pragma checksum "F:\asp\Shop\Shop\Views\Manga\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b329786d0948cd3eca0a13a8db2b46281f26bfd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manga_List), @"mvc.1.0.view", @"/Views/Manga/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manga/List.cshtml", typeof(AspNetCore.Views_Manga_List))]
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
#line 1 "F:\asp\Shop\Shop\Views\_ViewImports.cshtml"
using Shop.ViewModels;

#line default
#line hidden
#line 2 "F:\asp\Shop\Shop\Views\_ViewImports.cshtml"
using Shop.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b329786d0948cd3eca0a13a8db2b46281f26bfd", @"/Views/Manga/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f67d845e5371e4c720b943bf40f713afc7b23e1d", @"/Views/_ViewImports.cshtml")]
    public class Views_Manga_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 24, true);
            WriteLiteral("<h1>Вся манга</h1>\r\n<h3>");
            EndContext();
            BeginContext(25, 18, false);
#line 2 "F:\asp\Shop\Shop\Views\Manga\List.cshtml"
Write(Model.currCategory);

#line default
#line hidden
            EndContext();
            BeginContext(43, 36, true);
            WriteLiteral("</h3>\r\n<div class=\"row mt-5 mb-2\">\r\n");
            EndContext();
#line 4 "F:\asp\Shop\Shop\Views\Manga\List.cshtml"
      
        foreach (Manga manga in Model.allManga)
        {
            

#line default
#line hidden
            BeginContext(160, 31, false);
#line 7 "F:\asp\Shop\Shop\Views\Manga\List.cshtml"
       Write(Html.Partial("AllManga", manga));

#line default
#line hidden
            EndContext();
#line 7 "F:\asp\Shop\Shop\Views\Manga\List.cshtml"
                                            
        }
    

#line default
#line hidden
            BeginContext(211, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
