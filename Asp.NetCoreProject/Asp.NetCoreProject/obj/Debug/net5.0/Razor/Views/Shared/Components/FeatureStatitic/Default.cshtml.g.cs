#pragma checksum "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Shared\Components\FeatureStatitic\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ac70d752601ec818f26274c66c179daf26bb7e291085ffc1ac05d45fc5e08a2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_FeatureStatitic_Default), @"mvc.1.0.view", @"/Views/Shared/Components/FeatureStatitic/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"ac70d752601ec818f26274c66c179daf26bb7e291085ffc1ac05d45fc5e08a2e", @"/Views/Shared/Components/FeatureStatitic/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"48d7d692876c63d8c26f396bf085d9fb803cacb7c1d6009c9fc8f478be37f7a8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_FeatureStatitic_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-xl-3 col-sm-6 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-9"">
                        <div class=""d-flex align-items-center align-self-start"">
                            <h3 class=""text-success mb-0"">");
#nullable restore
#line 8 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Shared\Components\FeatureStatitic\Default.cshtml"
                                                     Write(ViewBag.v1);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                         
                        </div>
                    </div>
                    <div class=""col-3"">
                        <div class="" icon icon-box-success"">
                            <span style=""color: green;"">🟢</span>
                        </div>

                    </div>
                </div>
                <h6 class=""text-muted font-weight-normal"">Yetenek Sayısı</h6>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-sm-6 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-9"">
                        <div class=""d-flex align-items-center align-self-start"">
                            <h3 class=""text-danger mb-0"">");
#nullable restore
#line 29 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Shared\Components\FeatureStatitic\Default.cshtml"
                                                    Write(ViewBag.v2);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                    
                        </div>
                    </div>
                    <div class=""col-3"">
                        <div class=""text-danger icon icon-box-danger"">
                            <span style=""color: red;"">🔴</span>
                        </div>

                    </div>
                </div>
                <h6 class=""text-muted font-weight-normal"">Okunmamış mesaj</h6>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-sm-6 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-9"">
                        <div class=""d-flex align-items-center align-self-start"">
                            <h3 class=""text-success mb-0"">");
#nullable restore
#line 50 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Shared\Components\FeatureStatitic\Default.cshtml"
                                                     Write(ViewBag.v3);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                        
                        </div>
                    </div>
                    <div class=""col-3"">
                        <div class=""text-success icon icon-box-success"">
                            <span style=""color: green;"">🟢</span>
                        </div>
                    </div>
                </div>
                <h6 class=""text-muted font-weight-normal"">Okunmuş Mesaj</h6>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-sm-6 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-9"">
                        <div class=""d-flex align-items-center align-self-start"">
                           <h3 class=""text-danger mb-0"">");
#nullable restore
#line 70 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Shared\Components\FeatureStatitic\Default.cshtml"
                                                   Write(ViewBag.v4);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                     
                        </div>
                    </div>
                    <div class=""col-3"">
                        <div class=""text-danger icon icon-box-danger"">
                            <span style=""color: red;"">🔴</span>
                        </div>

                    </div>
                </div>
                <h6 class=""text-muted font-weight-normal"">Çalışılan Firma </h6>
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