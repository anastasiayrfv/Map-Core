#pragma checksum "C:\Users\nastya\source\repos\Map - копия\Map\Views\Home\UserAnonymous.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d49a70fb9c95a860ffb625e2a04088a228723eb5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserAnonymous), @"mvc.1.0.view", @"/Views/Home/UserAnonymous.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/UserAnonymous.cshtml", typeof(AspNetCore.Views_Home_UserAnonymous))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d49a70fb9c95a860ffb625e2a04088a228723eb5", @"/Views/Home/UserAnonymous.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3191a14d3a44953a88a2e8df7a8abe3511324e75", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserAnonymous : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/infobubble.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/infobubble-compiled.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/markerclusterer.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\nastya\source\repos\Map - копия\Map\Views\Home\UserAnonymous.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(34, 152, true);
            WriteLiteral("\r\n\r\n\r\n<script src=\"https://maps.googleapis.com/maps/api/js?key=AIzaSyBYDJvBdTt6k49Fdsl2YXrP5QDcbyl9NRM&libraries=places,visualization\" defer></script>\r\n");
            EndContext();
            BeginContext(186, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1ae7d6c42b846868f40add810fbaed9", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("defer", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(234, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(236, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57947247d5f44c47a14c81ec36a58716", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("defer", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(293, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(295, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f0059929592497d96848e8417da8337", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("defer", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(348, 63, true);
            WriteLiteral("\r\n\r\n<div id=\"map\" style=\"height: 600px; width:100%;\"></div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(429, 201, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        var markers = new Array(5);\r\n        var infowindow;\r\n        var map;\r\n        var infoWindow;\r\n        var service;\r\n        var pos;\r\n\r\n        fetch(\'");
                EndContext();
                BeginContext(631, 29, false);
#line 24 "C:\Users\nastya\source\repos\Map - копия\Map\Views\Home\UserAnonymous.cshtml"
          Write(Url.Action("GetData", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(660, 8274, true);
                WriteLiteral(@"')
            .then(function (response)
            {
                if (response.status !== 200)
                {
                    console.log(
                        'Looks like there was a problem. Status Code: ' + response.status
                    );
                    return;
                }
                response.json().then(function (data)
                {
                    markers = data;
                    console.log(markers);
                    initMap();

                });
            })
            .catch(function (err) {
                console.log('Fetch Error :-S', err);
            });

        function initMap()
        {

          var pyrmont = { lat: 50.45136068, lng: 30.48783713 };

            map = new google.maps.Map(document.getElementById('map'), {
            center: pyrmont,
            zoom: 4,
            mapTypeId: 'roadmap',
            styles: [
            {
                ""featureType"": ""all"",
                ""elementT");
                WriteLiteral(@"ype"": ""all"",
                ""stylers"": [
                    {
                        ""hue"": ""#008eff""
                    }
                ]
            },
            {
                ""featureType"": ""poi"",
                ""elementType"": ""all"",
                ""stylers"": [
                    {
                        ""visibility"": ""off""
                    }
                ]
            },
            {
                ""featureType"": ""road"",
                ""elementType"": ""all"",
                ""stylers"": [
                    {
                        ""saturation"": ""0""
                    },
                    {
                        ""lightness"": ""0""
                    }
                ]
            },
            {
                ""featureType"": ""transit"",
                ""elementType"": ""all"",
                ""stylers"": [
                    {
                        ""visibility"": ""off""
                    }
                ]
            },
            {
   ");
                WriteLiteral(@"             ""featureType"": ""water"",
                ""elementType"": ""all"",
                ""stylers"": [
                    {
                        ""visibility"": ""simplified""
                    },
                    {
                        ""saturation"": ""-60""
                    },
                    {
                        ""lightness"": ""-20""
                    }
                ]
            }
        ]
          });


          var iconBase = 'https://maps.google.com/mapfiles/kml/shapes/';

            var icons =
            {
                1:
                {
                    icon: 'https://goodzone.international/map/mmm2.png', //orange
                },

                2:
                {
                    icon: 'https://goodzone.international/map/mmm3.png', //red
                },

                3:
                {
                    icon: 'https://goodzone.international/images/m1.png', //pink
                },

                0:
        ");
                WriteLiteral(@"        {
                    icon: 'https://goodzone.international/map/mmm1.png', // white
                },
            };


            infowindow = new google.maps.InfoWindow();
          service = new google.maps.places.PlacesService(map);

            for (let i = 0; i < markers.length; i++)
                markers[i].position = new google.maps.LatLng(markers[i].lat, markers[i].lng);

          let arr = new Array(5);
          let i = 0;

          // Create markers.
          markers.forEach(function(mark) {
             var marker = new google.maps.Marker({
                  position: mark.position,
                  icon: icons[3].icon,
                  map: map,
                  name:mark.name,
                  place_id: mark.place_id,
                  address: mark.address,
                  rating: mark.rating,
                  site: mark.site,
                  state: mark.state,
                  type: mark.type,
                  city: mark.city,
            ");
                WriteLiteral(@"      street: mark.street
            });
            arr[i++] = marker;

              marker.addListener('click', function ()
              {
                 marker.setIcon(icons[mark.state].icon);

                 if (marker.state != 2 || marker.site == """")
                     var site = """";
                 else
                     var site = '<br>Site:  <a href=""' + marker.site + '"" > ' + marker.site + '  </a>';

                 if (marker.state == 0)
                 {
                     var s = ""НОВОЕ МЕСТО"" 
                     var inf0 = new InfoBubble(
                         {
                             maxWidth: 300,
                             content: '<div class=""c0""> <a href=' + marker.site + ' target=""_blank""> <div class=""cont_1"">' + marker.type.toUpperCase() + "" -- "" + marker.name.toUpperCase() + ' <br><strong> ' + marker.street + ""  "" + marker.city + '</strong> <br><strong> ' + s + '</strong></div></a></div> ',
                             backgroundColor: 'r");
                WriteLiteral(@"gb(250, 250, 250)',
                         });

                     inf0.close();
     	             inf0.open(map, marker);
                 }
                 else if (marker.state==1 )
                 {
                    var s =""ПРОВЕРЕНО "" 
                    var inf1 = new InfoBubble(
                        {
                          maxWidth: 300,
                          content: '<div class=""c1""> <a href='+marker.site +' target=""_blank""> <div class=""cont_1"">'+marker.type.toUpperCase()+"" -- ""+ marker.name.toUpperCase()  +' <br><strong> '+marker.street+""  "" + marker.city+'</strong> <br><strong> '+s+'</strong></div></a></div> ' ,
                          backgroundColor: 'rgb(249, 117, 0)'
                         });

        		    inf1.open(map, marker);
                 }
                 else if (marker.state==2)
                 {
                    var s=""КЛЕВОЕ МЕСТО ""
                    var inf2 = new InfoBubble(
                        {
                      ");
                WriteLiteral(@"    maxWidth: 300,
                          content: '<div class=""c2""> <a href='+marker.site +' target=""_blank""> <div class=""cont_1"">'+marker.type.toUpperCase()+"" -- ""+ marker.name.toUpperCase()  +' <br><strong> '+marker.street+""  "" + marker.city+'</strong> <br><strong> '+s+'</strong></div></a></div> ' ,
                          backgroundColor: 'rgb(141,0, 0)'
                         });

        		    inf2.open(map, marker);
                  }
              });
          });

          // Add a marker clusterer.
            var markerCluster = new MarkerClusterer(map, arr, { imagePath: 'https://goodzone.international/images/m' });

            // Geolocation.
            if (navigator.geolocation)
            {
                navigator.geolocation.getCurrentPosition(
                    function (position) {
                        pos = {
                            lat: position.coords.latitude,
                            lng: position.coords.longitude,
                        }");
                WriteLiteral(@";

                        var myMarker = new google.maps.Marker({
                            position: pos,
                            map: map,
                            draggable: true,
                            animation: google.maps.Animation.BOUNCE,
                        });


                        map.setCenter(pos);
                    },
                    function () {
                        handleLocationError(true, infowindow, map.getCenter());
                    });
            }
            else  // Browser doesn't support Geolocation
            {
                handleLocationError(false, infowindow, map.getCenter());
            }

        } //initMap end

        function handleLocationError(browserHasGeolocation, infowindow, pos)
        {
            infowindow.setPosition(pos);
            infowindow.setContent(
                browserHasGeolocation
                    ? 'Error: The Geolocation service failed.'
                    : ""Error: Your b");
                WriteLiteral("rowser doesn\'t support geolocation.\"\r\n            );\r\n        }\r\n\r\n    </script>\r\n");
                EndContext();
            }
            );
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
