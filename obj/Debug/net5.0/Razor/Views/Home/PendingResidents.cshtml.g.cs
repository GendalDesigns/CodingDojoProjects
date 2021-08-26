#pragma checksum "/Users/davidstorer/Documents/code/Collab/CodingDojoProjects/Views/Home/PendingResidents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98954faac925fbb4999b7dca4182e5f51cb9deb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PendingResidents), @"mvc.1.0.view", @"/Views/Home/PendingResidents.cshtml")]
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
#line 1 "/Users/davidstorer/Documents/code/Collab/CodingDojoProjects/Views/_ViewImports.cshtml"
using ApartmentNetwork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/davidstorer/Documents/code/Collab/CodingDojoProjects/Views/_ViewImports.cshtml"
using ApartmentNetwork.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98954faac925fbb4999b7dca4182e5f51cb9deb4", @"/Views/Home/PendingResidents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bbb9fed7790dbdd94658de8aed3baba3ca9ba97", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PendingResidents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<table class=\"table\">\n    <thead>\n        <tr>\n            <td>Name</td>\n            <td>Apartment</td>\n            <td>Waiting Since</td>\n            <td>Admit</td>\n            <td>Decline</td>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 14 "/Users/davidstorer/Documents/code/Collab/CodingDojoProjects/Views/Home/PendingResidents.cshtml"
         foreach (var user in ViewBag.AllBuildingResidents.Residents)
        {
            if(user.ConfirmedByAdmin != true)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 19 "/Users/davidstorer/Documents/code/Collab/CodingDojoProjects/Views/Home/PendingResidents.cshtml"
                   Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 19 "/Users/davidstorer/Documents/code/Collab/CodingDojoProjects/Views/Home/PendingResidents.cshtml"
                                   Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 20 "/Users/davidstorer/Documents/code/Collab/CodingDojoProjects/Views/Home/PendingResidents.cshtml"
                   Write(user.AptNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 21 "/Users/davidstorer/Documents/code/Collab/CodingDojoProjects/Views/Home/PendingResidents.cshtml"
                   Write(user.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 584, "\"", 627, 2);
            WriteAttributeValue("", 591, "/pendingResidents/admit/", 591, 24, true);
#nullable restore
#line 22 "/Users/davidstorer/Documents/code/Collab/CodingDojoProjects/Views/Home/PendingResidents.cshtml"
WriteAttributeValue("", 615, user.UserId, 615, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-success\">Admit</a></td>\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 701, "\"", 746, 2);
            WriteAttributeValue("", 708, "/pendingResidents/decline/", 708, 26, true);
#nullable restore
#line 23 "/Users/davidstorer/Documents/code/Collab/CodingDojoProjects/Views/Home/PendingResidents.cshtml"
WriteAttributeValue("", 734, user.UserId, 734, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-danger\">Decline</a></td>\n                </tr>\n");
#nullable restore
#line 25 "/Users/davidstorer/Documents/code/Collab/CodingDojoProjects/Views/Home/PendingResidents.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n<a href=\"Dashboard\">Return to Dashboard</a>\n<a href=\"Logout\">Logout</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
