#pragma checksum "D:\SCHOOL\ASP.NET Core\CaseStudy\CaseStudy\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ff0584f92d580e88878f4b475e50d917bd2a67f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Index.cshtml", typeof(AspNetCore.Views_Product_Index))]
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
#line 1 "D:\SCHOOL\ASP.NET Core\CaseStudy\CaseStudy\Views\_ViewImports.cshtml"
using CaseStudy;

#line default
#line hidden
#line 2 "D:\SCHOOL\ASP.NET Core\CaseStudy\CaseStudy\Views\_ViewImports.cshtml"
using CaseStudy.Models;

#line default
#line hidden
#line 3 "D:\SCHOOL\ASP.NET Core\CaseStudy\CaseStudy\Views\_ViewImports.cshtml"
using CaseStudy.Utils;

#line default
#line hidden
#line 4 "D:\SCHOOL\ASP.NET Core\CaseStudy\CaseStudy\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#line 5 "D:\SCHOOL\ASP.NET Core\CaseStudy\CaseStudy\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ff0584f92d580e88878f4b475e50d917bd2a67f", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be391ecc98a96d33b0c2948e08797b31802bbf57", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\SCHOOL\ASP.NET Core\CaseStudy\CaseStudy\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(68, 24, true);
            WriteLiteral("<h4>Items In Category - ");
            EndContext();
            BeginContext(93, 15, false);
#line 6 "D:\SCHOOL\ASP.NET Core\CaseStudy\CaseStudy\Views\Product\Index.cshtml"
                   Write(Model.BrandName);

#line default
#line hidden
            EndContext();
            BeginContext(108, 51, true);
            WriteLiteral("</h4>\r\n<ul class=\"list-group col-sm-8 col-xs-12\">\r\n");
            EndContext();
#line 8 "D:\SCHOOL\ASP.NET Core\CaseStudy\CaseStudy\Views\Product\Index.cshtml"
      
        foreach (Products item in Model.Items)
        {

#line default
#line hidden
            BeginContext(226, 58, true);
            WriteLiteral("            <li class=\"list-group-item\">\r\n                ");
            EndContext();
            BeginContext(285, 16, false);
#line 12 "D:\SCHOOL\ASP.NET Core\CaseStudy\CaseStudy\Views\Product\Index.cshtml"
           Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(301, 21, true);
            WriteLiteral("\r\n            </li>\r\n");
            EndContext();
#line 14 "D:\SCHOOL\ASP.NET Core\CaseStudy\CaseStudy\Views\Product\Index.cshtml"
        }
    

#line default
#line hidden
            BeginContext(340, 7, true);
            WriteLiteral("</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
