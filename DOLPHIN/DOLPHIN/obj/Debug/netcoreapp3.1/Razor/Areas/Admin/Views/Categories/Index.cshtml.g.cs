#pragma checksum "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d8c60c198720aab0bd20e15fc3cbc0e5710e781"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Categories_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Categories/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d8c60c198720aab0bd20e15fc3cbc0e5710e781", @"/Areas/Admin/Views/Categories/Index.cshtml")]
    public class Areas_Admin_Views_Categories_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DOLPHIN.Model.Categories>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h2 style=""margin-left:20px"">Quản lý Danh Mục</h2>
<span class=""badge bg-primary"" style=""font-size:20px ; margin-left:20px""><a href=""/Admin/Categories/Create"">Thêm mới danh mục</a></span>
<div class=""card"">
    <div class=""card-header"">
    </div>
    <div class=""card-body"">
        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <th class=""text-center"">
                        Tên
                    </th>
                    <th class=""text-center"">
                        Mô tả
                    </th>
                    <th class=""text-center"">
                        Ngày cập nhật
                    </th>
                    <th class=""text-center"">
                        Cập nhật bởi
                    </th>
                    <th class=""text-center"">
                        Ngày tạo
                    </th>
                    <th class=""text-center"">
                        Tạo bởi
                    </th>
                    <th class=""text-ce");
            WriteLiteral("nter\">\n                        Thao tác\n                    </th>\n                </tr>\n            </thead>\n            <tbody>\n");
#nullable restore
#line 40 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td class=\"text-center\">\n                            ");
#nullable restore
#line 44 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td class=\"text-center\">\n                            ");
#nullable restore
#line 47 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td class=\"text-center\">\n                            ");
#nullable restore
#line 50 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.UpdatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td class=\"text-center\">\n                            ");
#nullable restore
#line 53 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.UpdatedBy.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td class=\"text-center\">\n                            ");
#nullable restore
#line 56 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td class=\"text-center\">\n                            ");
#nullable restore
#line 59 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.CreatedBy.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td class=\"text-center\">\n                            <span class=\"badge bg-warning\"><a");
            BeginWriteAttribute("href", " href=\"", 2427, "\"", 2465, 2);
            WriteAttributeValue("", 2434, "/Admin/Categories/Edit/", 2434, 23, true);
#nullable restore
#line 62 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Index.cshtml"
WriteAttributeValue("", 2457, item.Id, 2457, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sửa</a></span> \n                            <span class=\"badge bg-success\"><a");
            BeginWriteAttribute("href", " href=\"", 2544, "\"", 2585, 2);
            WriteAttributeValue("", 2551, "/Admin/Categories/Details/", 2551, 26, true);
#nullable restore
#line 63 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Index.cshtml"
WriteAttributeValue("", 2577, item.Id, 2577, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Chi tiết</a></span> \n                            <span class=\"badge bg-danger\"><a");
            BeginWriteAttribute("href", " href=\"", 2668, "\"", 2708, 2);
            WriteAttributeValue("", 2675, "/Admin/Categories/Delete/", 2675, 25, true);
#nullable restore
#line 64 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Index.cshtml"
WriteAttributeValue("", 2700, item.Id, 2700, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xóa</a></span>\n                        </td>\n                    </tr>\n");
#nullable restore
#line 67 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DOLPHIN.Model.Categories>> Html { get; private set; }
    }
}
#pragma warning restore 1591
