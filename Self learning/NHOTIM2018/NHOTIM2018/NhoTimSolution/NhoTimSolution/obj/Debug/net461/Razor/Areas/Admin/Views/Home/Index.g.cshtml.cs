#pragma checksum "C:\Users\Thuy Dao Xuan\Desktop\NHOTIM2018\NHOTIM2018\NhoTimSolution\NhoTimSolution\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c34274aee03e4e80bbee02e31213ee344b3696aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Home/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c34274aee03e4e80bbee02e31213ee344b3696aa", @"/Areas/Admin/Views/Home/Index.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Thuy Dao Xuan\Desktop\NHOTIM2018\NHOTIM2018\NhoTimSolution\NhoTimSolution\Areas\Admin\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(58, 355, true);
                WriteLiteral(@"
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jstree/3.2.1/jstree.min.js"" defer></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jQuery-slimScroll/1.3.8/jquery.slimscroll.min.js"" defer></script>
    <script src=""/js/ScriptControl/NTControl.js"" defer></script>
    <script src=""/js/ScriptControl/upload.js"" defer></script>
");
                EndContext();
            }
            );
            BeginContext(416, 16, true);
            WriteLiteral("<h2>Index</h2>\r\n");
            EndContext();
            BeginContext(433, 61, false);
#line 13 "C:\Users\Thuy Dao Xuan\Desktop\NHOTIM2018\NHOTIM2018\NhoTimSolution\NhoTimSolution\Areas\Admin\Views\Home\Index.cshtml"
Write(Html.Partial("/Areas/Admin/Views/Shared/UploadLayout.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(494, 251, true);
            WriteLiteral("\r\n<script>\r\n    function runUpload() {\r\n        if (typeof FM != \'undefined\') {\r\n            FM.setFolderID(1);\r\n            FM.create();\r\n       \r\n        } else {\r\n            setTimeout(runUpload, 10);\r\n        }\r\n    }\r\n    runUpload();\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
