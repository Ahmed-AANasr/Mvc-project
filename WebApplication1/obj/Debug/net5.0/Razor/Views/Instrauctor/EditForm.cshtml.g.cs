#pragma checksum "G:\ITI\MVC\Lab2\WebApplication1\WebApplication1\Views\Instrauctor\EditForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "823516c42f841aa8b6536b6d8620525ce2c2e4b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Instrauctor_EditForm), @"mvc.1.0.view", @"/Views/Instrauctor/EditForm.cshtml")]
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
#line 1 "G:\ITI\MVC\Lab2\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\ITI\MVC\Lab2\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"823516c42f841aa8b6536b6d8620525ce2c2e4b1", @"/Views/Instrauctor/EditForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Instrauctor_EditForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Instrauctor>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "823516c42f841aa8b6536b6d8620525ce2c2e4b13719", async() => {
                WriteLiteral("\r\n\r\n    <div>\r\n    <label for=\"Name\">Name</label>\r\n    <input id=\"Name\" name=\"Name\"");
                BeginWriteAttribute("value", " value=\"", 164, "\"", 183, 1);
#nullable restore
#line 8 "G:\ITI\MVC\Lab2\WebApplication1\WebApplication1\Views\Instrauctor\EditForm.cshtml"
WriteAttributeValue("", 172, Model.Name, 172, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text\" class =\"form-control\" />\r\n    </div>\r\n    <div>\r\n    <label for=\"Salary\">Salary</label>\r\n    <input id=\"Salary\" name=\"Salary\"");
                BeginWriteAttribute("value", " value=\"", 322, "\"", 343, 1);
#nullable restore
#line 12 "G:\ITI\MVC\Lab2\WebApplication1\WebApplication1\Views\Instrauctor\EditForm.cshtml"
WriteAttributeValue("", 330, Model.Salary, 330, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"number\" class =\"form-control\" />\r\n    </div>\r\n     <div>\r\n    <label for=\"Image\">Image</label>\r\n    <input id=\"Image\" name=\"Image\"");
                BeginWriteAttribute("value", " value=\"", 481, "\"", 501, 1);
#nullable restore
#line 16 "G:\ITI\MVC\Lab2\WebApplication1\WebApplication1\Views\Instrauctor\EditForm.cshtml"
WriteAttributeValue("", 489, Model.Image, 489, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text\" class =\"form-control\" />\r\n    </div>\r\n    <div>\r\n    <label for=\"Address\">Address</label>\r\n    <input id=\"Address\" name=\"Address\"");
                BeginWriteAttribute("value", " value=\"", 644, "\"", 666, 1);
#nullable restore
#line 20 "G:\ITI\MVC\Lab2\WebApplication1\WebApplication1\Views\Instrauctor\EditForm.cshtml"
WriteAttributeValue("", 652, Model.Address, 652, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text\" class =\"form-control\" />\r\n    </div>\r\n    <div>\r\n    <label for=\"dep_id\">Department</label>\r\n\r\n    <select id=\"dep_id\" name=\"dep_id\"");
                BeginWriteAttribute("value", " value=\"", 812, "\"", 833, 1);
#nullable restore
#line 25 "G:\ITI\MVC\Lab2\WebApplication1\WebApplication1\Views\Instrauctor\EditForm.cshtml"
WriteAttributeValue("", 820, Model.dep_id, 820, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class =\"form-control\" >\r\n");
#nullable restore
#line 26 "G:\ITI\MVC\Lab2\WebApplication1\WebApplication1\Views\Instrauctor\EditForm.cshtml"
         foreach (var item in ViewBag.dept)
       {
           if (Model.dep_id == item.Id)
           {

#line default
#line hidden
#nullable disable
                WriteLiteral("           ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "823516c42f841aa8b6536b6d8620525ce2c2e4b16932", async() => {
                    WriteLiteral("\r\n               ");
#nullable restore
#line 31 "G:\ITI\MVC\Lab2\WebApplication1\WebApplication1\Views\Instrauctor\EditForm.cshtml"
          Write(item.Name);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "G:\ITI\MVC\Lab2\WebApplication1\WebApplication1\Views\Instrauctor\EditForm.cshtml"
              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 33 "G:\ITI\MVC\Lab2\WebApplication1\WebApplication1\Views\Instrauctor\EditForm.cshtml"
                }else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "823516c42f841aa8b6536b6d8620525ce2c2e4b19456", async() => {
                    WriteLiteral("\r\n               ");
#nullable restore
#line 36 "G:\ITI\MVC\Lab2\WebApplication1\WebApplication1\Views\Instrauctor\EditForm.cshtml"
          Write(item.Name);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "G:\ITI\MVC\Lab2\WebApplication1\WebApplication1\Views\Instrauctor\EditForm.cshtml"
                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 38 "G:\ITI\MVC\Lab2\WebApplication1\WebApplication1\Views\Instrauctor\EditForm.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </select>\r\n\r\n    </div>\r\n    <div>\r\n    <label for=\"crs_id\">Courses</label>\r\n    <select id=\"crs_id\" name=\"crs_id\"");
                BeginWriteAttribute("value", " value=\"", 1375, "\"", 1396, 1);
#nullable restore
#line 45 "G:\ITI\MVC\Lab2\WebApplication1\WebApplication1\Views\Instrauctor\EditForm.cshtml"
WriteAttributeValue("", 1383, Model.crs_id, 1383, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class =\"form-control\" >\r\n");
#nullable restore
#line 46 "G:\ITI\MVC\Lab2\WebApplication1\WebApplication1\Views\Instrauctor\EditForm.cshtml"
         foreach (var item in ViewBag.crs)
       {
           if (Model.crs_id == item.Id)
           {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "823516c42f841aa8b6536b6d8620525ce2c2e4b112501", async() => {
                    WriteLiteral("\r\n               ");
#nullable restore
#line 51 "G:\ITI\MVC\Lab2\WebApplication1\WebApplication1\Views\Instrauctor\EditForm.cshtml"
          Write(item.Name);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "G:\ITI\MVC\Lab2\WebApplication1\WebApplication1\Views\Instrauctor\EditForm.cshtml"
               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 53 "G:\ITI\MVC\Lab2\WebApplication1\WebApplication1\Views\Instrauctor\EditForm.cshtml"
                }else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "823516c42f841aa8b6536b6d8620525ce2c2e4b115023", async() => {
                    WriteLiteral("\r\n               ");
#nullable restore
#line 56 "G:\ITI\MVC\Lab2\WebApplication1\WebApplication1\Views\Instrauctor\EditForm.cshtml"
          Write(item.Name);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n           ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "G:\ITI\MVC\Lab2\WebApplication1\WebApplication1\Views\Instrauctor\EditForm.cshtml"
                   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 58 "G:\ITI\MVC\Lab2\WebApplication1\WebApplication1\Views\Instrauctor\EditForm.cshtml"
                    
                }
       }    

#line default
#line hidden
#nullable disable
                WriteLiteral("    </select>\r\n    </div>\r\n\r\n\r\n    <div>\r\n        <input type=\"submit\" class=\"btn btn-danger\" value=\"Submit\" style =\"margin-top : 10px\"/>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 52, "/Instrauctor/Edit/", 52, 18, true);
#nullable restore
#line 4 "G:\ITI\MVC\Lab2\WebApplication1\WebApplication1\Views\Instrauctor\EditForm.cshtml"
AddHtmlAttributeValue("", 70, Model.ID, 70, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Instrauctor> Html { get; private set; }
    }
}
#pragma warning restore 1591
