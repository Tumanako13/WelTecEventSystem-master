#pragma checksum "E:\Ezra Turner\GitHub Good Copy\WelTecEventSystem-master\WelTecEventSystem-master\Views\Events\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "051aba78801be7377293fe8304b0cee99a57d158"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Events_Index), @"mvc.1.0.view", @"/Views/Events/Index.cshtml")]
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
#line 1 "E:\Ezra Turner\GitHub Good Copy\WelTecEventSystem-master\WelTecEventSystem-master\Views\_ViewImports.cshtml"
using WelTecEventSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Ezra Turner\GitHub Good Copy\WelTecEventSystem-master\WelTecEventSystem-master\Views\_ViewImports.cshtml"
using WelTecEventSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"051aba78801be7377293fe8304b0cee99a57d158", @"/Views/Events/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0fd79af56eb652f2937f31ac16f3fddca319cb1", @"/Views/_ViewImports.cshtml")]
    public class Views_Events_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WelTecEventSystem.Models.Event>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("container-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "E:\Ezra Turner\GitHub Good Copy\WelTecEventSystem-master\WelTecEventSystem-master\Views\Events\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!DOCTYPE html>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "051aba78801be7377293fe8304b0cee99a57d1585369", async() => {
                WriteLiteral("\n    <script type=\"text/javascript\" class=\"init\">\n        $(document).ready(function () {\n            $(\'#eventTable\').DataTable();\n        });\n    </script>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "051aba78801be7377293fe8304b0cee99a57d1586501", async() => {
                WriteLiteral("\n\n    <p>\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "051aba78801be7377293fe8304b0cee99a57d1586776", async() => {
                    WriteLiteral("Create New");
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
                WriteLiteral("\n    </p>\n    <table id=\"eventTable\" class=\"display responsive table table-striped table-bordered table-hover\" style=\"width:100%\">\n        <thead>\n            <tr>\n");
                WriteLiteral("                <th>\n                    Edit/Details/Delete\n                </th>\n                <th>\n                    ");
#nullable restore
#line 31 "E:\Ezra Turner\GitHub Good Copy\WelTecEventSystem-master\WelTecEventSystem-master\Views\Events\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.EventName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 34 "E:\Ezra Turner\GitHub Good Copy\WelTecEventSystem-master\WelTecEventSystem-master\Views\Events\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.EventType));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 37 "E:\Ezra Turner\GitHub Good Copy\WelTecEventSystem-master\WelTecEventSystem-master\Views\Events\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.EventDescription));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 40 "E:\Ezra Turner\GitHub Good Copy\WelTecEventSystem-master\WelTecEventSystem-master\Views\Events\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.EventDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 43 "E:\Ezra Turner\GitHub Good Copy\WelTecEventSystem-master\WelTecEventSystem-master\Views\Events\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.EventTime));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 46 "E:\Ezra Turner\GitHub Good Copy\WelTecEventSystem-master\WelTecEventSystem-master\Views\Events\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.EventImage1));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 49 "E:\Ezra Turner\GitHub Good Copy\WelTecEventSystem-master\WelTecEventSystem-master\Views\Events\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.EventImage2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 52 "E:\Ezra Turner\GitHub Good Copy\WelTecEventSystem-master\WelTecEventSystem-master\Views\Events\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.EventImage3));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 55 "E:\Ezra Turner\GitHub Good Copy\WelTecEventSystem-master\WelTecEventSystem-master\Views\Events\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.EventLocation));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 58 "E:\Ezra Turner\GitHub Good Copy\WelTecEventSystem-master\WelTecEventSystem-master\Views\Events\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.EventClassroom));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 61 "E:\Ezra Turner\GitHub Good Copy\WelTecEventSystem-master\WelTecEventSystem-master\Views\Events\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.EventHost));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 64 "E:\Ezra Turner\GitHub Good Copy\WelTecEventSystem-master\WelTecEventSystem-master\Views\Events\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.EventRequirements));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 67 "E:\Ezra Turner\GitHub Good Copy\WelTecEventSystem-master\WelTecEventSystem-master\Views\Events\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.MaxNumberOfParticipants));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n            </tr>\n        </thead>\n        <tbody>\n");
#nullable restore
#line 72 "E:\Ezra Turner\GitHub Good Copy\WelTecEventSystem-master\WelTecEventSystem-master\Views\Events\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\n");
                WriteLiteral("                <td>\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "051aba78801be7377293fe8304b0cee99a57d15813456", async() => {
                    WriteLiteral("Edit");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "E:\Ezra Turner\GitHub Good Copy\WelTecEventSystem-master\WelTecEventSystem-master\Views\Events\Index.cshtml"
                                           WriteLiteral(item.EventName);

#line default
#line hidden
#nullable disable
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
                WriteLiteral(" |\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "051aba78801be7377293fe8304b0cee99a57d15815759", async() => {
                    WriteLiteral("Details");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "E:\Ezra Turner\GitHub Good Copy\WelTecEventSystem-master\WelTecEventSystem-master\Views\Events\Index.cshtml"
                                              WriteLiteral(item.EventName);

#line default
#line hidden
#nullable disable
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
                WriteLiteral(" |\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "051aba78801be7377293fe8304b0cee99a57d15818068", async() => {
                    WriteLiteral("Delete");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 79 "E:\Ezra Turner\GitHub Good Copy\WelTecEventSystem-master\WelTecEventSystem-master\Views\Events\Index.cshtml"
                                             WriteLiteral(item.EventName);

#line default
#line hidden
#nullable disable
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
                WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 82 "E:\Ezra Turner\GitHub Good Copy\WelTecEventSystem-master\WelTecEventSystem-master\Views\Events\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.EventName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 85 "E:\Ezra Turner\GitHub Good Copy\WelTecEventSystem-master\WelTecEventSystem-master\Views\Events\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.EventType));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 88 "E:\Ezra Turner\GitHub Good Copy\WelTecEventSystem-master\WelTecEventSystem-master\Views\Events\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.EventDescription));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 91 "E:\Ezra Turner\GitHub Good Copy\WelTecEventSystem-master\WelTecEventSystem-master\Views\Events\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.EventDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 94 "E:\Ezra Turner\GitHub Good Copy\WelTecEventSystem-master\WelTecEventSystem-master\Views\Events\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.EventTime));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 97 "E:\Ezra Turner\GitHub Good Copy\WelTecEventSystem-master\WelTecEventSystem-master\Views\Events\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.EventImage1));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 100 "E:\Ezra Turner\GitHub Good Copy\WelTecEventSystem-master\WelTecEventSystem-master\Views\Events\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.EventImage2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 103 "E:\Ezra Turner\GitHub Good Copy\WelTecEventSystem-master\WelTecEventSystem-master\Views\Events\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.EventImage3));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 106 "E:\Ezra Turner\GitHub Good Copy\WelTecEventSystem-master\WelTecEventSystem-master\Views\Events\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.EventLocation));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 109 "E:\Ezra Turner\GitHub Good Copy\WelTecEventSystem-master\WelTecEventSystem-master\Views\Events\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.EventClassroom));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 112 "E:\Ezra Turner\GitHub Good Copy\WelTecEventSystem-master\WelTecEventSystem-master\Views\Events\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.EventHost));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 115 "E:\Ezra Turner\GitHub Good Copy\WelTecEventSystem-master\WelTecEventSystem-master\Views\Events\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.EventRequirements));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 118 "E:\Ezra Turner\GitHub Good Copy\WelTecEventSystem-master\WelTecEventSystem-master\Views\Events\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.MaxNumberOfParticipants));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n            </tr>\n");
#nullable restore
#line 121 "E:\Ezra Turner\GitHub Good Copy\WelTecEventSystem-master\WelTecEventSystem-master\Views\Events\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\n    </table>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WelTecEventSystem.Models.Event>> Html { get; private set; }
    }
}
#pragma warning restore 1591
