#pragma checksum "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Shared\Components\AboutList\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0795fedab2d8eb84a5a8658228cf3a2d9396946db8f9b94d5adc1ed2c598be7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AboutList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AboutList/Default.cshtml")]
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
#line 1 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Shared\Components\AboutList\Default.cshtml"
using EntityLayer.Concrate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"0795fedab2d8eb84a5a8658228cf3a2d9396946db8f9b94d5adc1ed2c598be7d", @"/Views/Shared/Components/AboutList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"48d7d692876c63d8c26f396bf085d9fb803cacb7c1d6009c9fc8f478be37f7a8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_AboutList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<About>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"section pt-4 px-3 px-lg-4\" id=\"about\">\r\n    <div class=\"container-narrow\">\r\n");
#nullable restore
#line 5 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Shared\Components\AboutList\Default.cshtml"
         foreach(var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-md-6\">\r\n                <h2 class=\"h4 my-2\">");
#nullable restore
#line 8 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Shared\Components\AboutList\Default.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <p>");
#nullable restore
#line 9 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Shared\Components\AboutList\Default.cshtml"
              Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                <div class=""row mt-3"">
                    <div class=""col-sm-2"">
                        <div class=""pb-1"">Yaş:</div>
                    </div>
                    <div class=""col-sm-10"">
                        <div class=""pb-1 fw-bolder"">");
#nullable restore
#line 15 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Shared\Components\AboutList\Default.cshtml"
                                               Write(item.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                    <div class=""col-sm-2"">
                        <div class=""pb-1"">Mail:</div>
                    </div>
                    <div class=""col-sm-10"">
                        <div class=""pb-1 fw-bolder"">");
#nullable restore
#line 21 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Shared\Components\AboutList\Default.cshtml"
                                               Write(item.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>

                    <div class=""col-sm-2"">
                        <div class=""pb-1"">Telefon:</div>
                    </div>
                    <div class=""col-sm-10"">
                        <div class=""pb-1 fw-bolder"">");
#nullable restore
#line 28 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Shared\Components\AboutList\Default.cshtml"
                                               Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                    <div class=""col-sm-2"">
                        <div class=""pb-1"">Adres:</div>
                    </div>
                    <div class=""col-sm-10"">
                        <div class=""pb-1 fw-bolder"">");
#nullable restore
#line 34 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Shared\Components\AboutList\Default.cshtml"
                                               Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n             \r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-5 offset-md-1\" data-aos=\"fade-left\" data-aos-delay=\"100\"><img class=\"avatar img-fluid mt-2\"");
            BeginWriteAttribute("src", " src=\"", 1643, "\"", 1663, 1);
#nullable restore
#line 39 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Shared\Components\AboutList\Default.cshtml"
WriteAttributeValue("", 1649, item.ImageUrl, 1649, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"400\" height=\"400\" alt=\"EyüpÇakmaker\" /></div>\r\n        </div>\r\n");
#nullable restore
#line 41 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Shared\Components\AboutList\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<About>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
