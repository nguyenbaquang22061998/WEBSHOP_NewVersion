#pragma checksum "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\News\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d31b23f42b6592f1c9256040a1fee2cecb55d13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_News_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/News/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d31b23f42b6592f1c9256040a1fee2cecb55d13", @"/Areas/Admin/Views/News/Delete.cshtml")]
    public class Areas_Admin_Views_News_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DOLPHIN.Model.News>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\News\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Delete</h1>\n\n<h3>Are you sure you want to delete this?</h3>\n<div>\n    <h4>News</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 16 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\News\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Titile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 19 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\News\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Titile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 22 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\News\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Images));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 25 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\News\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Images));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 28 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\News\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 31 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\News\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 34 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\News\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Refer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 37 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\News\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Refer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 40 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\News\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 43 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\News\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 46 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\News\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 49 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\News\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedBy.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd class>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 52 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\News\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 55 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\News\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 58 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\News\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 61 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\News\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CreatedBy.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd class>\n    </dl>\n    \n    <form asp-action=\"Delete\">\n        <input type=\"hidden\" asp-for=\"Id\" />\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\n        <a asp-action=\"Index\">Back to List</a>\n    </form>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DOLPHIN.Model.News> Html { get; private set; }
    }
}
#pragma warning restore 1591
