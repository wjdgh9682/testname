#pragma checksum "C:\Users\Jeongho\source\repos\SportsEvents2\Areas\Admin\Views\Users\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31fce9b2d8dd2577e010a81a2fd722655be7e6b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Users_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Users/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Users/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_Users_Details))]
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
#line 1 "C:\Users\Jeongho\source\repos\SportsEvents2\Areas\Admin\Views\_ViewImports.cshtml"
using SportsEvents2;

#line default
#line hidden
#line 2 "C:\Users\Jeongho\source\repos\SportsEvents2\Areas\Admin\Views\_ViewImports.cshtml"
using SportsEvents2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31fce9b2d8dd2577e010a81a2fd722655be7e6b8", @"/Areas/Admin/Views/Users/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48f6a0e8148015a4c010576d93ae6cef36275099", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Users_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Jeongho\source\repos\SportsEvents2\Areas\Admin\Views\Users\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(61, 163, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>User</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ID\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(225, 8, false);
#line 17 "C:\Users\Jeongho\source\repos\SportsEvents2\Areas\Admin\Views\Users\Details.cshtml"
       Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(233, 94, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Username\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(328, 14, false);
#line 23 "C:\Users\Jeongho\source\repos\SportsEvents2\Areas\Admin\Views\Users\Details.cshtml"
       Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(342, 91, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Email\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(434, 11, false);
#line 29 "C:\Users\Jeongho\source\repos\SportsEvents2\Areas\Admin\Views\Users\Details.cshtml"
       Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(445, 92, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            Name\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(538, 10, false);
#line 36 "C:\Users\Jeongho\source\repos\SportsEvents2\Areas\Admin\Views\Users\Details.cshtml"
       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(548, 97, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            DateOfBirth\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(646, 17, false);
#line 42 "C:\Users\Jeongho\source\repos\SportsEvents2\Areas\Admin\Views\Users\Details.cshtml"
       Write(Model.DateOfBirth);

#line default
#line hidden
            EndContext();
            BeginContext(663, 92, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Gender\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(756, 12, false);
#line 48 "C:\Users\Jeongho\source\repos\SportsEvents2\Areas\Admin\Views\Users\Details.cshtml"
       Write(Model.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(768, 93, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Address\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(862, 13, false);
#line 54 "C:\Users\Jeongho\source\repos\SportsEvents2\Areas\Admin\Views\Users\Details.cshtml"
       Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(875, 98, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Phone number\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(974, 17, false);
#line 60 "C:\Users\Jeongho\source\repos\SportsEvents2\Areas\Admin\Views\Users\Details.cshtml"
       Write(Model.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(991, 94, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Location\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1086, 14, false);
#line 66 "C:\Users\Jeongho\source\repos\SportsEvents2\Areas\Admin\Views\Users\Details.cshtml"
       Write(Model.Location);

#line default
#line hidden
            EndContext();
            BeginContext(1100, 99, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            PreferedSport\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1200, 19, false);
#line 72 "C:\Users\Jeongho\source\repos\SportsEvents2\Areas\Admin\Views\Users\Details.cshtml"
       Write(Model.PreferedSport);

#line default
#line hidden
            EndContext();
            BeginContext(1219, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1266, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f86273dc55e245dba0a3a5c4c0ec1971", async() => {
                BeginContext(1312, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 77 "C:\Users\Jeongho\source\repos\SportsEvents2\Areas\Admin\Views\Users\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1320, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1328, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63f12a1a7d02473ca892660cff186a1c", async() => {
                BeginContext(1350, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1366, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
