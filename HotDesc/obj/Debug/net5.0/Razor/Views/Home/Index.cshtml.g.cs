#pragma checksum "C:\Users\nonas\OneDrive\Рабочий стол\SolbegSoft\HotDesc\HotDesc\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "364f2b6dc3d6523fd49034d512533abddd981e44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\nonas\OneDrive\Рабочий стол\SolbegSoft\HotDesc\HotDesc\Views\_ViewImports.cshtml"
using HotDesc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nonas\OneDrive\Рабочий стол\SolbegSoft\HotDesc\HotDesc\Views\_ViewImports.cshtml"
using HotDesc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"364f2b6dc3d6523fd49034d512533abddd981e44", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3947d639d5b21d773121d821f51f166ec0808c06", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HotDesc.Models.Workplace>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\nonas\OneDrive\Рабочий стол\SolbegSoft\HotDesc\HotDesc\Views\Home\Index.cshtml"
  
    Layout = "_LayoutForUser";
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<link rel=\"stylesheet\" type=\"text/css\" href=\"/css/BGindex.css\" />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "364f2b6dc3d6523fd49034d512533abddd981e443436", async() => {
                WriteLiteral("\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr><td></td><td>ReservationCode</td><td>Devices</td><td>Description</td><td>Busy?</td></tr>\r\n        </thead>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\nonas\OneDrive\Рабочий стол\SolbegSoft\HotDesc\HotDesc\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr><td>");
#nullable restore
#line 15 "C:\Users\nonas\OneDrive\Рабочий стол\SolbegSoft\HotDesc\HotDesc\Views\Home\Index.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td><td>");
#nullable restore
#line 15 "C:\Users\nonas\OneDrive\Рабочий стол\SolbegSoft\HotDesc\HotDesc\Views\Home\Index.cshtml"
                                Write(item.ReservationId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td><td>");
#nullable restore
#line 15 "C:\Users\nonas\OneDrive\Рабочий стол\SolbegSoft\HotDesc\HotDesc\Views\Home\Index.cshtml"
                                                            Write(item.Devices);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td><td>");
#nullable restore
#line 15 "C:\Users\nonas\OneDrive\Рабочий стол\SolbegSoft\HotDesc\HotDesc\Views\Home\Index.cshtml"
                                                                                  Write(item.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td><td>");
#nullable restore
#line 15 "C:\Users\nonas\OneDrive\Рабочий стол\SolbegSoft\HotDesc\HotDesc\Views\Home\Index.cshtml"
                                                                                                            Write(item.IsInUse);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td></tr>\r\n");
#nullable restore
#line 16 "C:\Users\nonas\OneDrive\Рабочий стол\SolbegSoft\HotDesc\HotDesc\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HotDesc.Models.Workplace>> Html { get; private set; }
    }
}
#pragma warning restore 1591