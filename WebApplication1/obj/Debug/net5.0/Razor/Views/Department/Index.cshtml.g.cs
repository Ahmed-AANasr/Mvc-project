#pragma checksum "G:\ITI\MVC\Lab2\WebApplication1\WebApplication1\Views\Department\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "900fd0e1cb28921341babb41322e1365f0b12d1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department_Index), @"mvc.1.0.view", @"/Views/Department/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"900fd0e1cb28921341babb41322e1365f0b12d1e", @"/Views/Department/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Department_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Department>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <table class=""table table-bordered table-hover w-75 m-auto"" width=""50%"">
    <tr>
        <th>
            Department Name
        </th>
        <th>
           Department Manager
        </th>   
        <th>
           Show
        </th> 

    </tr>
");
#nullable restore
#line 16 "G:\ITI\MVC\Lab2\WebApplication1\WebApplication1\Views\Department\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 19 "G:\ITI\MVC\Lab2\WebApplication1\WebApplication1\Views\Department\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "G:\ITI\MVC\Lab2\WebApplication1\WebApplication1\Views\Department\Index.cshtml"
           Write(item.Manager);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <button");
            BeginWriteAttribute("onclick", " onclick=\"", 461, "\"", 503, 3);
            WriteAttributeValue("", 471, "showInstructorsDetails(", 471, 23, true);
#nullable restore
#line 22 "G:\ITI\MVC\Lab2\WebApplication1\WebApplication1\Views\Department\Index.cshtml"
WriteAttributeValue("", 494, item.Id, 494, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 502, ")", 502, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Show Instructor</button>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 25 "G:\ITI\MVC\Lab2\WebApplication1\WebApplication1\Views\Department\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<div id=\"result\"></div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function showInstructorsDetails(id){
            $.ajax({
                url: ""/Instrauctor/GetInstructors/""+id,
                //data: {""id"":id},
                success: function(res){
                    $(""#result"").html(res);
                }
            })
        }
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Department>> Html { get; private set; }
    }
}
#pragma warning restore 1591