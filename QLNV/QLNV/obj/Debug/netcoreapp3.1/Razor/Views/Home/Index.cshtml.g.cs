#pragma checksum "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a39c343a1090063916c4bffb54a2fbd76464a23"
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
#line 7 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Home\Index.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a39c343a1090063916c4bffb54a2fbd76464a23", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QLNV.Models.NhanvienViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Click để xem cv"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("view"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
    * {
        margin: 0;
        padding: 0px;
        font-family: ""Helvetica"";
    }
    body{
        margin:0 20px;
    }
    table {
        width: 100%;
        border-collapse: collapse;
        margin-top:20px;
    }

    th, td {
        padding: 8px;
        border: 1px solid #dee2e6;
    }
    tr:first-child {
        background: #212529;
        color:white;
    }

    th {
        height: 40px;
        text-align: left;
    }
    a{
        text-decoration:none;
        color:#000;
    }
    .header{
        display:flex;
        justify-content:space-between;
    }
    .search{

    }
    .search input{

    }
    .search a{
    }
    .header{
        margin-top:10px;
        display:flex;
        height:38px;
        align-items:center;
    }
    .search_header{
        display:flex;
    }
        .search_header .btn_search {
            background-color: #4e92df;
            border: none;
            color: white;
            t");
            WriteLiteral(@"ext-align: center;
            text-decoration: none;
            font-size: 16px;
            margin: 4px 2px;
            cursor: pointer;
            height:100%;
            margin:0;
            padding:10px 20px;
        }

        .search_header input:first-child {
            width: 200px;
            margin-right: 10px;
            outline: none;
            padding-left: 10px;
            border: 1px solid #4e92df;
        }
    .link_btn {
        background-color: #4e92df;
        font-size: 16px;
        color: white;
        padding: 10px 20px;
        border-radius:2px;
    }
    .btn_search:hover {
        background: #2e7dd6;
        transition: 0,4s;
    }
    .link_btn:hover {
        background: #2e7dd6;
        transition:0,4s;
    }
    .dowload{
    }
    .view:hover {
        color: #2e7dd6;
    }
</style>


");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a39c343a1090063916c4bffb54a2fbd76464a235533", async() => {
                WriteLiteral(@"
    <div class=""header"">
        <a class=""link_btn"" style=""font-size:16px;"" href=""/Home/Create"">Thêm Mới</a>

        <form class=""search_header"" asp-controller=""Home"" asp-action=""Index"" method=""Get"">
            <input placeholder=""Nhập tên nhân viên""");
                BeginWriteAttribute("class", " class=\"", 2373, "\"", 2381, 0);
                EndWriteAttribute();
                WriteLiteral(@" type=""text"" name=""search"" />
            <input class=""btn_search"" type=""submit"" value=""Tìm Kiếm"" />
        </form>
    </div>


    <table>
        <tr>
            <th>ID</th>
            <th>Tên chức vụ</th>
            <th>Tên vị trí</th>
            <th>Tên NV</th>
            <th>Ngày sinh</th>
            <th>Địa chỉ</th>
            <th>Email</th>
            <th>CV</th>
            <th>Người Giới thiệu</th>
            <th>Hành động</th>

        </tr>


");
#nullable restore
#line 132 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 135 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Home\Index.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 136 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Home\Index.cshtml"
               Write(item.Tenchucvu);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 137 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Home\Index.cshtml"
               Write(item.Tenvitri);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 138 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Home\Index.cshtml"
               Write(item.Ten);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 139 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Home\Index.cshtml"
               Write(item.Ngaysinhh);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 140 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Home\Index.cshtml"
               Write(item.Diachi);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 141 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Home\Index.cshtml"
               Write(item.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 143 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Home\Index.cshtml"
                     if (item.CV != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 145 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Home\Index.cshtml"
                         if (item.CV.Split(".").Last() == "pdf")
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a39c343a1090063916c4bffb54a2fbd76464a239328", async() => {
#nullable restore
#line 147 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Home\Index.cshtml"
                                                                                         Write(item.CV);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3469, "~/uploads/", 3469, 10, true);
#nullable restore
#line 147 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3479, item.CV, 3479, 8, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 148 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Home\Index.cshtml"
                        }
                        else
                        {
                            var a = item.CV.Split(".").Last();

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <a title=\"Click để tải cv\" class=\"view \"");
                BeginWriteAttribute("href", " href=\"", 3719, "\"", 3751, 2);
                WriteAttributeValue("", 3726, "Home/Dowloadfile/", 3726, 17, true);
#nullable restore
#line 152 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Home\Index.cshtml"
WriteAttributeValue("", 3743, item.CV, 3743, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 152 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Home\Index.cshtml"
                                                                                                 Write(item.CV);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 153 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 153 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Home\Index.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                </td>\r\n                <td>");
#nullable restore
#line 158 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Home\Index.cshtml"
               Write(item.Nguoigioithieu);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>\r\n                    <a class=\"xoabnt\"");
                BeginWriteAttribute("onclick", " onclick=\"", 3950, "\"", 3978, 3);
                WriteAttributeValue("", 3960, "deletenv(", 3960, 9, true);
#nullable restore
#line 160 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Home\Index.cshtml"
WriteAttributeValue("", 3969, item.Id, 3969, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3977, ")", 3977, 1, true);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 3979, "\"", 3992, 1);
#nullable restore
#line 160 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Home\Index.cshtml"
WriteAttributeValue("", 3984, item.Id, 3984, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("href", " href=\"", 3993, "\"", 4018, 2);
                WriteAttributeValue("", 4000, "Home/Edit/", 4000, 10, true);
#nullable restore
#line 160 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Home\Index.cshtml"
WriteAttributeValue("", 4010, item.Id, 4010, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Sửa</a>\r\n                    <a href=\"#\"");
                BeginWriteAttribute("id", " id=\"", 4060, "\"", 4073, 1);
#nullable restore
#line 161 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Home\Index.cshtml"
WriteAttributeValue("", 4065, item.Id, 4065, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("onclick", " onclick=\"", 4074, "\"", 4107, 3);
                WriteAttributeValue("", 4084, "deleteconfirm(", 4084, 14, true);
#nullable restore
#line 161 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Home\Index.cshtml"
WriteAttributeValue("", 4098, item.Id, 4098, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4106, ")", 4106, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Xóa</a>\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 165 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>

    function deleteconfirm(id) {
        var url = ""/Home/Delete/"" + id + """"
        fetch(url, {
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            method: ""POST"",
            body: JSON.stringify({ id })
        }).then(response => response.json())
            .then(function (data) {
                var obj = JSON.parse(JSON.stringify(data))
                if (obj.mes == ""thanh cong"") {
                    var item = document.getElementById(id);
                    var action = item.parentElement;
                    var tr = action.parentElement;
                    tr.style.display = 'none';
                    alert(""thanh cong"");
                }
                else {
                    alert('that bai')
                }
                
            })
    }
    function deleteRow(btn) {
        var row = btn.parentNode
        row.parentNode.removeChild(row);
  ");
            WriteLiteral("  }\r\n\r\n    var trElement = document.getElementsByTagName(\'tr\')\r\n    for (var i = 1; i < trElement.length; i++) {\r\n        if (i % 2 == 0) {\r\n            trElement[i].style.background = \"#dee2e6\";\r\n        }\r\n    }\r\n\r\n  \r\n</script>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QLNV.Models.NhanvienViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591