#pragma checksum "F:\Files\Amala\COGNIZANT\Nunit Testing\Hands On\ASP.NetCoreOrganization\ASP.NetCoreOrganization\Views\Home\ITOrganizations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db9bfc4c4cb77aa88dfba94565798bca90ef25bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ITOrganizations), @"mvc.1.0.view", @"/Views/Home/ITOrganizations.cshtml")]
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
#line 1 "F:\Files\Amala\COGNIZANT\Nunit Testing\Hands On\ASP.NetCoreOrganization\ASP.NetCoreOrganization\Views\_ViewImports.cshtml"
using ASP.NetCoreOrganization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Files\Amala\COGNIZANT\Nunit Testing\Hands On\ASP.NetCoreOrganization\ASP.NetCoreOrganization\Views\_ViewImports.cshtml"
using ASP.NetCoreOrganization.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db9bfc4c4cb77aa88dfba94565798bca90ef25bd", @"/Views/Home/ITOrganizations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07d84809dd5bf5706569049e75f5ed3fe78a46c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ITOrganizations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\Files\Amala\COGNIZANT\Nunit Testing\Hands On\ASP.NetCoreOrganization\ASP.NetCoreOrganization\Views\Home\ITOrganizations.cshtml"
   ViewData["Title"] = "ITOrganizations";
Layout = "~/Views/Shared/_Layout.cshtml";
List<string> organizations = new List<string> { "Amazon", " TCS", "Google", "CTS www.cognizant.com", "Microsoft www. microsoft.com" }; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>ITOrganizations in Hyderabad</h1>\n\n");
#nullable restore
#line 7 "F:\Files\Amala\COGNIZANT\Nunit Testing\Hands On\ASP.NetCoreOrganization\ASP.NetCoreOrganization\Views\Home\ITOrganizations.cshtml"
 foreach (var company in organizations)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\n        <span>\n");
#nullable restore
#line 11 "F:\Files\Amala\COGNIZANT\Nunit Testing\Hands On\ASP.NetCoreOrganization\ASP.NetCoreOrganization\Views\Home\ITOrganizations.cshtml"
             if (company == "Amazon")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <b>");
#nullable restore
#line 13 "F:\Files\Amala\COGNIZANT\Nunit Testing\Hands On\ASP.NetCoreOrganization\ASP.NetCoreOrganization\Views\Home\ITOrganizations.cshtml"
              Write(company);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> \n");
#nullable restore
#line 14 "F:\Files\Amala\COGNIZANT\Nunit Testing\Hands On\ASP.NetCoreOrganization\ASP.NetCoreOrganization\Views\Home\ITOrganizations.cshtml"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "F:\Files\Amala\COGNIZANT\Nunit Testing\Hands On\ASP.NetCoreOrganization\ASP.NetCoreOrganization\Views\Home\ITOrganizations.cshtml"
           Write(company);

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "F:\Files\Amala\COGNIZANT\Nunit Testing\Hands On\ASP.NetCoreOrganization\ASP.NetCoreOrganization\Views\Home\ITOrganizations.cshtml"
                        
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </span>\n    </div>\n");
#nullable restore
#line 21 "F:\Files\Amala\COGNIZANT\Nunit Testing\Hands On\ASP.NetCoreOrganization\ASP.NetCoreOrganization\Views\Home\ITOrganizations.cshtml"
}

#line default
#line hidden
#nullable disable
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