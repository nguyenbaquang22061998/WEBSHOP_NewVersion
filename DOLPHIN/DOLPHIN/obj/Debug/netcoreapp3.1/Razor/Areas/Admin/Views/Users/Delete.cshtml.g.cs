#pragma checksum "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Users\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f6ee30e3e8ba1984829fa6ad81f0b9a4c601ece"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Users_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/Users/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f6ee30e3e8ba1984829fa6ad81f0b9a4c601ece", @"/Areas/Admin/Views/Users/Delete.cshtml")]
    public class Areas_Admin_Views_Users_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DOLPHIN.Model.Users>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Users\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h3 style=\"margin-left:20px ; margin-top:20px\">Bạn có chắc chắn muốn xóa tài khoản ");
#nullable restore
#line 8 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Users\Delete.cshtml"
                                                                              Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("?</h3>\n<div class=\"card\">\n");
#nullable restore
#line 10 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Users\Delete.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Users\Delete.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"submit\" value=\"Xóa\" class=\"btn btn-danger\" style=\"margin-left:20px\" />\n        <a href=\"/Admin/Users/Index\" class=\"btn btn-primary\" style=\"margin-left:20px\">Quay lại</a>\n");
#nullable restore
#line 16 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Users\Delete.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DOLPHIN.Model.Users> Html { get; private set; }
    }
}
#pragma warning restore 1591
