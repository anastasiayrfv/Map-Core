#pragma checksum "C:\Users\nastya\source\repos\Map - копия\Map\Views\Admin\_GetUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e5b932ad6f4cb699b84327eb7d5b7ddc5469250"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin__GetUsers), @"mvc.1.0.view", @"/Views/Admin/_GetUsers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/_GetUsers.cshtml", typeof(AspNetCore.Views_Admin__GetUsers))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e5b932ad6f4cb699b84327eb7d5b7ddc5469250", @"/Views/Admin/_GetUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3191a14d3a44953a88a2e8df7a8abe3511324e75", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin__GetUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 319, true);
            WriteLiteral(@"<caption>Пользователи</caption>
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
<tbody>
");
            EndContext();
#line 17 "C:\Users\nastya\source\repos\Map - копия\Map\Views\Admin\_GetUsers.cshtml"
     foreach (Map.Models.User p in Model)
    {

#line default
#line hidden
            BeginContext(395, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(426, 4, false);
#line 20 "C:\Users\nastya\source\repos\Map - копия\Map\Views\Admin\_GetUsers.cshtml"
           Write(p.Id);

#line default
#line hidden
            EndContext();
            BeginContext(430, 24, true);
            WriteLiteral(" </td>\r\n            <td>");
            EndContext();
            BeginContext(455, 6, false);
#line 21 "C:\Users\nastya\source\repos\Map - копия\Map\Views\Admin\_GetUsers.cshtml"
           Write(p.Name);

#line default
#line hidden
            EndContext();
            BeginContext(461, 24, true);
            WriteLiteral(" </td>\r\n            <td>");
            EndContext();
            BeginContext(486, 8, false);
#line 22 "C:\Users\nastya\source\repos\Map - копия\Map\Views\Admin\_GetUsers.cshtml"
           Write(p.CardId);

#line default
#line hidden
            EndContext();
            BeginContext(494, 24, true);
            WriteLiteral(" </td>\r\n            <td>");
            EndContext();
            BeginContext(519, 7, false);
#line 23 "C:\Users\nastya\source\repos\Map - копия\Map\Views\Admin\_GetUsers.cshtml"
           Write(p.Email);

#line default
#line hidden
            EndContext();
            BeginContext(526, 24, true);
            WriteLiteral(" </td>\r\n            <td>");
            EndContext();
            BeginContext(551, 7, false);
#line 24 "C:\Users\nastya\source\repos\Map - копия\Map\Views\Admin\_GetUsers.cshtml"
           Write(p.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(558, 24, true);
            WriteLiteral(" </td>\r\n            <td>");
            EndContext();
            BeginContext(583, 6, false);
#line 25 "C:\Users\nastya\source\repos\Map - копия\Map\Views\Admin\_GetUsers.cshtml"
           Write(p.Role);

#line default
#line hidden
            EndContext();
            BeginContext(589, 24, true);
            WriteLiteral(" </td>\r\n            <td>");
            EndContext();
            BeginContext(614, 9, false);
#line 26 "C:\Users\nastya\source\repos\Map - копия\Map\Views\Admin\_GetUsers.cshtml"
           Write(p.Address);

#line default
#line hidden
            EndContext();
            BeginContext(623, 103, true);
            WriteLiteral(" </td>\r\n            <td><a>Удалить</a></td>\r\n            <td><a>Редактировать</a></td>\r\n        </tr>\r\n");
            EndContext();
#line 30 "C:\Users\nastya\source\repos\Map - копия\Map\Views\Admin\_GetUsers.cshtml"
    }

#line default
#line hidden
            BeginContext(733, 8, true);
            WriteLiteral("</tbody>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591