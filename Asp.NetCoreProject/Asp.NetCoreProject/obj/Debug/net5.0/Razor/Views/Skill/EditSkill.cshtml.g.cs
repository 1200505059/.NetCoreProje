#pragma checksum "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Skill\EditSkill.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3524304666c9fb234403bc626dfcd93455b4331d8a38373d5b2cfe3394ab3376"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Skill_EditSkill), @"mvc.1.0.view", @"/Views/Skill/EditSkill.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"3524304666c9fb234403bc626dfcd93455b4331d8a38373d5b2cfe3394ab3376", @"/Views/Skill/EditSkill.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"48d7d692876c63d8c26f396bf085d9fb803cacb7c1d6009c9fc8f478be37f7a8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Skill_EditSkill : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrate.Skill>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Skill\EditSkill.cshtml"
  
    ViewData["Title"] = "EditSkill";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1 style=\"color:white;\">Yetenek Düzenleme Paneli</h1>\r\n");
#nullable restore
#line 7 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Skill\EditSkill.cshtml"
 using (Html.BeginForm("EditSkill", "Skill", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Skill\EditSkill.cshtml"
Write(Html.HiddenFor(x=>x.SkillID));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <br />\r\n    <br />\r\n");
#nullable restore
#line 13 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Skill\EditSkill.cshtml"
   Write(Html.Label("Yetenek Başlığı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Skill\EditSkill.cshtml"
   Write(Html.TextBoxFor(x=>x.Title ,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <label>Değer</label>\r\n");
#nullable restore
#line 17 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Skill\EditSkill.cshtml"
   Write(Html.TextBoxFor(x=>x.Value,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <button class=\"btn btn-primary\">Kaydet</button>\r\n    <br />\r\n");
#nullable restore
#line 21 "C:\Users\pc\Desktop\Asp.NetCoreProject\Asp.NetCoreProject\Views\Skill\EditSkill.cshtml"

} 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrate.Skill> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591