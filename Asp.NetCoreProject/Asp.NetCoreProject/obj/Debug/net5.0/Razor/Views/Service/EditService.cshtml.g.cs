#pragma checksum "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Service\EditService.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1bac41db321c14a61667e0ce2d551a7f84209b94befbd2f52a03036eb4fa2d01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_EditService), @"mvc.1.0.view", @"/Views/Service/EditService.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"1bac41db321c14a61667e0ce2d551a7f84209b94befbd2f52a03036eb4fa2d01", @"/Views/Service/EditService.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"48d7d692876c63d8c26f396bf085d9fb803cacb7c1d6009c9fc8f478be37f7a8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Service_EditService : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrate.Service>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Service\EditService.cshtml"
  
    ViewData["Title"] = "EditService";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"color:white;\">Hizmet Düzenleme Paneli</h1>\r\n");
#nullable restore
#line 8 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Service\EditService.cshtml"
 using (Html.BeginForm("EditService", "Service", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Service\EditService.cshtml"
Write(Html.HiddenFor(x=> x.ServiceID));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <br />\r\n    <label>Hizmet Başlığı </label>\r\n");
#nullable restore
#line 14 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Service\EditService.cshtml"
Write(Html.TextBoxFor(x=>x.Title,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Resim </label>\r\n");
#nullable restore
#line 17 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Service\EditService.cshtml"
Write(Html.TextBoxFor(x=>x.ImageUrl,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-outline-primary\">Güncelle</button>\r\n    <br />\r\n");
#nullable restore
#line 21 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Service\EditService.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrate.Service> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591