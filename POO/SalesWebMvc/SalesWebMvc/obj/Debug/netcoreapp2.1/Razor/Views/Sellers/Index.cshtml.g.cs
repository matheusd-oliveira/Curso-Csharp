#pragma checksum "C:\temp\vs-2019\POO\SalesWebMvc\SalesWebMvc\Views\Sellers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50853c2fa3dcf9e1462606d2c047c198f01ed074"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sellers_Index), @"mvc.1.0.view", @"/Views/Sellers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sellers/Index.cshtml", typeof(AspNetCore.Views_Sellers_Index))]
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
#line 1 "C:\temp\vs-2019\POO\SalesWebMvc\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc;

#line default
#line hidden
#line 2 "C:\temp\vs-2019\POO\SalesWebMvc\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50853c2fa3dcf9e1462606d2c047c198f01ed074", @"/Views/Sellers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70dafd425af89a5439216963c7093f2ead686e4a", @"/Views/_ViewImports.cshtml")]
    public class Views_Sellers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SalesWebMvc.Models.Seller>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\temp\vs-2019\POO\SalesWebMvc\SalesWebMvc\Views\Sellers\Index.cshtml"
   
    ViewData["Title"] = "Sellers";

#line default
#line hidden
            BeginContext(93, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(100, 17, false);
#line 7 "C:\temp\vs-2019\POO\SalesWebMvc\SalesWebMvc\Views\Sellers\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(117, 113, true);
            WriteLiteral("</h2>\r\n\r\n<table class=\"table-striped table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(231, 40, false);
#line 13 "C:\temp\vs-2019\POO\SalesWebMvc\SalesWebMvc\Views\Sellers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(271, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(327, 41, false);
#line 16 "C:\temp\vs-2019\POO\SalesWebMvc\SalesWebMvc\Views\Sellers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(368, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(424, 45, false);
#line 19 "C:\temp\vs-2019\POO\SalesWebMvc\SalesWebMvc\Views\Sellers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(469, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(525, 46, false);
#line 22 "C:\temp\vs-2019\POO\SalesWebMvc\SalesWebMvc\Views\Sellers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BaseSalary));

#line default
#line hidden
            EndContext();
            BeginContext(571, 63, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 27 "C:\temp\vs-2019\POO\SalesWebMvc\SalesWebMvc\Views\Sellers\Index.cshtml"
         foreach (var item in Model)
        { 

#line default
#line hidden
            BeginContext(684, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(733, 39, false);
#line 31 "C:\temp\vs-2019\POO\SalesWebMvc\SalesWebMvc\Views\Sellers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(772, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(828, 40, false);
#line 34 "C:\temp\vs-2019\POO\SalesWebMvc\SalesWebMvc\Views\Sellers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(868, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(924, 44, false);
#line 37 "C:\temp\vs-2019\POO\SalesWebMvc\SalesWebMvc\Views\Sellers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(968, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1024, 45, false);
#line 40 "C:\temp\vs-2019\POO\SalesWebMvc\SalesWebMvc\Views\Sellers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BaseSalary));

#line default
#line hidden
            EndContext();
            BeginContext(1069, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 43 "C:\temp\vs-2019\POO\SalesWebMvc\SalesWebMvc\Views\Sellers\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1116, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SalesWebMvc.Models.Seller>> Html { get; private set; }
    }
}
#pragma warning restore 1591