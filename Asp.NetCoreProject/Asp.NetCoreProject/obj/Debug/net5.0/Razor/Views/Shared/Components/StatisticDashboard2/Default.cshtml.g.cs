#pragma checksum "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Shared\Components\StatisticDashboard2\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4eedac453a62d787dd57755b2beea2fb53b1d1f446511516b649beba255ac9aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_StatisticDashboard2_Default), @"mvc.1.0.view", @"/Views/Shared/Components/StatisticDashboard2/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4eedac453a62d787dd57755b2beea2fb53b1d1f446511516b649beba255ac9aa", @"/Views/Shared/Components/StatisticDashboard2/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"48d7d692876c63d8c26f396bf085d9fb803cacb7c1d6009c9fc8f478be37f7a8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_StatisticDashboard2_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-sm-4 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h5>Proje Sayısı</h5>
                <div class=""row"">
                    <div class=""col-8 col-sm-12 col-xl-8 my-auto"">
                        <div class=""d-flex d-sm-block d-md-flex align-items-center"">
                            <h2 class=""mb-0"">");
#nullable restore
#line 9 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Shared\Components\StatisticDashboard2\Default.cshtml"
                                        Write(ViewBag.v1);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>                
                        </div>
                        <h6 class=""text-muted font-weight-normal"">Aktif ve tamamlanan proje sayısı</h6>
                    </div>
                    <div class=""col-4 col-sm-12 col-xl-4 text-center text-xl-right"">
                        <i class=""icon-lg mdi mdi-codepen text-primary ml-auto""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-sm-4 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h5>Toplam Mesaj sayısı</h5>
                <div class=""row"">
                    <div class=""col-8 col-sm-12 col-xl-8 my-auto"">
                        <div class=""d-flex d-sm-block d-md-flex align-items-center"">
                            <h2 class=""mb-0"">");
#nullable restore
#line 27 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Shared\Components\StatisticDashboard2\Default.cshtml"
                                        Write(ViewBag.v2);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                           
                        </div>
                        <h6 class=""text-muted font-weight-normal"">Son bir Ayda gelen mesajlar</h6>
                    </div>
                    <div class=""col-4 col-sm-12 col-xl-4 text-center text-xl-right"">
                        <i class=""icon-lg mdi mdi-wallet-travel text-danger ml-auto""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-sm-4 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h5>Hizmetler</h5>
                <div class=""row"">
                    <div class=""col-8 col-sm-12 col-xl-8 my-auto"">
                        <div class=""d-flex d-sm-block d-md-flex align-items-center"">
                            <h2 class=""mb-0"">");
#nullable restore
#line 46 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Shared\Components\StatisticDashboard2\Default.cshtml"
                                        Write(ViewBag.v3);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                            
                        </div>
                        <h6 class=""text-muted font-weight-normal"">Verilen Hizmet Detayları</h6>
                    </div>
                    <div class=""col-4 col-sm-12 col-xl-4 text-center text-xl-right"">
                        <i class=""icon-lg mdi mdi-monitor text-success ml-auto""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
