#pragma checksum "C:\Users\sarocha.s\Desktop\Document file\ITT-22-0162_8D\8DSystem\Views\SetPcaStatus\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e08f27484d1feb982c954b666fdbc8e510236e62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SetPcaStatus_Index), @"mvc.1.0.view", @"/Views/SetPcaStatus/Index.cshtml")]
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
#line 1 "C:\Users\sarocha.s\Desktop\Document file\ITT-22-0162_8D\8DSystem\Views\_ViewImports.cshtml"
using _8DSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sarocha.s\Desktop\Document file\ITT-22-0162_8D\8DSystem\Views\_ViewImports.cshtml"
using _8DSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sarocha.s\Desktop\Document file\ITT-22-0162_8D\8DSystem\Views\_ViewImports.cshtml"
using _8DSystem.Models.Views;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e08f27484d1feb982c954b666fdbc8e510236e62", @"/Views/SetPcaStatus/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8a17ad580bc117807f39af7947bd490c0ad35b5", @"/Views/_ViewImports.cshtml")]
    public class Views_SetPcaStatus_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<_8DSystem.Models.RefPCAStatus>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration: none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btnEdit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btnEdit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sarocha.s\Desktop\Document file\ITT-22-0162_8D\8DSystem\Views\SetPcaStatus\Index.cshtml"
  
    Layout = "~/Views/Shared/_LayoutSetting3.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>PCA/PA Status</h1>\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        <div class=\"card\">\r\n            <div class=\"card-header\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e08f27484d1feb982c954b666fdbc8e510236e625430", async() => {
                WriteLiteral(" <i class=\"fas fa-plus\"></i> [Create New]");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""card-body"">
                <table class=""table table-sm table-striped table-valign-middle table-bordered"">
                    <thead>
                        <tr>

                            <th>Description</th>
                            <th>Active</th>
                            <th>Edit</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 24 "C:\Users\sarocha.s\Desktop\Document file\ITT-22-0162_8D\8DSystem\Views\SetPcaStatus\Index.cshtml"
                         foreach (var m in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n\r\n                                <td>");
#nullable restore
#line 28 "C:\Users\sarocha.s\Desktop\Document file\ITT-22-0162_8D\8DSystem\Views\SetPcaStatus\Index.cshtml"
                               Write(m.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-center\">\r\n                                    <div class=\"icheck-success d-inline\">\r\n                                        <input type=\"checkbox\" id=\"Active\" name=\"Active\" ");
#nullable restore
#line 31 "C:\Users\sarocha.s\Desktop\Document file\ITT-22-0162_8D\8DSystem\Views\SetPcaStatus\Index.cshtml"
                                                                                     Write(m.Active == true ? "checked" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(@" disabled>

                                    </div>

                                    <div class=""form-group"">
                                        <div class=""icheck-success d-inline"">
                                            <input type=""checkbox"" ");
#nullable restore
#line 37 "C:\Users\sarocha.s\Desktop\Document file\ITT-22-0162_8D\8DSystem\Views\SetPcaStatus\Index.cshtml"
                                                               Write(m.Active == true ? "checked" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(@" disabled />
                                            <label for=""Active"" class=""font-weight-normal"">
                                                Active
                                            </label>
                                        </div>
                                    </div>
                                </td>
                                <td class=""text-center"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e08f27484d1feb982c954b666fdbc8e510236e629391", async() => {
                WriteLiteral("<i class=\"fa fa-edit \"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "C:\Users\sarocha.s\Desktop\Document file\ITT-22-0162_8D\8DSystem\Views\SetPcaStatus\Index.cshtml"
                                                           WriteLiteral(m.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "C:\Users\sarocha.s\Desktop\Document file\ITT-22-0162_8D\8DSystem\Views\SetPcaStatus\Index.cshtml"
                                                                                                               Write(m.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-id", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 48 "C:\Users\sarocha.s\Desktop\Document file\ITT-22-0162_8D\8DSystem\Views\SetPcaStatus\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n        \r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<_8DSystem.Models.RefPCAStatus>> Html { get; private set; }
    }
}
#pragma warning restore 1591
