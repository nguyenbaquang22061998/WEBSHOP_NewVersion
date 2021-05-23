#pragma checksum "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea6fb2a3667bcab20440d58f8214b024685fd635"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Products_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Products/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea6fb2a3667bcab20440d58f8214b024685fd635", @"/Areas/Admin/Views/Products/Index.cshtml")]
    public class Areas_Admin_Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DOLPHIN.Model.Products>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2 style=""margin-left:20px"">Quản lý Sản phẩm</h2>
<span class=""badge bg-primary"" style=""font-size:20px ; margin-left:20px""><a href=""/Admin/Products/Create"">Thêm sản phẩm mới</a></span>
<div class=""card"">
    <div class=""card-body"">
        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <th class=""text-center"">
                        Danh mục
                    </th>
                    <th class=""text-center"">
                        Tên sản phẩm
                    </th>
                    <th class=""text-center"">
                        Giá
                    </th>
                    <th class=""text-center"">
                        Mô tả
                    </th>
                    <th class=""text-center"">
                        Ảnh
                    </th>
                    <th class=""text-center"">
                        Trạng thái
                    </th>
                    <th class=""text-center"">
                        Ngày tạo
         ");
            WriteLiteral(@"           </th>
                    <th class=""text-center"">
                        Tạo bởi
                    </th>
                    <th class=""text-center"">
                        Thao tác
                    </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 45 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td class=\"text-center\">\n                        ");
#nullable restore
#line 49 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Categories.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td class=\"text-center\">\n                        ");
#nullable restore
#line 52 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td class=\"text-center\">\n                        ");
#nullable restore
#line 55 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td class=\"text-center\">\n                        ");
#nullable restore
#line 58 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Desciption));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td class=\"text-center\">\n                        <div>\n                            <img");
            BeginWriteAttribute("src", " src=\"", 2211, "\"", 2254, 1);
#nullable restore
#line 62 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Index.cshtml"
WriteAttributeValue("", 2217, Url.Content("~/images/"+item.Images), 2217, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"110\" height=\"110\">\n                        </div>\n                    </td>\n                    <td class=\"text-center\">\n");
#nullable restore
#line 66 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Index.cshtml"
                         if (item.Status == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>Active</p>\n");
#nullable restore
#line 69 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Index.cshtml"
                         if (item.Status == -1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>InActive</p>\n");
#nullable restore
#line 73 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\n                    <td class=\"text-center\">\n                        ");
#nullable restore
#line 76 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td class=\"text-center\">\n                        ");
#nullable restore
#line 79 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CreatedBy.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td class=\"text-center\">\n                        <span class=\"badge bg-warning\"><a");
            BeginWriteAttribute("href", " href=\"", 3087, "\"", 3123, 2);
            WriteAttributeValue("", 3094, "/Admin/Products/Edit/", 3094, 21, true);
#nullable restore
#line 82 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Index.cshtml"
WriteAttributeValue("", 3115, item.Id, 3115, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sửa</a></span>\n                        <span class=\"badge bg-success\"><a");
            BeginWriteAttribute("href", " href=\"", 3197, "\"", 3236, 2);
            WriteAttributeValue("", 3204, "/Admin/Products/Details/", 3204, 24, true);
#nullable restore
#line 83 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Index.cshtml"
WriteAttributeValue("", 3228, item.Id, 3228, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Chi tiết</a></span>\n                        <span class=\"badge bg-danger\"><a");
            BeginWriteAttribute("href", " href=\"", 3314, "\"", 3352, 2);
            WriteAttributeValue("", 3321, "/Admin/Products/Delete/", 3321, 23, true);
#nullable restore
#line 84 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Index.cshtml"
WriteAttributeValue("", 3344, item.Id, 3344, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xóa</a></span>\n                    </td>\n                </tr>\n");
#nullable restore
#line 87 "D:\DOLPHIN-DOLPHIN-ntd\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DOLPHIN.Model.Products>> Html { get; private set; }
    }
}
#pragma warning restore 1591