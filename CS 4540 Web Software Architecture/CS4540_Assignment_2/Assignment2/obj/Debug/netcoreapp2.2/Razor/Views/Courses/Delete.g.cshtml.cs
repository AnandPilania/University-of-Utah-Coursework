#pragma checksum "C:\Users\aaron\Documents\CS 4540\CS4540_Assignment_2\Assignment2\Views\Courses\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52c33c2394716e64b7a90fbda9d7647ab60e9e0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_Delete), @"mvc.1.0.view", @"/Views/Courses/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Courses/Delete.cshtml", typeof(AspNetCore.Views_Courses_Delete))]
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
#line 1 "C:\Users\aaron\Documents\CS 4540\CS4540_Assignment_2\Assignment2\Views\_ViewImports.cshtml"
using Assignment2;

#line default
#line hidden
#line 2 "C:\Users\aaron\Documents\CS 4540\CS4540_Assignment_2\Assignment2\Views\_ViewImports.cshtml"
using Assignment2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52c33c2394716e64b7a90fbda9d7647ab60e9e0c", @"/Views/Courses/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de2f008bb030c689fdd92cf0ac6c09ff2675aa17", @"/Views/_ViewImports.cshtml")]
    public class Views_Courses_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Assignment2.Models.Course>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\aaron\Documents\CS 4540\CS4540_Assignment_2\Assignment2\Views\Courses\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(125, 176, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Course</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(302, 40, false);
#line 16 "C:\Users\aaron\Documents\CS 4540\CS4540_Assignment_2\Assignment2\Views\Courses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
            EndContext();
            BeginContext(342, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(406, 36, false);
#line 19 "C:\Users\aaron\Documents\CS 4540\CS4540_Assignment_2\Assignment2\Views\Courses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.name));

#line default
#line hidden
            EndContext();
            BeginContext(442, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(505, 47, false);
#line 22 "C:\Users\aaron\Documents\CS 4540\CS4540_Assignment_2\Assignment2\Views\Courses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.description));

#line default
#line hidden
            EndContext();
            BeginContext(552, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(616, 43, false);
#line 25 "C:\Users\aaron\Documents\CS 4540\CS4540_Assignment_2\Assignment2\Views\Courses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.description));

#line default
#line hidden
            EndContext();
            BeginContext(659, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(722, 46, false);
#line 28 "C:\Users\aaron\Documents\CS 4540\CS4540_Assignment_2\Assignment2\Views\Courses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.department));

#line default
#line hidden
            EndContext();
            BeginContext(768, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(832, 42, false);
#line 31 "C:\Users\aaron\Documents\CS 4540\CS4540_Assignment_2\Assignment2\Views\Courses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.department));

#line default
#line hidden
            EndContext();
            BeginContext(874, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(937, 42, false);
#line 34 "C:\Users\aaron\Documents\CS 4540\CS4540_Assignment_2\Assignment2\Views\Courses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.number));

#line default
#line hidden
            EndContext();
            BeginContext(979, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1043, 38, false);
#line 37 "C:\Users\aaron\Documents\CS 4540\CS4540_Assignment_2\Assignment2\Views\Courses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.number));

#line default
#line hidden
            EndContext();
            BeginContext(1081, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1144, 45, false);
#line 40 "C:\Users\aaron\Documents\CS 4540\CS4540_Assignment_2\Assignment2\Views\Courses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.semeseter));

#line default
#line hidden
            EndContext();
            BeginContext(1189, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1253, 41, false);
#line 43 "C:\Users\aaron\Documents\CS 4540\CS4540_Assignment_2\Assignment2\Views\Courses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.semeseter));

#line default
#line hidden
            EndContext();
            BeginContext(1294, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1357, 40, false);
#line 46 "C:\Users\aaron\Documents\CS 4540\CS4540_Assignment_2\Assignment2\Views\Courses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.year));

#line default
#line hidden
            EndContext();
            BeginContext(1397, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1461, 36, false);
#line 49 "C:\Users\aaron\Documents\CS 4540\CS4540_Assignment_2\Assignment2\Views\Courses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.year));

#line default
#line hidden
            EndContext();
            BeginContext(1497, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1535, 227, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52c33c2394716e64b7a90fbda9d7647ab60e9e0c9857", async() => {
                BeginContext(1561, 40, true);
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1601, "\"", 1624, 1);
#line 54 "C:\Users\aaron\Documents\CS 4540\CS4540_Assignment_2\Assignment2\Views\Courses\Delete.cshtml"
WriteAttributeValue("", 1609, Model.CourseId, 1609, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1625, 86, true);
                WriteLiteral(" />\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(1711, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52c33c2394716e64b7a90fbda9d7647ab60e9e0c10812", async() => {
                    BeginContext(1733, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1749, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1762, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Assignment2.Models.Course> Html { get; private set; }
    }
}
#pragma warning restore 1591
