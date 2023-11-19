#pragma checksum "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Experience\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7ede849b2d2c5f73594bc9c7cf4155a66a2952863cd5a1f84250276a8507f7a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Experience_Index), @"mvc.1.0.view", @"/Views/Experience/Index.cshtml")]
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
#line 1 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Experience\Index.cshtml"
using EntityLayer.Concrate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7ede849b2d2c5f73594bc9c7cf4155a66a2952863cd5a1f84250276a8507f7a3", @"/Views/Experience/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"48d7d692876c63d8c26f396bf085d9fb803cacb7c1d6009c9fc8f478be37f7a8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Experience_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Experience>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Experience\Index.cshtml"
  
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
                <h3 class=""text-white mb-0"">DENEYİMLER TABLOSU</h3>
            </div>
            <div class=""table-responsive"">
                <table class=""table align-items-center table-dark table-flush"">
                    <thead class=""thead-dark"">
                        <tr>
                            <th scope=""col"" class=""sort"" data-sort=""name"">İD</th>
                            <th scope=""col"" class=""sort"" data-sort=""budget"">Başlık</th>
                            <th scope=""col"" class=""sort"" data-sort=""status"">Tarih</th>
                             <th scope=""col"">Sil</th>
                            <th scope=""col"" class=""sort"" data-sort=""completion"">Güncelle</th>
                            <th scope=""col""></th>
                        </tr>
                    </thead>
                    <tbody class=""list"">
");
#nullable restore
#line 28 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Experience\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 31 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Experience\Index.cshtml"
                               Write(item.ExperienceID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"budget\">");
#nullable restore
#line 32 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Experience\Index.cshtml"
                                              Write(item.ExperienceName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td> <span class=\"completion mr-2\">");
#nullable restore
#line 33 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Experience\Index.cshtml"
                                                              Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td> \r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1545, "\"", 1599, 2);
            WriteAttributeValue("", 1552, "/Experience/DeleteExperience/", 1552, 29, true);
#nullable restore
#line 34 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Experience\Index.cshtml"
WriteAttributeValue("", 1581, item.ExperienceID, 1581, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Sil</a></td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1677, "\"", 1729, 2);
            WriteAttributeValue("", 1684, "/Experience/EditExperience/", 1684, 27, true);
#nullable restore
#line 35 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Experience\Index.cshtml"
WriteAttributeValue("", 1711, item.ExperienceID, 1711, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a></td>\r\n                            </tr>\r\n");
#nullable restore
#line 37 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Experience\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n                <a href=\"/Experience/AddExperience/\" class=\"btn btn-primary\">Deneyim ekle</a>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Experience>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
