#pragma checksum "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Shared\Components\PortfolioList\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2a827bbc7b9f1e200af092335dcf876de839db0d2aa49cd153cb8ab9dcd32a0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_PortfolioList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/PortfolioList/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\_ViewImports.cshtml"
using Asp.NetCoreProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\_ViewImports.cshtml"
using Asp.NetCoreProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Shared\Components\PortfolioList\Default.cshtml"
using EntityLayer.Concrate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"2a827bbc7b9f1e200af092335dcf876de839db0d2aa49cd153cb8ab9dcd32a0e", @"/Views/Shared/Components/PortfolioList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"48d7d692876c63d8c26f396bf085d9fb803cacb7c1d6009c9fc8f478be37f7a8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_PortfolioList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Portfolio>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""section px-2 px-lg-4 pt-5"" id=""portfolio"">
    <div class=""container"">
        <div class=""text-center mb-5"">
            <h2 class=""marker marker-center"">Projelerim </h2>
        </div>
        <div class=""grid bp-gallery pb-3"" data-aos=""zoom-in-up"" data-aos-delay=""100"">
            <div class=""grid-sizer""></div>
");
#nullable restore
#line 12 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Shared\Components\PortfolioList\Default.cshtml"
             foreach(var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"grid-item\">\r\n                <a href=\"https://dribbble.com\">\r\n                    <figure class=\"portfolio-item\">\r\n                        <img  style=\"Height:220px;\"");
            BeginWriteAttribute("src", " src=\"", 624, "\"", 644, 1);
#nullable restore
#line 16 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Shared\Components\PortfolioList\Default.cshtml"
WriteAttributeValue("", 630, item.ImageUrl, 630, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-bp=\"");
#nullable restore
#line 16 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Shared\Components\PortfolioList\Default.cshtml"
                                                                             Write(item.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />\r\n                        <figcaption>\r\n                            <h4 class=\"h5 mb-0\">");
#nullable restore
#line 18 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Shared\Components\PortfolioList\Default.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            <div>");
#nullable restore
#line 19 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Shared\Components\PortfolioList\Default.cshtml"
                            Write(item.ProjectUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </figcaption>\r\n                    </figure>\r\n                </a>\r\n            </div>\r\n");
#nullable restore
#line 24 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Shared\Components\PortfolioList\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Portfolio>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
