#pragma checksum "F:\label-print\label-print\Views\Shared\_PLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdf7094aef706ec29c90f6717815d32bf72f72c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PLayout), @"mvc.1.0.view", @"/Views/Shared/_PLayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_PLayout.cshtml", typeof(AspNetCore.Views_Shared__PLayout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdf7094aef706ec29c90f6717815d32bf72f72c8", @"/Views/Shared/_PLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aad082b20d1047a1a4ffaad41429620252191b99", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-layout-body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 2213, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdf7094aef706ec29c90f6717815d32bf72f72c83553", async() => {
                BeginContext(31, 132, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, maximum-scale=1\">\r\n    <title>");
                EndContext();
                BeginContext(164, 17, false);
#line 6 "F:\label-print\label-print\Views\Shared\_PLayout.cshtml"
      Write(ViewData["title"]);

#line default
#line hidden
                EndContext();
                BeginContext(181, 371, true);
                WriteLiteral(@"</title>
    <link rel=""stylesheet"" href=""/layui/css/layui.css"">
    <script src=""/jquery.min.js""></script>
    <script src=""/jquery.haschange.js""></script>
    <script src=""/jquery.cookie.js""></script>
    <script src=""/layui/layui.all.js""></script>
    <script src=""/layui/formSelects.js""></script>
    <script src=""/layui/autocomplete.js""></script>
    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 552, "\"", 606, 2);
                WriteAttributeValue("", 558, "/_js/framework_layui.js?time=", 558, 29, true);
#line 14 "F:\label-print\label-print\Views\Shared\_PLayout.cshtml"
WriteAttributeValue("", 587, DateTime.Now.Ticks, 587, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(607, 158, true);
                WriteLiteral("></script>\r\n    <script src=\"/_js/echarts.common.min.js\"></script>\r\n    <script>\r\n        var DONOTUSE_IGNOREHASH = false;\r\n        var DONOTUSE_COOKIEPRE = \'");
                EndContext();
                BeginContext(766, 30, false);
#line 18 "F:\label-print\label-print\Views\Shared\_PLayout.cshtml"
                             Write(ViewData["DONOTUSE_COOKIEPRE"]);

#line default
#line hidden
                EndContext();
                BeginContext(796, 39, true);
                WriteLiteral("\';\r\n        var DONOTUSE_WINDOWGUID = \'");
                EndContext();
                BeginContext(836, 42, false);
#line 19 "F:\label-print\label-print\Views\Shared\_PLayout.cshtml"
                              Write(Guid.NewGuid().ToString().Replace("-", ""));

#line default
#line hidden
                EndContext();
                BeginContext(878, 1353, true);
                WriteLiteral(@"';
        $(function () {
            $(window).hashchange(function () {
                if (DONOTUSE_IGNOREHASH == true) {
                    DONOTUSE_IGNOREHASH = false;
                    return;
                }
                var hash = window.location.hash;
                if (hash == null || hash == '') {
                    hash = '/Label/Index';
                }
                hash = hash.replace('#', '');
                ff.CloseAllDialog();
                ff.LoadPage(encodeURIComponent(hash));
            });
            $(window).hashchange();
        });
    </script>
    <style>
        .donotuse_pdiv {
            height: 100%;
            display: -webkit-box;
            display: -webkit-flex;
            display: -moz-box;
            display: -ms-flexbox;
            display: flex;
            -webkit-box-orient: vertical;
            -webkit-box-direction: normal;
            -webkit-flex-direction: column;
            -moz-box-orient: vertical;
      ");
                WriteLiteral(@"      -moz-box-direction: normal;
            -ms-flex-direction: column;
            flex-direction: column;
        }

        .donotuse_fill {
            -webkit-box-flex: 1;
            -webkit-flex: auto;
            -moz-box-flex: 1;
            -ms-flex: auto;
            flex: auto;
        }
    </style>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2238, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2240, 120, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdf7094aef706ec29c90f6717815d32bf72f72c88407", async() => {
                BeginContext(2272, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2279, 12, false);
#line 64 "F:\label-print\label-print\Views\Shared\_PLayout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(2291, 62, true);
                WriteLiteral("\r\n    <script>\r\n        layui.element.init();\r\n    </script>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2360, 7, true);
            WriteLiteral("</html>");
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
