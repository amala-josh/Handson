#pragma checksum "F:\Files\Amala\COGNIZANT\Nunit Testing\Hands On\Handson\ASPEmployeePartialView\ASPEmployeePartialView\Views\Shared\_PartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cae75b4b69853da372e84cbaba47739a92ee939"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PartialView), @"mvc.1.0.view", @"/Views/Shared/_PartialView.cshtml")]
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
#line 1 "F:\Files\Amala\COGNIZANT\Nunit Testing\Hands On\Handson\ASPEmployeePartialView\ASPEmployeePartialView\Views\_ViewImports.cshtml"
using ASPEmployeePartialView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Files\Amala\COGNIZANT\Nunit Testing\Hands On\Handson\ASPEmployeePartialView\ASPEmployeePartialView\Views\_ViewImports.cshtml"
using ASPEmployeePartialView.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cae75b4b69853da372e84cbaba47739a92ee939", @"/Views/Shared/_PartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cc574216f1a506f25108897cfe9b51e3d4071e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "F:\Files\Amala\COGNIZANT\Nunit Testing\Hands On\Handson\ASPEmployeePartialView\ASPEmployeePartialView\Views\Shared\_PartialView.cshtml"
 foreach (var i in Model)
{
    if (i.IsPermanent == true)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <span class=\"col-md-4\"><b>");
#nullable restore
#line 12 "F:\Files\Amala\COGNIZANT\Nunit Testing\Hands On\Handson\ASPEmployeePartialView\ASPEmployeePartialView\Views\Shared\_PartialView.cshtml"
                         Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 12 "F:\Files\Amala\COGNIZANT\Nunit Testing\Hands On\Handson\ASPEmployeePartialView\ASPEmployeePartialView\Views\Shared\_PartialView.cshtml"
                                   Write(i.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></span>\r\n</div> ");
#nullable restore
#line 13 "F:\Files\Amala\COGNIZANT\Nunit Testing\Hands On\Handson\ASPEmployeePartialView\ASPEmployeePartialView\Views\Shared\_PartialView.cshtml"
       }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <span class=\"col-md-4\">");
#nullable restore
#line 17 "F:\Files\Amala\COGNIZANT\Nunit Testing\Hands On\Handson\ASPEmployeePartialView\ASPEmployeePartialView\Views\Shared\_PartialView.cshtml"
                      Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 17 "F:\Files\Amala\COGNIZANT\Nunit Testing\Hands On\Handson\ASPEmployeePartialView\ASPEmployeePartialView\Views\Shared\_PartialView.cshtml"
                                Write(i.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</div>");
#nullable restore
#line 18 "F:\Files\Amala\COGNIZANT\Nunit Testing\Hands On\Handson\ASPEmployeePartialView\ASPEmployeePartialView\Views\Shared\_PartialView.cshtml"
      }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
