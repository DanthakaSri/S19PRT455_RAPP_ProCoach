#pragma checksum "E:\CDU works\Software development Project\ProCoachApp\ProCoach\Views\Teams\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82ac9a88eb0356488416cd40b8b5161a165ee98e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teams_Details), @"mvc.1.0.view", @"/Views/Teams/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Teams/Details.cshtml", typeof(AspNetCore.Views_Teams_Details))]
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
#line 1 "E:\CDU works\Software development Project\ProCoachApp\ProCoach\Views\_ViewImports.cshtml"
using ProCoach;

#line default
#line hidden
#line 2 "E:\CDU works\Software development Project\ProCoachApp\ProCoach\Views\_ViewImports.cshtml"
using ProCoach.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82ac9a88eb0356488416cd40b8b5161a165ee98e", @"/Views/Teams/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19925c49575c19b863274f7a5c69beb016c71b5d", @"/Views/_ViewImports.cshtml")]
    public class Views_Teams_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProCoach.Data.Team>
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
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\CDU works\Software development Project\ProCoachApp\ProCoach\Views\Teams\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "_AdminLayout";

#line default
#line hidden
            BeginContext(102, 203, true);
            WriteLiteral("    <section class=\"content\">\r\n        <h2>Details</h2>\r\n\r\n        <div>\r\n            <h4>Team</h4>\r\n            <hr />\r\n            <dl class=\"dl-horizontal\">\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(306, 45, false);
#line 15 "E:\CDU works\Software development Project\ProCoachApp\ProCoach\Views\Teams\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.team_name));

#line default
#line hidden
            EndContext();
            BeginContext(351, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(419, 41, false);
#line 18 "E:\CDU works\Software development Project\ProCoachApp\ProCoach\Views\Teams\Details.cshtml"
               Write(Html.DisplayFor(model => model.team_name));

#line default
#line hidden
            EndContext();
            BeginContext(460, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(528, 41, false);
#line 21 "E:\CDU works\Software development Project\ProCoachApp\ProCoach\Views\Teams\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(569, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(637, 37, false);
#line 24 "E:\CDU works\Software development Project\ProCoachApp\ProCoach\Views\Teams\Details.cshtml"
               Write(Html.DisplayFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(674, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(742, 40, false);
#line 27 "E:\CDU works\Software development Project\ProCoachApp\ProCoach\Views\Teams\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.club));

#line default
#line hidden
            EndContext();
            BeginContext(782, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(850, 36, false);
#line 30 "E:\CDU works\Software development Project\ProCoachApp\ProCoach\Views\Teams\Details.cshtml"
               Write(Html.DisplayFor(model => model.club));

#line default
#line hidden
            EndContext();
            BeginContext(886, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(954, 41, false);
#line 33 "E:\CDU works\Software development Project\ProCoachApp\ProCoach\Views\Teams\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.sport));

#line default
#line hidden
            EndContext();
            BeginContext(995, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1063, 37, false);
#line 36 "E:\CDU works\Software development Project\ProCoachApp\ProCoach\Views\Teams\Details.cshtml"
               Write(Html.DisplayFor(model => model.sport));

#line default
#line hidden
            EndContext();
            BeginContext(1100, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(1168, 43, false);
#line 39 "E:\CDU works\Software development Project\ProCoachApp\ProCoach\Views\Teams\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.coaches));

#line default
#line hidden
            EndContext();
            BeginContext(1211, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1279, 39, false);
#line 42 "E:\CDU works\Software development Project\ProCoachApp\ProCoach\Views\Teams\Details.cshtml"
               Write(Html.DisplayFor(model => model.coaches));

#line default
#line hidden
            EndContext();
            BeginContext(1318, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(1386, 47, false);
#line 45 "E:\CDU works\Software development Project\ProCoachApp\ProCoach\Views\Teams\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.competition));

#line default
#line hidden
            EndContext();
            BeginContext(1433, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1501, 43, false);
#line 48 "E:\CDU works\Software development Project\ProCoachApp\ProCoach\Views\Teams\Details.cshtml"
               Write(Html.DisplayFor(model => model.competition));

#line default
#line hidden
            EndContext();
            BeginContext(1544, 87, true);
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(1631, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "539a886b8e3e4d0590606fec1069cad5", async() => {
                BeginContext(1677, 4, true);
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
#line 53 "E:\CDU works\Software development Project\ProCoachApp\ProCoach\Views\Teams\Details.cshtml"
                                   WriteLiteral(Model.id);

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
            BeginContext(1685, 16, true);
            WriteLiteral(" |\r\n            ");
            EndContext();
            BeginContext(1701, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e1c0a4dd4c14136b7634496d559e27d", async() => {
                BeginContext(1723, 12, true);
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
            BeginContext(1739, 36, true);
            WriteLiteral("\r\n        </div>\r\n        </section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProCoach.Data.Team> Html { get; private set; }
    }
}
#pragma warning restore 1591
