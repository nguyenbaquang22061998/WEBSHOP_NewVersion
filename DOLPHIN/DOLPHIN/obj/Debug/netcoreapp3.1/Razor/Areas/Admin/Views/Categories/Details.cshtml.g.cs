#pragma checksum "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "368c681526acc40ef90d303bbd9eca27619d6cb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Categories_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Categories/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"368c681526acc40ef90d303bbd9eca27619d6cb1", @"/Areas/Admin/Views/Categories/Details.cshtml")]
    public class Areas_Admin_Views_Categories_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DOLPHIN.Model.Categories>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2 style=\" margin-left:20px\">Chi tiết</h2>\n\n<div class=\"card\">\n    <div class=\"card-header\">\n        <h4>Danh mục: ");
#nullable restore
#line 12 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Details.cshtml"
                 Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n    </div>\n    <div class=\"card-body\">\n        <dl class=\"row\">\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 17 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 20 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Details.cshtml"
           Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 23 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 26 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Details.cshtml"
           Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 29 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.UpdatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 32 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Details.cshtml"
           Write(Html.DisplayFor(model => model.UpdatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 35 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.UpdatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 38 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Details.cshtml"
           Write(Html.DisplayFor(model => model.UpdatedBy.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 41 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 44 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Details.cshtml"
           Write(Html.DisplayFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 47 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 50 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Details.cshtml"
           Write(Html.DisplayFor(model => model.CreatedBy.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n        </dl>\n    </div>\n</div>\n<a");
            BeginWriteAttribute("href", " href=\"", 1765, "\"", 1804, 2);
            WriteAttributeValue("", 1772, "/Admin/Categories/Edit/", 1772, 23, true);
#nullable restore
#line 55 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Details.cshtml"
WriteAttributeValue("", 1795, Model.Id, 1795, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\" style=\"margin-left:20px\">Chỉnh sửa</a>\n<a href=\"/Admin/Categories/Index\" class=\"btn btn-primary\" style=\"margin-left:20px\">Quay lại</a>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DOLPHIN.Model.Categories> Html { get; private set; }
    }
}
#pragma warning restore 1591
