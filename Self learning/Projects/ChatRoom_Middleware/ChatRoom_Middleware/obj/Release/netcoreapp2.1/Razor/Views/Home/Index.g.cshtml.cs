#pragma checksum "C:\Users\Thuy Dao Xuan\Desktop\ChatRoom_Middleware\ChatRoom_Middleware\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e4e48deac89ea7a0cb6e3263ac23d7351ca5a08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Thuy Dao Xuan\Desktop\ChatRoom_Middleware\ChatRoom_Middleware\Views\_ViewImports.cshtml"
using ChatRoom_Middleware;

#line default
#line hidden
#line 2 "C:\Users\Thuy Dao Xuan\Desktop\ChatRoom_Middleware\ChatRoom_Middleware\Views\_ViewImports.cshtml"
using ChatRoom_Middleware.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e4e48deac89ea7a0cb6e3263ac23d7351ca5a08", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50796e4548440a3471a49a0c4e08c7f10083c355", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Thuy Dao Xuan\Desktop\ChatRoom_Middleware\ChatRoom_Middleware\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(60, 672, true);
            WriteLiteral(@"<style>
    body {
        margin: 0px;
        padding: 0px;
    }

    .msg {
        position: absolute;
        top: 0;
        bottom: 30px;
        border: 1px solid green;
        margin-bottom: auto;
        display: block;
        overflow: scroll;
        width: 100%;
        white-space: nowrap;
    }
</style>
<div class=""msg"">
    <div style=""position:absolute; bottom:0;"" id=""msgs""></div>
</div>

<div style=""position:absolute;height:20px;bottom:10px;left:0; display:block;width:100%"">
    <input type=""text"" style=""max-width:unset;width:100%;max-width:100%"" id=""MessageField"" placeholder=""type message and press enter"" />
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(750, 61, true);
                WriteLiteral("\r\n    <script>\r\n    $(function () {\r\n        var userName = \'");
                EndContext();
                BeginContext(812, 5, false);
#line 34 "C:\Users\Thuy Dao Xuan\Desktop\ChatRoom_Middleware\ChatRoom_Middleware\Views\Home\Index.cshtml"
                   Write(Model);

#line default
#line hidden
                EndContext();
                BeginContext(817, 952, true);
                WriteLiteral(@"';

        var protocol = location.protocol === ""https:"" ? ""wss:"" : ""ws:"";
        var wsUri = protocol + ""//"" + window.location.host;
        var socket = new WebSocket(wsUri);
        socket.onopen = e => {
            console.log(""socket opened"", e);
        };

        socket.onclose = function (e) {
            console.log(""socket closed"", e);
        };

        socket.onmessage = function (e) {
            console.log(e);
            $('#msgs').append(e.data + '<br />');
        };

        socket.onerror = function (e) {
            console.error(e.data);
        };

        $('#MessageField').keypress(function (e) {
            if (e.which != 13) {
                return;
            }

            e.preventDefault();

            var message = userName + "": "" + $('#MessageField').val();
            socket.send(message);
            $('#MessageField').val('');
        });
    });
    </script>
");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
