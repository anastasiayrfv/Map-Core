#pragma checksum "C:\Users\nastya\source\repos\Map - копия\Map\Views\Shared\_Map.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64cd017e2c4f521928211b9a0e9557f7c9368b44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Map), @"mvc.1.0.view", @"/Views/Shared/_Map.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Map.cshtml", typeof(AspNetCore.Views_Shared__Map))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64cd017e2c4f521928211b9a0e9557f7c9368b44", @"/Views/Shared/_Map.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3191a14d3a44953a88a2e8df7a8abe3511324e75", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Map : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 520, true);
            WriteLiteral(@"<script>
      var script = '<script src=""infobubble';
      if (document.location.search.indexOf('compiled') !== -1) {
        script += '-compiled';
      }
      script += '.js""><' + '/script>';
      document.write(script);
    </script>  
 <script src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyBYDJvBdTt6k49Fdsl2YXrP5QDcbyl9NRM&libraries=places,visualization""  defer></script>
 <script src=""markerclusterer.js""defer >
    </script> 
  <script
   src= ""javascript.js""defer >
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
