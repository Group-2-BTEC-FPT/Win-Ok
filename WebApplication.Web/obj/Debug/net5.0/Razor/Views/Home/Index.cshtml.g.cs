#pragma checksum "D:\Co loan\WebApplication\WebApplication.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6e8e733fa5e7bb803826f50c8976b2fee8603ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Co loan\WebApplication\WebApplication.Web\Views\_ViewImports.cshtml"
using WebApplication.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Co loan\WebApplication\WebApplication.Web\Views\_ViewImports.cshtml"
using WebApplication.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6e8e733fa5e7bb803826f50c8976b2fee8603ec", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55dcb12be480a17ed0836b14daa9689fbfa158f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Co loan\WebApplication\WebApplication.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        let html = ""<div class='row'>"";
        $.ajax({
            url: ""https://localhost:5001/api/Topics"",
            type: ""GET"",
            success: function (response) {
                for (let i of response) {
                    html += `<div class='card col-4'><div class=""card-header"">Tiêu đề:  `+i.name+`  ></div><div class=""card-body""><h2>Tên môn học:  `+ i.courses.name +` </h2><small></small><p>Mô tả + i.description + </p>Thời gian bắt đầu khóa học:  + moment(i.courses.start_Date).format(""DD/MM/YYYY"") + </div></div>`
                }
                console.log(moment().format())
                html += ""</div>""
                $(""#content"").html(html);
            }
        })
    </script>
");
            }
            );
            WriteLiteral("<div class=\"text-center\">\r\n    <div id=\"content\"></div>\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
