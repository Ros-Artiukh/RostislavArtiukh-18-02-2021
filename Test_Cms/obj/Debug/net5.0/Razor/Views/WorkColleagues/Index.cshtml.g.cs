#pragma checksum "C:\Users\Oleg\Desktop\Test_Cms\Test_Cms\Views\WorkColleagues\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "920b631a4975b13edbd3ba73deeab27b41187824"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WorkColleagues_Index), @"mvc.1.0.view", @"/Views/WorkColleagues/Index.cshtml")]
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
#line 1 "C:\Users\Oleg\Desktop\Test_Cms\Test_Cms\Views\_ViewImports.cshtml"
using Test_Cms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Oleg\Desktop\Test_Cms\Test_Cms\Views\_ViewImports.cshtml"
using Test_Cms.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"920b631a4975b13edbd3ba73deeab27b41187824", @"/Views/WorkColleagues/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12f4c931d9fbd89606f2c4515fdab998d07cc838", @"/Views/_ViewImports.cshtml")]
    public class Views_WorkColleagues_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Task<List<Target>>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Oleg\Desktop\Test_Cms\Test_Cms\Views\WorkColleagues\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Work Colleagues book</h1>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr><th>Name</th><th>Number</th><th>Status</th></tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 13 "C:\Users\Oleg\Desktop\Test_Cms\Test_Cms\Views\WorkColleagues\Index.cshtml"
             foreach (var target in await Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr><td>");
#nullable restore
#line 15 "C:\Users\Oleg\Desktop\Test_Cms\Test_Cms\Views\WorkColleagues\Index.cshtml"
                   Write(target.ContactsName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td>");
#nullable restore
#line 15 "C:\Users\Oleg\Desktop\Test_Cms\Test_Cms\Views\WorkColleagues\Index.cshtml"
                                                Write(target.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td>");
#nullable restore
#line 15 "C:\Users\Oleg\Desktop\Test_Cms\Test_Cms\Views\WorkColleagues\Index.cshtml"
                                                                       Write(target.IsActive);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n");
#nullable restore
#line 16 "C:\Users\Oleg\Desktop\Test_Cms\Test_Cms\Views\WorkColleagues\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Task<List<Target>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
