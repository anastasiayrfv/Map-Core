#pragma checksum "C:\Users\nastya\source\repos\Map - копия\Map\Views\Admin\_GetPlaces.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e27a637722c4e93ed50ca72bb4bf252f9505e10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin__GetPlaces), @"mvc.1.0.view", @"/Views/Admin/_GetPlaces.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/_GetPlaces.cshtml", typeof(AspNetCore.Views_Admin__GetPlaces))]
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
#line 1 "C:\Users\nastya\source\repos\Map - копия\Map\Views\_ViewImports.cshtml"
using Map;

#line default
#line hidden
#line 2 "C:\Users\nastya\source\repos\Map - копия\Map\Views\_ViewImports.cshtml"
using Map.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e27a637722c4e93ed50ca72bb4bf252f9505e10", @"/Views/Admin/_GetPlaces.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3191a14d3a44953a88a2e8df7a8abe3511324e75", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin__GetPlaces : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Place>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeletePlace", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 390, true);
            WriteLiteral(@"
<table class=""table_price"">
    <caption>Места</caption>
    <thead>
        <tr>
            <td> Id </td>
            <td>Название </td>
            <td>Тип </td>
            <td>Страна </td>
            <td>Город </td>
            <td>Улица </td>
            <td>Состояние</td>
            <td>Сайт </td>
            <td>Id Пользователя </td>
        </tr>
    </thead>
");
            EndContext();
#line 18 "C:\Users\nastya\source\repos\Map - копия\Map\Views\Admin\_GetPlaces.cshtml"
     foreach (Place p in Model)
    {

#line default
#line hidden
            BeginContext(457, 22, true);
            WriteLiteral("    <tr>\r\n        <td>");
            EndContext();
            BeginContext(480, 4, false);
#line 21 "C:\Users\nastya\source\repos\Map - копия\Map\Views\Admin\_GetPlaces.cshtml"
       Write(p.Id);

#line default
#line hidden
            EndContext();
            BeginContext(484, 20, true);
            WriteLiteral(" </td>\r\n        <td>");
            EndContext();
            BeginContext(505, 6, false);
#line 22 "C:\Users\nastya\source\repos\Map - копия\Map\Views\Admin\_GetPlaces.cshtml"
       Write(p.Name);

#line default
#line hidden
            EndContext();
            BeginContext(511, 20, true);
            WriteLiteral(" </td>\r\n        <td>");
            EndContext();
            BeginContext(532, 6, false);
#line 23 "C:\Users\nastya\source\repos\Map - копия\Map\Views\Admin\_GetPlaces.cshtml"
       Write(p.Type);

#line default
#line hidden
            EndContext();
            BeginContext(538, 20, true);
            WriteLiteral(" </td>\r\n        <td>");
            EndContext();
            BeginContext(559, 9, false);
#line 24 "C:\Users\nastya\source\repos\Map - копия\Map\Views\Admin\_GetPlaces.cshtml"
       Write(p.Country);

#line default
#line hidden
            EndContext();
            BeginContext(568, 20, true);
            WriteLiteral(" </td>\r\n        <td>");
            EndContext();
            BeginContext(589, 6, false);
#line 25 "C:\Users\nastya\source\repos\Map - копия\Map\Views\Admin\_GetPlaces.cshtml"
       Write(p.City);

#line default
#line hidden
            EndContext();
            BeginContext(595, 20, true);
            WriteLiteral(" </td>\r\n        <td>");
            EndContext();
            BeginContext(616, 8, false);
#line 26 "C:\Users\nastya\source\repos\Map - копия\Map\Views\Admin\_GetPlaces.cshtml"
       Write(p.Street);

#line default
#line hidden
            EndContext();
            BeginContext(624, 20, true);
            WriteLiteral(" </td>\r\n        <td>");
            EndContext();
            BeginContext(645, 7, false);
#line 27 "C:\Users\nastya\source\repos\Map - копия\Map\Views\Admin\_GetPlaces.cshtml"
       Write(p.State);

#line default
#line hidden
            EndContext();
            BeginContext(652, 20, true);
            WriteLiteral(" </td>\r\n        <td>");
            EndContext();
            BeginContext(673, 6, false);
#line 28 "C:\Users\nastya\source\repos\Map - копия\Map\Views\Admin\_GetPlaces.cshtml"
       Write(p.Site);

#line default
#line hidden
            EndContext();
            BeginContext(679, 20, true);
            WriteLiteral(" </td>\r\n        <td>");
            EndContext();
            BeginContext(700, 8, false);
#line 29 "C:\Users\nastya\source\repos\Map - копия\Map\Views\Admin\_GetPlaces.cshtml"
       Write(p.UserId);

#line default
#line hidden
            EndContext();
            BeginContext(708, 34, true);
            WriteLiteral(" </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(743, 167, false);
#line 31 "C:\Users\nastya\source\repos\Map - копия\Map\Views\Admin\_GetPlaces.cshtml"
       Write(Html.ActionLink("Редактировать", "EditPlace", "Admin", new { Id = p.Id },
                new { @class = "viewDialog", data_dialog_title = "Редактирование модели"  }));

#line default
#line hidden
            EndContext();
            BeginContext(910, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(953, 257, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b96fef5411ec4ca6a783a6aacb78606e", async() => {
                BeginContext(998, 48, true);
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1046, "\"", 1059, 1);
#line 36 "C:\Users\nastya\source\repos\Map - копия\Map\Views\Admin\_GetPlaces.cshtml"
WriteAttributeValue("", 1054, p.Id, 1054, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1060, 143, true);
                WriteLiteral(" />\r\n                <button type=\"submit\" class=\"btn btn-danger btn-sm\">\r\n                    Удалить\r\n                </button>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1210, 28, true);
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");
            EndContext();
#line 43 "C:\Users\nastya\source\repos\Map - копия\Map\Views\Admin\_GetPlaces.cshtml"
    }

#line default
#line hidden
            BeginContext(1245, 41, true);
            WriteLiteral("</table>\r\n<div class=\"text-center\">\r\n    ");
            EndContext();
            BeginContext(1286, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b89d32ab15e548759fab345527f74695", async() => {
                BeginContext(1333, 8, true);
                WriteLiteral("Добавить");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
            EndContext();
            BeginContext(1345, 441, true);
            WriteLiteral(@"
</div>

<script>
    $(document).ready(function () {
        $.ajaxSetup({ cache: false });
        $("".viewDialog"").on(""click"", function (e) {
            e.preventDefault();

            $(""<div></div>"")
                .addClass(""dialog"")
                .appendTo(""body"")
                .dialog({
                    modal: true
                })
                .load(this.href);
        });

    });
</script>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Place>> Html { get; private set; }
    }
}
#pragma warning restore 1591
