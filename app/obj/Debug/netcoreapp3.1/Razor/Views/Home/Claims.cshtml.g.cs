#pragma checksum "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\Home\Claims.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd29b78fbbc4c73329027e5f2b74d7ca84814a15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Claims), @"mvc.1.0.view", @"/Views/Home/Claims.cshtml")]
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
#line 1 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\_ViewImports.cshtml"
using ImageHosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\_ViewImports.cshtml"
using ImageHosting.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\Home\Claims.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd29b78fbbc4c73329027e5f2b74d7ca84814a15", @"/Views/Home/Claims.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3333cc77701a4a12909ef3d83003f1927f90fcf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Claims : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\Home\Claims.cshtml"
  
	ViewData["Title"] = "Claims";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>");
#nullable restore
#line 6 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\Home\Claims.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</h2>\n\n<table class=\"table-hover table-condensed table-striped\">\n\t<tr>\n\t\t<th>Claim Type</th>\n\t\t<th>Claim Value</th>\n\t</tr>\n\n");
#nullable restore
#line 14 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\Home\Claims.cshtml"
     foreach (Claim claim in User.Claims)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<tr>\n\t\t\t<td>");
#nullable restore
#line 17 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\Home\Claims.cshtml"
           Write(claim.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\t\t\t<td>");
#nullable restore
#line 18 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\Home\Claims.cshtml"
           Write(claim.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\t\t</tr>\n");
#nullable restore
#line 20 "C:\Users\mania\Desktop\Łukaszek\PW OKNO\projekt TI\moje\ImageHosting\ImageHosting\ImageHosting\Views\Home\Claims.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
