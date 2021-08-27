#pragma checksum "/Users/davidstorer/Documents/code/Collab/CodingDojoProjects/Views/Home/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e4017f2aab3b5599d2cce64a3adb145c9541f40"
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
#line 1 "/Users/davidstorer/Documents/code/Collab/CodingDojoProjects/Views/_ViewImports.cshtml"
using ApartmentNetwork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/davidstorer/Documents/code/Collab/CodingDojoProjects/Views/Home/Dashboard.cshtml"
using ApartmentNetwork.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e4017f2aab3b5599d2cce64a3adb145c9541f40", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bbb9fed7790dbdd94658de8aed3baba3ca9ba97", @"/Views/_ViewImports.cshtml")]
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
            WriteLiteral("\n<nav id=\"navBar\">\n    <h1>Dashboard!</h1>\n    <div>\n        <h4>Hello ");
#nullable restore
#line 8 "/Users/davidstorer/Documents/code/Collab/CodingDojoProjects/Views/Home/Dashboard.cshtml"
             Write(ViewBag.CurrentUser.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 8 "/Users/davidstorer/Documents/code/Collab/CodingDojoProjects/Views/Home/Dashboard.cshtml"
                                            Write(ViewBag.CurrentUser.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</h4>\n        <h4>Building Number ");
#nullable restore
#line 9 "/Users/davidstorer/Documents/code/Collab/CodingDojoProjects/Views/Home/Dashboard.cshtml"
                       Write(ViewBag.CurrentUser.BuildingId);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</h4>\n    </div>\n    <div id=\"navButtons\">\n        \n");
#nullable restore
#line 13 "/Users/davidstorer/Documents/code/Collab/CodingDojoProjects/Views/Home/Dashboard.cshtml"
         if(ViewBag.CurrentUser.IsAdmin == true)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a href=\"/pendingResidents\">Pending Neighbors (");
#nullable restore
#line 15 "/Users/davidstorer/Documents/code/Collab/CodingDojoProjects/Views/Home/Dashboard.cshtml"
                                                      Write(ViewBag.PendingResidents);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</a>\n");
#nullable restore
#line 16 "/Users/davidstorer/Documents/code/Collab/CodingDojoProjects/Views/Home/Dashboard.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <a href=""/Logout"" class=""btn btn-lg btn-danger m-3"">Logout</a>
    </div>
</nav>


