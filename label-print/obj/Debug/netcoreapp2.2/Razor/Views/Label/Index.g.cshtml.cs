#pragma checksum "F:\label-print\label-print\Views\Label\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f88e5fa16aeb6f0250d659bc9143462525cfb829"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Label_Index), @"mvc.1.0.view", @"/Views/Label/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Label/Index.cshtml", typeof(AspNetCore.Views_Label_Index))]
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
#line 1 "F:\label-print\label-print\Views\_ViewImports.cshtml"
using WalkingTec.Mvvm.TagHelpers.LayUI;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f88e5fa16aeb6f0250d659bc9143462525cfb829", @"/Views/Label/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aad082b20d1047a1a4ffaad41429620252191b99", @"/Views/_ViewImports.cshtml")]
    public class Views_Label_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1007, true);
            WriteLiteral(@"<link rel=""stylesheet"" href=""./css/custom-label.css"">
<link rel=""stylesheet"" href=""./css/components.css"">
<script type=""text/javascript"" src=""./labeljs/jquery.custom-label.js""></script>
<script  type=""text/javascript""  src=""./labeljs/jquery.custom-label-components.js""></script>
<script  type=""text/javascript""  src=""./labeljs/data-components.js""></script>
<script  type=""text/javascript""  src=""./labeljs/init.js?v2.6""></script>

<style>
    html, body {
        padding: 0;
        margin: 0;
        height: 100%;
        background: #eee;
    }

    /*.left-menu {
        position: absolute;
        left: 20px;
        top: 20px;
        width: 150px;
    }*/

        /*.left-menu input {
            display: block;
            margin: 10px 0;
        }*/
</style>
<div class=""layui-container"">
    <div class=""layui-row"">
        <div class=""layui-col-md3"">
            <input type=""button"" class=""btn-add-new layui-btn"" value=""创建默认实例"" />
        </div>
           
");
            EndContext();
            BeginContext(1486, 120, true);
            WriteLiteral("        </div>\r\n        <div class=\"container\" style=\"height: 700px;width: 1200px; margin: 0px auto;\"></div>\r\n    </div>");
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
