#pragma checksum "C:\Users\nonas\OneDrive\Рабочий стол\SolbegSoft\HotDesc\HotDesc\Views\Admin\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "096a58dbcf070c5706aaad646f9cc369b5367a76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Edit), @"mvc.1.0.view", @"/Views/Admin/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"096a58dbcf070c5706aaad646f9cc369b5367a76", @"/Views/Admin/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3947d639d5b21d773121d821f51f166ec0808c06", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HotDesc.Models.Workplace>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\nonas\OneDrive\Рабочий стол\SolbegSoft\HotDesc\HotDesc\Views\Admin\Edit.cshtml"
  
    ViewData["Title"] = "Editing";
    Layout = "_LayoutForAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral("<link rel=\"stylesheet\" type=\"text/css\" href=\"/css/BGindex.css\" />\r\n<table class=\"table\">\r\n    <tr><td>Id</td><td>Id заказа</td><td>Описание</td><td>Предметы</td><td>Используется ли</td></tr>\r\n");
#nullable restore
#line 9 "C:\Users\nonas\OneDrive\Рабочий стол\SolbegSoft\HotDesc\HotDesc\Views\Admin\Edit.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr><td>");
#nullable restore
#line 11 "C:\Users\nonas\OneDrive\Рабочий стол\SolbegSoft\HotDesc\HotDesc\Views\Admin\Edit.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td>");
#nullable restore
#line 11 "C:\Users\nonas\OneDrive\Рабочий стол\SolbegSoft\HotDesc\HotDesc\Views\Admin\Edit.cshtml"
                            Write(item.ReservationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td>");
#nullable restore
#line 11 "C:\Users\nonas\OneDrive\Рабочий стол\SolbegSoft\HotDesc\HotDesc\Views\Admin\Edit.cshtml"
                                                        Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td>");
#nullable restore
#line 11 "C:\Users\nonas\OneDrive\Рабочий стол\SolbegSoft\HotDesc\HotDesc\Views\Admin\Edit.cshtml"
                                                                                  Write(item.Devices);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td>");
#nullable restore
#line 11 "C:\Users\nonas\OneDrive\Рабочий стол\SolbegSoft\HotDesc\HotDesc\Views\Admin\Edit.cshtml"
                                                                                                        Write(item.IsInUse);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n");
#nullable restore
#line 12 "C:\Users\nonas\OneDrive\Рабочий стол\SolbegSoft\HotDesc\HotDesc\Views\Admin\Edit.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "096a58dbcf070c5706aaad646f9cc369b5367a766663", async() => {
                WriteLiteral("\r\n    <div class=\"lbl\">\r\n        <strong style=\"color:#fff\" for=\"id\"> Номер стола:</strong>\r\n        <select name=\"id\">\r\n");
#nullable restore
#line 19 "C:\Users\nonas\OneDrive\Рабочий стол\SolbegSoft\HotDesc\HotDesc\Views\Admin\Edit.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "096a58dbcf070c5706aaad646f9cc369b5367a767331", async() => {
#nullable restore
#line 21 "C:\Users\nonas\OneDrive\Рабочий стол\SolbegSoft\HotDesc\HotDesc\Views\Admin\Edit.cshtml"
                                    Write(item.Id);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "C:\Users\nonas\OneDrive\Рабочий стол\SolbegSoft\HotDesc\HotDesc\Views\Admin\Edit.cshtml"
                   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\nonas\OneDrive\Рабочий стол\SolbegSoft\HotDesc\HotDesc\Views\Admin\Edit.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>\r\n\r\n        <input type=\"text\" name=\"description\" placeholder=\"Description\" />\r\n    </div>\r\n\r\n    <div class=\"lp\">\r\n\r\n        <div>\r\n            ");
#nullable restore
#line 31 "C:\Users\nonas\OneDrive\Рабочий стол\SolbegSoft\HotDesc\HotDesc\Views\Admin\Edit.cshtml"
       Write(Html.CheckBox("mouse", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <label for=\"mouse\">Mouse</label>\r\n        </div>\r\n\r\n        <div>\r\n            ");
#nullable restore
#line 36 "C:\Users\nonas\OneDrive\Рабочий стол\SolbegSoft\HotDesc\HotDesc\Views\Admin\Edit.cshtml"
       Write(Html.CheckBox("keyboard", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <label for=\"keyboard\">Keyboard</label>\r\n        </div>\r\n\r\n        <div>\r\n            ");
#nullable restore
#line 41 "C:\Users\nonas\OneDrive\Рабочий стол\SolbegSoft\HotDesc\HotDesc\Views\Admin\Edit.cshtml"
       Write(Html.CheckBox("systemUnit", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <label for=\"systemUnit\">System unit</label>\r\n        </div>\r\n\r\n        <div>\r\n            ");
#nullable restore
#line 46 "C:\Users\nonas\OneDrive\Рабочий стол\SolbegSoft\HotDesc\HotDesc\Views\Admin\Edit.cshtml"
       Write(Html.CheckBox("monitor", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <label for=\"monitor\">Monitor</label>\r\n        </div>\r\n\r\n        <div>\r\n            ");
#nullable restore
#line 51 "C:\Users\nonas\OneDrive\Рабочий стол\SolbegSoft\HotDesc\HotDesc\Views\Admin\Edit.cshtml"
       Write(Html.CheckBox("notebook", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <label for=\"notebook\">Notebook</label>\r\n        </div>\r\n    </div>\r\n\r\n    <div>\r\n        <input type=\"submit\" value=\"Send\" />\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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