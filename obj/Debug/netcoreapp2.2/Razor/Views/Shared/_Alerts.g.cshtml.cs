#pragma checksum "C:\Users\Pete pc\Desktop\kafer - Copy (2)\Views\Shared\_Alerts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1d14f2174e9c6dbcf2b5931a1733b825877214f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Alerts), @"mvc.1.0.view", @"/Views/Shared/_Alerts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Alerts.cshtml", typeof(AspNetCore.Views_Shared__Alerts))]
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
#line 1 "C:\Users\Pete pc\Desktop\kafer - Copy (2)\Views\_ViewImports.cshtml"
using kafer_house;

#line default
#line hidden
#line 2 "C:\Users\Pete pc\Desktop\kafer - Copy (2)\Views\_ViewImports.cshtml"
using kafer_house.Models;

#line default
#line hidden
#line 1 "C:\Users\Pete pc\Desktop\kafer - Copy (2)\Views\Shared\_Alerts.cshtml"
using kafer_house.Helper;

#line default
#line hidden
#line 2 "C:\Users\Pete pc\Desktop\kafer - Copy (2)\Views\Shared\_Alerts.cshtml"
using kafer_house.Extensions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1d14f2174e9c6dbcf2b5931a1733b825877214f", @"/Views/Shared/_Alerts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f597968a71fe0965886cf747df1e859bf957b674", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Alerts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Pete pc\Desktop\kafer - Copy (2)\Views\Shared\_Alerts.cshtml"
  
    var alerts = TempData.DeserializeAlerts(Alert.TempDataKey);

#line default
#line hidden
            BeginContext(132, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\Pete pc\Desktop\kafer - Copy (2)\Views\Shared\_Alerts.cshtml"
 foreach (var alert in alerts)
{
    var dismissableClass = alert.Dismissable ? "alert-dismissable" : null;

#line default
#line hidden
            BeginContext(245, 114, true);
            WriteLiteral("    <div data-notify=\"container\" data-icon=\"fa fa-exclamation\"\r\n    role=\"alert\" data-notify-position=\"top-center\"");
            EndContext();
            BeginWriteAttribute("class", "\r\n    class=\"", 359, "\"", 455, 8);
            WriteAttributeValue("", 372, "col-11", 372, 6, true);
            WriteAttributeValue(" ", 378, "col-sm-4", 379, 9, true);
            WriteAttributeValue(" ", 387, "alert", 388, 6, true);
            WriteAttributeValue(" ", 393, "alert-", 394, 7, true);
#line 13 "C:\Users\Pete pc\Desktop\kafer - Copy (2)\Views\Shared\_Alerts.cshtml"
WriteAttributeValue("", 400, alert.AlertStyle, 400, 17, false);

#line default
#line hidden
#line 13 "C:\Users\Pete pc\Desktop\kafer - Copy (2)\Views\Shared\_Alerts.cshtml"
WriteAttributeValue(" ", 417, dismissableClass, 418, 17, false);

#line default
#line hidden
            WriteAttributeValue(" ", 435, "animated", 436, 9, true);
            WriteAttributeValue(" ", 444, "fadeInDown", 445, 11, true);
            EndWriteAttribute();
            BeginContext(456, 86, true);
            WriteLiteral(" id=\"alert\">\r\n    <span data-notify=\"icon\" class=\"fa fa-check mr-1\"></span>\r\n       \r\n");
            EndContext();
#line 16 "C:\Users\Pete pc\Desktop\kafer - Copy (2)\Views\Shared\_Alerts.cshtml"
         if(alert.Dismissable)
        {

#line default
#line hidden
            BeginContext(585, 170, true);
            WriteLiteral("            <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n                <span aria-hidden=\"true\">&times;</span>\r\n            </button>\r\n");
            EndContext();
#line 21 "C:\Users\Pete pc\Desktop\kafer - Copy (2)\Views\Shared\_Alerts.cshtml"
        }

#line default
#line hidden
            BeginContext(766, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(775, 23, false);
#line 22 "C:\Users\Pete pc\Desktop\kafer - Copy (2)\Views\Shared\_Alerts.cshtml"
   Write(Html.Raw(alert.Message));

#line default
#line hidden
            EndContext();
            BeginContext(798, 24, true);
            WriteLiteral("\r\n        \r\n    </div>\r\n");
            EndContext();
#line 25 "C:\Users\Pete pc\Desktop\kafer - Copy (2)\Views\Shared\_Alerts.cshtml"
}

#line default
#line hidden
            BeginContext(825, 185, true);
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n   \r\n    window.setTimeout(function () {\r\n    $(\"#alert\").slideUp(500, function () {\r\n        $(this).remove();\r\n    });\r\n    }, 4000);\r\n\r\n</script>\r\n");
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