<div id=""dashboardLayout"">

    <div id=""liveChatCol"" class=""infoCol"">
        <h3>Live Chat</h3>
        <div class=""textCol"">
        
        <ul id=""messagesList""></ul>
        <div><input type=""hidden"" id=""userInput""");
            BeginWriteAttribute("value", " value=\"", 780, "\"", 850, 3);
#nullable restore
#line 29 "/Users/davidstorer/Documents/code/Collab/CodingDojoProjects/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 788, ViewBag.CurrentUser.FirstName, 788, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 818, ",", 818, 1, true);
#nullable restore
#line 29 "/Users/davidstorer/Documents/code/Collab/CodingDojoProjects/Views/Home/Dashboard.cshtml"
WriteAttributeValue(" ", 819, ViewBag.CurrentUser.AptNumber, 820, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/></div>\n        <div><input type=\"hidden\" id=\"bldgId\"");
            BeginWriteAttribute("value", " value=\"", 905, "\"", 944, 1);
#nullable restore
#line 30 "/Users/davidstorer/Documents/code/Collab/CodingDojoProjects/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 913, ViewBag.CurrentUser.BuildingId, 913, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/></div>\n        <input type=\"text\" id=\"messageInput\" onfocus=\"this.value=\'\'\"/>\n        <input type=\"button\" id=\"sendButton\" value=\"Send Message\" class=\"addButton btn btn-lg btn-info m-3\" />\n");
            WriteLiteral("        </div>");
            WriteLiteral("    </div>");
            WriteLiteral("\n    <div id=\"buildingEventsCol\" class=\"infoCol\">\n        <h3>Events</h3>\n");
#nullable restore
#line 39 "/Users/davidstorer/Documents/code/Collab/CodingDojoProjects/Views/Home/Dashboard.cshtml"
         foreach(var evnt in ViewBag.AllEvents)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"textCol\">\n            <div class=\"eventTitle\"><h5><b> ");
#nullable restore
#line 42 "/Users/davidstorer/Documents/code/Collab/CodingDojoProjects/Views/Home/Dashboard.cshtml"
                                       Write(evnt.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("  on  ");
#nullable restore
#line 42 "/Users/davidstorer/Documents/code/Collab/CodingDojoProjects/Views/Home/Dashboard.cshtml"
                                                        Write(evnt.EventDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h5></div>\n            <div class=\"eventPlanner\"><h6>Planner: ");
#nullable restore
#line 43 "/Users/davidstorer/Documents/code/Collab/CodingDojoProjects/Views/Home/Dashboard.cshtml"
                                              Write(evnt.Creator.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 43 "/Users/davidstorer/Documents/code/Collab/CodingDojoProjects/Views/Home/Dashboard.cshtml"
                                                                      Write(evnt.Creator.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" in ");
#nullable restore
#line 43 "/Users/davidstorer/Documents/code/Collab/CodingDojoProjects/Views/Home/Dashboard.cshtml"
                                                                                                Write(evnt.Creator.AptNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6></div>\n                <p class=\"eventDescription\">");
#nullable restore
#line 44 "/Users/davidstorer/Documents/code/Collab/CodingDojoProjects/Views/Home/Dashboard.cshtml"
                                       Write(evnt.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        </div>");
            WriteLiteral("        <hr/>\n");
#nullable restore
#line 47 "/Users/davidstorer/Documents/code/Collab/CodingDojoProjects/Views/Home/Dashboard.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""textCol"">
            <div class=""eventTitle""><h5><b> Birthday Party    9/17    All Day</b></h5></div>
            <div class=""eventPlanner""><h6>Planner: John Goodman</h6></div>
                <p class=""eventDescription"">Lorem ipsum dolor sit amet consectetur, adipisicing elit. Modi accusamus voluptas reiciendis doloribus architecto necessitatibus quibusdam aut, fugiat optio distinctio quas pariatur, animi unde inventore, tempore reprehenderit fugit? Neque, adipisci?</p>
        </div>");
            WriteLiteral(@"        <hr/>
        <div class=""textCol"">
            <div class=""eventTitle""><h5><b> Halloween Party    10/31    9:00PM</b></h5></div>
            <div class=""eventPlanner""><h6>Planner: Jack Skullington</h6></div>
                <p class=""eventDescription"">Lorem ipsum dolor sit amet consectetur, adipisicing elit. Modi accusamus voluptas reiciendis doloribus architecto necessitatibus quibusdam aut, fugiat optio distinctio quas pariatur, animi unde inventore, tempore reprehenderit fugit? Neque, adipisci?</p>
        </div>");
            WriteLiteral("        <hr/>\n");
            WriteLiteral("\n\n        <a href=\"/event\" class=\"addButton btn btn-lg btn-info m-3\">Add New Event</a>\n\n    </div>\n\n    <div id=\"postsCol\" class=\"infoCol\">\n        <h3>Posts</h3>\n");
#nullable restore
#line 69 "/Users/davidstorer/Documents/code/Collab/CodingDojoProjects/Views/Home/Dashboard.cshtml"
         foreach(var bltn in ViewBag.AllBulletins)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"textCol\">\n            <div class=\"eventTitle\"><h5><b> ");
#nullable restore
#line 72 "/Users/davidstorer/Documents/code/Collab/CodingDojoProjects/Views/Home/Dashboard.cshtml"
                                       Write(bltn.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b></h5></div>\n            <div class=\"eventTopic\"><h5><b>On the topic of: ");
#nullable restore
#line 73 "/Users/davidstorer/Documents/code/Collab/CodingDojoProjects/Views/Home/Dashboard.cshtml"
                                                       Write(bltn.Topic);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b></h5></div>\n            <div class=\"eventPlanner\"><h6>Posted by: ");
#nullable restore
#line 74 "/Users/davidstorer/Documents/code/Collab/CodingDojoProjects/Views/Home/Dashboard.cshtml"
                                                Write(bltn.Creator.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 74 "/Users/davidstorer/Documents/code/Collab/CodingDojoProjects/Views/Home/Dashboard.cshtml"
                                                                        Write(bltn.Creator.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" in ");
#nullable restore
#line 74 "/Users/davidstorer/Documents/code/Collab/CodingDojoProjects/Views/Home/Dashboard.cshtml"
                                                                                                  Write(bltn.Creator.AptNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6></div>\n                <p class=\"eventDescription\">");
#nullable restore
#line 75 "/Users/davidstorer/Documents/code/Collab/CodingDojoProjects/Views/Home/Dashboard.cshtml"
                                       Write(bltn.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        </div>");
            WriteLiteral("        <hr/>\n");
#nullable restore
#line 78 "/Users/davidstorer/Documents/code/Collab/CodingDojoProjects/Views/Home/Dashboard.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""textCol"">
            <div class=""eventTitle""><h5><b> Lost Dog</b></h5></div>
            <div class=""eventPlanner""><h6>Pete Borgensen, 8g</h6></div>
            <p class=""eventDescription"">Lorem ipsum dolor sit amet consectetur, adipisicing elit. Neque, adipisci?</p>
        </div>");
            WriteLiteral(@"        <hr/>
        <div class=""textCol"">
            <div class=""eventTitle""><h5><b>Car Lights On</b></h5></div>
            <div class=""eventPlanner""><h6>Jane Harrow, 3c</h6></div>
            <p class=""eventDescription"">Lorem ipsum dolor sit amet consectetur, adipisicing elit. Neque, adipisci?</p>
        </div>");
            WriteLiteral("        <hr/>\n        <a href=\"/bulletin\" class=\"addButton btn btn-lg btn-info m-3\">Add New Post</a>\n    </div>\n\n</div>");
            WriteLiteral("\n\n\n    <div class=\"container\" id=\"AllBuildingResidentsTable\">\n        <table class=\"table text-white\">\n");
            WriteLiteral("            <tbody>\n");
            WriteLiteral("            \n");
            WriteLiteral("                \n");
            WriteLiteral("                \n                <tr>\n                <!-- these have to line up with the names in the SQL database -->\n");
            WriteLiteral("                    \n");
            WriteLiteral("                </tr>\n            \n            </tbody>\n        </table>\n    </div>\n");
            WriteLiteral("<script>\n");
            WriteLiteral("</script>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e4017f2aab3b5599d2cce64a3adb145c9541f4015145", async() => {
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e4017f2aab3b5599d2cce64a3adb145c9541f4016169", async() => {
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
            WriteLiteral("\n");
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
