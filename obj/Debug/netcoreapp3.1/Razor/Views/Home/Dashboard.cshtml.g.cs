#pragma checksum "C:\Users\Alex J. Gendal\Documents\Coding Dojo Bootcamp\Personal Projects\ApartmentNetwork\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9894e2d6c3406ce5774ed130a7c133628609f90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.razor-page", @"/Views/Home/Dashboard.cshtml")]
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
#line 1 "C:\Users\Alex J. Gendal\Documents\Coding Dojo Bootcamp\Personal Projects\ApartmentNetwork\Views\_ViewImports.cshtml"
using ApartmentNetwork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alex J. Gendal\Documents\Coding Dojo Bootcamp\Personal Projects\ApartmentNetwork\Views\Home\Dashboard.cshtml"
using ApartmentNetwork.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9894e2d6c3406ce5774ed130a7c133628609f90", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b0841f52bd3e9f5f2033c8ae54da6a2fb86a2c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/chat.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<nav id=\"navBar\">\r\n    <h1>Dashboard!</h1>\r\n    <div>\r\n        <h4>Hello ");
#nullable restore
#line 8 "C:\Users\Alex J. Gendal\Documents\Coding Dojo Bootcamp\Personal Projects\ApartmentNetwork\Views\Home\Dashboard.cshtml"
             Write(ViewBag.CurrentUser.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 8 "C:\Users\Alex J. Gendal\Documents\Coding Dojo Bootcamp\Personal Projects\ApartmentNetwork\Views\Home\Dashboard.cshtml"
                                            Write(ViewBag.CurrentUser.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</h4>\r\n        <h4>Building Number ");
#nullable restore
#line 9 "C:\Users\Alex J. Gendal\Documents\Coding Dojo Bootcamp\Personal Projects\ApartmentNetwork\Views\Home\Dashboard.cshtml"
                       Write(ViewBag.CurrentUser.BuildingId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"!</h4>
    </div>
    <div id=""navButtons"">
        <a href=""/Logout"" class=""btn btn-lg btn-danger m-3"">Logout</a>
    </div>
</nav>


<div id=""dashboardLayout"">

    <div id=""liveChatCol"">
        <p>Live Chat for [apartment address]</p>
        
        <ul id=""messagesList""></ul>
        <div><input type=""hidden"" id=""userInput""");
            BeginWriteAttribute("value", " value=\"", 610, "\"", 681, 4);
            WriteAttributeValue("", 618, ">", 618, 1, true);
#nullable restore
#line 23 "C:\Users\Alex J. Gendal\Documents\Coding Dojo Bootcamp\Personal Projects\ApartmentNetwork\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 619, ViewBag.CurrentUser.FirstName, 619, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 649, ",", 649, 1, true);
#nullable restore
#line 23 "C:\Users\Alex J. Gendal\Documents\Coding Dojo Bootcamp\Personal Projects\ApartmentNetwork\Views\Home\Dashboard.cshtml"
WriteAttributeValue(" ", 650, ViewBag.CurrentUser.AptNumber, 651, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/></div>\r\n        <div><input type=\"hidden\" id=\"bldgID\"");
            BeginWriteAttribute("value", " value=\"", 737, "\"", 777, 2);
            WriteAttributeValue("", 745, ">", 745, 1, true);
#nullable restore
#line 24 "C:\Users\Alex J. Gendal\Documents\Coding Dojo Bootcamp\Personal Projects\ApartmentNetwork\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 746, ViewBag.CurrentUser.BuildingId, 746, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/></div>\r\n        <input type=\"text\" id=\"messageInput\" />\r\n        <input type=\"button\" id=\"sendButton\" value=\"Send Message\" class=\"addButton btn btn-lg btn-info m-3\" />\r\n");
            WriteLiteral(@"    </div>

    <div id=""buildingEventsCol"">
        <p>this is the  building events</p>
        <a href=""/NewPost"" class=""addButton btn btn-lg btn-info m-3"">Add New Event</a>

    </div>
    <div id=""postsCol"">
        <p>this is the posts column</p>
        <a href=""/NewPost"" class=""addButton btn btn-lg btn-info m-3"">Add New Post</a>
    </div>

</div>");
            WriteLiteral(@"
    <div class=""container"" id=""AllBuildingResidentsTable"">
        <table class=""table text-white"">
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Apartment #</th>
                    <th>Actions</th>
                </tr>
            </thead>
            <tbody>
");
            WriteLiteral("            {\r\n");
            WriteLiteral("                {\r\n                    \r\n");
            WriteLiteral("                }\r\n                <tr>\r\n                <!-- these have to line up with the names in the SQL database -->\r\n");
            WriteLiteral("                    \r\n");
            WriteLiteral("                </tr>\r\n            }\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9894e2d6c3406ce5774ed130a7c133628609f908115", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9894e2d6c3406ce5774ed130a7c133628609f909154", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Views_Home_Dashboard> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Views_Home_Dashboard> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Views_Home_Dashboard>)PageContext?.ViewData;
        public Views_Home_Dashboard Model => ViewData.Model;
    }
}
#pragma warning restore 1591
