#pragma checksum "C:\Development\PersonalWebsite\PersonalWebsite\Views\Layout\LandingPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91e94ecb2af3bd5ede2dbe794211629103e397ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Layout_LandingPage), @"mvc.1.0.view", @"/Views/Layout/LandingPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Layout/LandingPage.cshtml", typeof(AspNetCore.Views_Layout_LandingPage))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Development\PersonalWebsite\PersonalWebsite\Views\_ViewImports.cshtml"
using PersonalWebsite;

#line default
#line hidden
#line 2 "C:\Development\PersonalWebsite\PersonalWebsite\Views\_ViewImports.cshtml"
using PersonalWebsite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91e94ecb2af3bd5ede2dbe794211629103e397ff", @"/Views/Layout/LandingPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b123d4d975aac4c10118dbadc73c678745c102ed", @"/Views/_ViewImports.cshtml")]
    public class Views_Layout_LandingPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Development\PersonalWebsite\PersonalWebsite\Views\Layout\LandingPage.cshtml"
  
    ViewData["Title"] = "LandingPage";
    Layout = "_BootstrapLayout";

#line default
#line hidden
            BeginContext(83, 547, true);
            WriteLiteral(@"
<div class=""col-sm-12"" style=""background:#808080; border: 15px solid white; text-align: center;"">
    <h2>Landing Page</h2>
</div>

<div class=""col-sm-12"" style=""background:#808080; border: 15px solid white; text-align: center;"">
    <h2>Main Title</h2>
</div>

<div>
    <div class=""col-md-6"" style=""background: #808080; border: 15px solid white;"">
        <p>This is content 1</p>
    </div>
    <div class=""col-md-6"" style=""background: #808080; border: 15px solid white;"">
        <p>This is content 2</p>
    </div>
</div>

");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
