#pragma checksum "C:\Module3\MVC\ToKhaiYTe\ToKhaiYTe\Views\ToKhaiYTe\XemDauHieu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e144a2e471c3cc1c136b1a0f76de9a4055f043a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ToKhaiYTe_XemDauHieu), @"mvc.1.0.view", @"/Views/ToKhaiYTe/XemDauHieu.cshtml")]
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
#line 1 "C:\Module3\MVC\ToKhaiYTe\ToKhaiYTe\Views\_ViewImports.cshtml"
using ToKhaiYTe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Module3\MVC\ToKhaiYTe\ToKhaiYTe\Views\_ViewImports.cshtml"
using ToKhaiYTe.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e144a2e471c3cc1c136b1a0f76de9a4055f043a", @"/Views/ToKhaiYTe/XemDauHieu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98f42eb642e43ce8c4834f3246937cfc952ca90a", @"/Views/_ViewImports.cshtml")]
    public class Views_ToKhaiYTe_XemDauHieu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DauHieu>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ToKhaiYTe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e144a2e471c3cc1c136b1a0f76de9a4055f043a4699", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>View</title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e144a2e471c3cc1c136b1a0f76de9a4055f043a5757", async() => {
                WriteLiteral(@"
    <table id=""example"" class=""table table-striped table-bordered"" style=""width:100%"">
        <thead class=""thead-dark"" style=""text-align:center"">
            <tr>
                <th>Sốt</th>
                <th>Ho</th>
                <th>Khó thở</th>
                <th>Đau họng</th>
                <th>Buồn nôn</th>
                <th>Tiêu chảy</th>
                <th>Xuất huyết ngoài da</th>
                <th>Nổi ban ngoài da</th>
            </tr>

        </thead>
        <tbody style=""text-align:center"">
            <tr>
");
#nullable restore
#line 30 "C:\Module3\MVC\ToKhaiYTe\ToKhaiYTe\Views\ToKhaiYTe\XemDauHieu.cshtml"
                 if (Model.Sot)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td>Có</td>\r\n");
#nullable restore
#line 33 "C:\Module3\MVC\ToKhaiYTe\ToKhaiYTe\Views\ToKhaiYTe\XemDauHieu.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td>Không</td>\r\n");
#nullable restore
#line 37 "C:\Module3\MVC\ToKhaiYTe\ToKhaiYTe\Views\ToKhaiYTe\XemDauHieu.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Module3\MVC\ToKhaiYTe\ToKhaiYTe\Views\ToKhaiYTe\XemDauHieu.cshtml"
                 if (Model.Ho)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td>Có</td>\r\n");
#nullable restore
#line 41 "C:\Module3\MVC\ToKhaiYTe\ToKhaiYTe\Views\ToKhaiYTe\XemDauHieu.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td>Không</td>\r\n");
#nullable restore
#line 45 "C:\Module3\MVC\ToKhaiYTe\ToKhaiYTe\Views\ToKhaiYTe\XemDauHieu.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Module3\MVC\ToKhaiYTe\ToKhaiYTe\Views\ToKhaiYTe\XemDauHieu.cshtml"
                 if (Model.KhoTho)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td>Có</td>\r\n");
#nullable restore
#line 49 "C:\Module3\MVC\ToKhaiYTe\ToKhaiYTe\Views\ToKhaiYTe\XemDauHieu.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td>Không</td>\r\n");
#nullable restore
#line 53 "C:\Module3\MVC\ToKhaiYTe\ToKhaiYTe\Views\ToKhaiYTe\XemDauHieu.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Module3\MVC\ToKhaiYTe\ToKhaiYTe\Views\ToKhaiYTe\XemDauHieu.cshtml"
                 if (Model.DauHong)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td>Có</td>\r\n");
#nullable restore
#line 57 "C:\Module3\MVC\ToKhaiYTe\ToKhaiYTe\Views\ToKhaiYTe\XemDauHieu.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td>Không</td>\r\n");
#nullable restore
#line 61 "C:\Module3\MVC\ToKhaiYTe\ToKhaiYTe\Views\ToKhaiYTe\XemDauHieu.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Module3\MVC\ToKhaiYTe\ToKhaiYTe\Views\ToKhaiYTe\XemDauHieu.cshtml"
                 if (Model.BuonNon)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td>Có</td>\r\n");
#nullable restore
#line 65 "C:\Module3\MVC\ToKhaiYTe\ToKhaiYTe\Views\ToKhaiYTe\XemDauHieu.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td>Không</td>\r\n");
#nullable restore
#line 69 "C:\Module3\MVC\ToKhaiYTe\ToKhaiYTe\Views\ToKhaiYTe\XemDauHieu.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Module3\MVC\ToKhaiYTe\ToKhaiYTe\Views\ToKhaiYTe\XemDauHieu.cshtml"
                 if (Model.TieuChay)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td>Có</td>\r\n");
#nullable restore
#line 73 "C:\Module3\MVC\ToKhaiYTe\ToKhaiYTe\Views\ToKhaiYTe\XemDauHieu.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td>Không</td>\r\n");
#nullable restore
#line 77 "C:\Module3\MVC\ToKhaiYTe\ToKhaiYTe\Views\ToKhaiYTe\XemDauHieu.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Module3\MVC\ToKhaiYTe\ToKhaiYTe\Views\ToKhaiYTe\XemDauHieu.cshtml"
                 if (Model.XuatHuyetNgoaiDa)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td>Có</td>\r\n");
#nullable restore
#line 81 "C:\Module3\MVC\ToKhaiYTe\ToKhaiYTe\Views\ToKhaiYTe\XemDauHieu.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td>Không</td>\r\n");
#nullable restore
#line 85 "C:\Module3\MVC\ToKhaiYTe\ToKhaiYTe\Views\ToKhaiYTe\XemDauHieu.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Module3\MVC\ToKhaiYTe\ToKhaiYTe\Views\ToKhaiYTe\XemDauHieu.cshtml"
                 if (Model.NoiBanNgoaiDa)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td>Có</td>\r\n");
#nullable restore
#line 89 "C:\Module3\MVC\ToKhaiYTe\ToKhaiYTe\Views\ToKhaiYTe\XemDauHieu.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td>Không</td>\r\n");
#nullable restore
#line 93 "C:\Module3\MVC\ToKhaiYTe\ToKhaiYTe\Views\ToKhaiYTe\XemDauHieu.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tr>\r\n\r\n        </tbody>\r\n    </table>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e144a2e471c3cc1c136b1a0f76de9a4055f043a12512", async() => {
                    WriteLiteral("Back");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    \r\n");
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
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ToKhaiYTeContext context { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DauHieu> Html { get; private set; }
    }
}
#pragma warning restore 1591
