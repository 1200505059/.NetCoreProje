#pragma checksum "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Shared\Components\ServiceList\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6c5257c270cc35c55899d47b42b983be2abd3ce06f0841e297c5f56511a6d529"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ServiceList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ServiceList/Default.cshtml")]
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
#line 1 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Shared\Components\ServiceList\Default.cshtml"
using EntityLayer.Concrate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6c5257c270cc35c55899d47b42b983be2abd3ce06f0841e297c5f56511a6d529", @"/Views/Shared/Components/ServiceList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"48d7d692876c63d8c26f396bf085d9fb803cacb7c1d6009c9fc8f478be37f7a8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_ServiceList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Service>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""section px-3 px-lg-4 pt-5"" id=""services"">
    <div class=""container-narrow"">
        <div class=""text-center mb-5"">
            <h2 class=""marker marker-center"">Hizmetlerim</h2>
        </div>
        <div class=""text-center"">
            <p class=""mx-auto mb-3"" style=""max-width:600px""></p>
        </div>
        <div class=""row py-3"" >
");
#nullable restore
#line 13 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Shared\Components\ServiceList\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-3 text-center\" data-aos=\"fade-up\" data-aos-delay=\"100\"style=\"Float:left;\">\r\n                <img class=\"mb-2\"");
            BeginWriteAttribute("src", " src=\"", 610, "\"", 630, 1);
#nullable restore
#line 16 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Shared\Components\ServiceList\Default.cshtml"
WriteAttributeValue("", 616, item.ImageUrl, 616, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"96\" height=\"96\" alt=\"web design\" />\r\n                <div class=\"h5\">");
#nullable restore
#line 17 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Shared\Components\ServiceList\Default.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n");
#nullable restore
#line 19 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Shared\Components\ServiceList\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br />\r\n            <br />\r\n        </div>    \r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Service>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
