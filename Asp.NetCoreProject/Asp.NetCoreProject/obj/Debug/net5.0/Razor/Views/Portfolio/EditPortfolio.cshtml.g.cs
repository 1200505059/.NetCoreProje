#pragma checksum "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Portfolio\EditPortfolio.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "aecb5dd7954c05ea3be55f20f47a7818646fc81c66d410a64383b67e6556d6fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portfolio_EditPortfolio), @"mvc.1.0.view", @"/Views/Portfolio/EditPortfolio.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"aecb5dd7954c05ea3be55f20f47a7818646fc81c66d410a64383b67e6556d6fc", @"/Views/Portfolio/EditPortfolio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"48d7d692876c63d8c26f396bf085d9fb803cacb7c1d6009c9fc8f478be37f7a8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Portfolio_EditPortfolio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrate.Portfolio>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Portfolio\EditPortfolio.cshtml"
  
    ViewData["Title"] = "EditPortfolio";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"color:white;\">Proje Ekleme Paneli</h1>\r\n");
#nullable restore
#line 8 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Portfolio\EditPortfolio.cshtml"
 using (Html.BeginForm("EditPortfolio", "Portfolio", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Portfolio\EditPortfolio.cshtml"
Write(Html.HiddenFor(x=>x.PortfolioID));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <br />\r\n    <br />\r\n    <label>Proje Başlığı</label>\r\n");
#nullable restore
#line 15 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Portfolio\EditPortfolio.cshtml"
Write(Html.TextBoxFor(x=>x.Name,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Portfolio\EditPortfolio.cshtml"
Write(Html.ValidationMessageFor(x=>x.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Resim</label>\r\n");
#nullable restore
#line 19 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Portfolio\EditPortfolio.cshtml"
Write(Html.TextBoxFor(x=>x.ImageUrl,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Portfolio\EditPortfolio.cshtml"
Write(Html.ValidationMessageFor(x=>x.ImageUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Tarih  </label>\r\n");
#nullable restore
#line 23 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Portfolio\EditPortfolio.cshtml"
Write(Html.TextBoxFor(x=>x.Time,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Portfolio\EditPortfolio.cshtml"
Write(Html.ValidationMessageFor(x=>x.Time));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Proje Linki </label>\r\n");
#nullable restore
#line 27 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Portfolio\EditPortfolio.cshtml"
Write(Html.TextAreaFor(x=>x.ProjectUrl,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Portfolio\EditPortfolio.cshtml"
Write(Html.ValidationMessageFor(x=>x.ProjectUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Durum(True veya False) </label>\r\n");
#nullable restore
#line 31 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Portfolio\EditPortfolio.cshtml"
Write(Html.TextAreaFor(x=>x.Status,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Portfolio\EditPortfolio.cshtml"
Write(Html.ValidationMessageFor(x=>x.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-primary\">Kaydet</button>\r\n    <br />\r\n");
#nullable restore
#line 36 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Portfolio\EditPortfolio.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrate.Portfolio> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
