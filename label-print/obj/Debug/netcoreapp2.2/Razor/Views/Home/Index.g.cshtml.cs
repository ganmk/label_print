#pragma checksum "F:\label-print\label-print\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a2085c450402ac6fc1c7a3a832525cffbae461f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a2085c450402ac6fc1c7a3a832525cffbae461f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aad082b20d1047a1a4ffaad41429620252191b99", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<label_print.ViewModel.HomeVMs.IndexVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\label-print\label-print\Views\Home\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(78, 89, true);
            WriteLiteral("\r\n<div class=\"layui-layout layui-layout-admin\">\r\n    <div class=\"layui-header\">\r\n        ");
            EndContext();
            BeginContext(168, 40, false);
#line 8 "F:\label-print\label-print\Views\Home\Index.cshtml"
   Write(await Html.PartialAsync("Header", Model));

#line default
#line hidden
            EndContext();
            BeginContext(208, 69, true);
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"layui-side layui-bg-black\">\r\n        ");
            EndContext();
            BeginContext(278, 38, false);
#line 12 "F:\label-print\label-print\Views\Home\Index.cshtml"
   Write(await Html.PartialAsync("Menu", Model));

#line default
#line hidden
            EndContext();
            BeginContext(316, 175, true);
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"layui-body\" id=\"DONOTUSE_MAINPANEL\">\r\n        <!-- 内容主体区域 -->\r\n    </div>\r\n\r\n    <div class=\"layui-footer\">\r\n        JCEX\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<label_print.ViewModel.HomeVMs.IndexVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
