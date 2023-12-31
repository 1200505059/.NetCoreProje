#pragma checksum "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Service\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3d8de04ccf6f58d233fa0361504a273db7f0268d012dcdaf92764c541d0f9951"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Index), @"mvc.1.0.view", @"/Views/Service/Index.cshtml")]
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
#line 1 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Service\Index.cshtml"
using EntityLayer.Concrate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"3d8de04ccf6f58d233fa0361504a273db7f0268d012dcdaf92764c541d0f9951", @"/Views/Service/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"48d7d692876c63d8c26f396bf085d9fb803cacb7c1d6009c9fc8f478be37f7a8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Service_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Service>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Service\Index.cshtml"
  
    ViewData["Title"] = "Index";
  Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""row"">
    <div class=""col"">
        <div class=""card bg-default shadow"">
            <div class=""card-header bg-transparent border-0"">
                <h3 class=""text-white mb-0"">Hizmet Tablosu</h3>
            </div>
            <div class=""table-responsive"">
                <table class=""table align-items-center table-dark table-flush"">
                    <thead class=""thead-dark"">
                        <tr>
                            <th scope=""col"" class=""sort"" data-sort=""name"">#</th>
                            <th scope=""col"" class=""sort"" data-sort=""budget"">Başlık</th>
                            <th scope=""col"">Sil</th>
                            <th scope=""col"" class=""sort"" data-sort=""completion"">Güncelle</th>
                        </tr>
                    </thead>
                    <tbody class=""list"">
");
#nullable restore
#line 28 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Service\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 31 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Service\Index.cshtml"
                               Write(item.ServiceID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"budget\">");
#nullable restore
#line 32 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Service\Index.cshtml"
                                              Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1295, "\"", 1340, 2);
            WriteAttributeValue("", 1302, "/Service/DeleteService/", 1302, 23, true);
#nullable restore
#line 33 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Service\Index.cshtml"
WriteAttributeValue("", 1325, item.ServiceID, 1325, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\">Sil</a></td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1426, "\"", 1469, 2);
            WriteAttributeValue("", 1433, "/Service/EditService/", 1433, 21, true);
#nullable restore
#line 34 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Service\Index.cshtml"
WriteAttributeValue("", 1454, item.ServiceID, 1454, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\r\n                            </tr>\r\n");
#nullable restore
#line 36 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Service\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n                <br />\r\n                <a href=\"/Service/AddService/\" class=\"btn btn-primary\">Hizmet ekle</a>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
