#pragma checksum "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Duyet\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3fbcdc312e80c5a8abbfd049fd36edc46e17a33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Duyet_Index), @"mvc.1.0.view", @"/Views/Duyet/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3fbcdc312e80c5a8abbfd049fd36edc46e17a33", @"/Views/Duyet/Index.cshtml")]
    public class Views_Duyet_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QLNV.Viewmodels.DuyetNhanVienViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Bootsrap/bootstrap-4.0.0/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ViewPDF"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Bootsrap/bootstrap-4.0.0/dist/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3fbcdc312e80c5a8abbfd049fd36edc46e17a334739", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c3fbcdc312e80c5a8abbfd049fd36edc46e17a335035", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <style type=""text/css"">
    </style>

    <style>
        * {
            margin: 0;
            padding: 0px;
            font-family: ""Helvetica"";
        }

        body {
            margin: 0 20px;
        }

        table {
            width: 100%;
            border-collapse: collapse;
            margin-top: 20px;
        }

        th, td {
            padding: 8px;
            border: 1px solid #dee2e6;
        }

        tr:first-child {
            background: #212529;
            color: white;
        }

        th {
            height: 40px;
            text-align: left;
        }

        a {
            text-decoration: none;
            color: #000;
        }

        .header {
            display: flex;
            justify-content: space-between;
        }

        .search {
        }

            .search input {
            }

            .search a {
            }

        .header {
            margin-top: 10px;
            displ");
                WriteLiteral(@"ay: flex;
            height: 38px;
            align-items: center;
        }

        .search_header {
            display: flex;
        }

            .search_header .btn_search {
                background-color: #4e92df;
                border: none;
                color: white;
                text-align: center;
                text-decoration: none;
                font-size: 16px;
                margin: 4px 2px;
                cursor: pointer;
                height: 100%;
                margin: 0;
                padding: 10px 20px;
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
            border-radius: 2px;
  ");
                WriteLiteral(@"      }

        .btn_search:hover {
            background: #2e7dd6;
            transition: 0,4s;
        }

        .link_btn:hover {
            background: #2e7dd6;
            transition: 0,4s;
        }

        .dowload {
        }

        .view:hover {
            color: #2e7dd6;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3fbcdc312e80c5a8abbfd049fd36edc46e17a339371", async() => {
                WriteLiteral("\r\n\r\n\r\n    <div class=\"header\">\r\n\r\n        <form class=\"search_header\" asp-controller=\"Duyet\" asp-action=\"Index\" method=\"Get\">\r\n            <input placeholder=\"Nhập tên nhân viên\"");
                BeginWriteAttribute("class", " class=\"", 2929, "\"", 2937, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"text\" name=\"search\" />\r\n\r\n            <div class=\"filter_item\">\r\n                <label>Vị trí</label>\r\n                <select name=\"vitri\">\r\n                    <option value=\"0\">Chọn Vị trí</option>\r\n");
#nullable restore
#line 138 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Duyet\Index.cshtml"
                     foreach (var item in ViewBag.VitriSearch)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <option");
                BeginWriteAttribute("value", " value=\"", 3266, "\"", 3282, 1);
#nullable restore
#line 140 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Duyet\Index.cshtml"
WriteAttributeValue("", 3274, item.Id, 3274, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 140 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Duyet\Index.cshtml"
                                            Write(item.Tenvitri);

#line default
#line hidden
#nullable disable
                WriteLiteral("</option>\r\n");
#nullable restore
#line 141 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Duyet\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </select>\r\n            </div>\r\n\r\n            <div class=\"filter_item\">\r\n                <label>Chức vụ</label>\r\n                <select name=\"chucvu\">\r\n                    <option value=\"0\">Chọn chức vụ</option>\r\n");
#nullable restore
#line 149 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Duyet\Index.cshtml"
                     foreach (var item in ViewBag.ChucvuSearch)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <option");
                BeginWriteAttribute("value", " value=\"", 3680, "\"", 3696, 1);
#nullable restore
#line 151 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Duyet\Index.cshtml"
WriteAttributeValue("", 3688, item.Id, 3688, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 151 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Duyet\Index.cshtml"
                                            Write(item.Tenchucvu);

#line default
#line hidden
#nullable disable
                WriteLiteral("</option>\r\n");
#nullable restore
#line 152 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Duyet\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </select>
            </div>
            <input class=""btn_search"" type=""submit"" value=""Tìm Kiếm"" />
        </form>
        <div class=""filter"">
            
        </div>
    </div>


    <table>
        <tr>
            <th>ID</th>
            <th>Tên chức vụ</th>
            <th>Tên vị trí</th>
            <th>Tên NV</th>
            <th>Ngày sinh</th>
            <th>Địa chỉ</th>
            <th>Người Giới thiệu</th>
            <th>Hành động</th>

        </tr>


");
#nullable restore
#line 177 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Duyet\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 180 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Duyet\Index.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 181 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Duyet\Index.cshtml"
               Write(item.Tenchucvu);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 182 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Duyet\Index.cshtml"
               Write(item.Tenvitri);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 183 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Duyet\Index.cshtml"
               Write(item.Ten);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 184 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Duyet\Index.cshtml"
               Write(item.Ngaysinhh);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 185 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Duyet\Index.cshtml"
               Write(item.Diachi);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 186 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Duyet\Index.cshtml"
               Write(item.Nguoigioithieu);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>\r\n                    <a class=\"xoabnt\"");
                BeginWriteAttribute("onclick", " onclick=\"", 4670, "\"", 4698, 3);
                WriteAttributeValue("", 4680, "deletenv(", 4680, 9, true);
#nullable restore
#line 188 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Duyet\Index.cshtml"
WriteAttributeValue("", 4689, item.Id, 4689, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4697, ")", 4697, 1, true);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 4699, "\"", 4712, 1);
#nullable restore
#line 188 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Duyet\Index.cshtml"
WriteAttributeValue("", 4704, item.Id, 4704, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("href", " href=\"", 4713, "\"", 4738, 2);
                WriteAttributeValue("", 4720, "Home/Edit/", 4720, 10, true);
#nullable restore
#line 188 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Duyet\Index.cshtml"
WriteAttributeValue("", 4730, item.Id, 4730, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Sửa</a>\r\n                    <a href=\"#\"");
                BeginWriteAttribute("id", " id=\"", 4780, "\"", 4793, 1);
#nullable restore
#line 189 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Duyet\Index.cshtml"
WriteAttributeValue("", 4785, item.Id, 4785, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("onclick", " onclick=\"", 4794, "\"", 4827, 3);
                WriteAttributeValue("", 4804, "deleteconfirm(", 4804, 14, true);
#nullable restore
#line 189 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Duyet\Index.cshtml"
WriteAttributeValue("", 4818, item.Id, 4818, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4826, ")", 4826, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Xóa</a>\r\n                </td>\r\n\r\n                <td>\r\n");
#nullable restore
#line 193 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Duyet\Index.cshtml"
                     if (item.CV != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 195 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Duyet\Index.cshtml"
                         if (item.CV.Split(".").Last() == "pdf")
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <a title=\"Click để xem cv\"");
                BeginWriteAttribute("id", " id=\"", 5098, "\"", 5120, 2);
                WriteAttributeValue("", 5103, "bntduyet_", 5103, 9, true);
#nullable restore
#line 197 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Duyet\Index.cshtml"
WriteAttributeValue("", 5112, item.Id, 5112, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("onclick", " onclick=\"", 5121, "\"", 5147, 3);
                WriteAttributeValue("", 5131, "redPDF(", 5131, 7, true);
#nullable restore
#line 197 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Duyet\Index.cshtml"
WriteAttributeValue("", 5138, item.Id, 5138, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5146, ")", 5146, 1, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary\" data-toggle=\"modal\" data-book-id=\"");
#nullable restore
#line 197 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Duyet\Index.cshtml"
                                                                                                                                                              Write(item.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" data-pdf=\"");
#nullable restore
#line 197 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Duyet\Index.cshtml"
                                                                                                                                                                                  Write(item.CV);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" data-target=\"#exampleModal\">XemCV</a>\r\n");
                WriteLiteral(@"                            <div id=""ModalPDF"">


                                <!-- Modal -->
                                <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                                    <div class=""modal-dialog"" role=""document"">
                                        <div class=""modal-content"">
                                            <div class=""modal-header"">
                                                <h5 class=""modal-title"" id=""exampleModalLabel"">Modal title</h5>
                                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                                    <span aria-hidden=""true"">&times;</span>
                                                </button>
                                            </div>
                                            <div class=""modal-body"">
                              ");
                WriteLiteral("                  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("embed", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c3fbcdc312e80c5a8abbfd049fd36edc46e17a3321118", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 6345, "~/uploads/", 6345, 10, true);
#nullable restore
#line 213 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Duyet\Index.cshtml"
AddHtmlAttributeValue("", 6355, item.CV, 6355, 8, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            </div>\r\n                                            <div class=\"modal-footer\">\r\n                                                <button type=\"button\"");
                BeginWriteAttribute("id", " id=\"", 6576, "\"", 6593, 2);
                WriteAttributeValue("", 6581, "btn_", 6581, 4, true);
#nullable restore
#line 216 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Duyet\Index.cshtml"
WriteAttributeValue("", 6585, item.Id, 6585, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" onclick=""loaiungvien()"" class=""btn btn-secondary"" data-dismiss=""modal"">Loại</button>
                                                <button onclick=""duyetungvien()"" type=""button"" class=""btn btn-primary"">Duyệt</button>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
");
#nullable restore
#line 223 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Duyet\Index.cshtml"
                        }
                        else
                        {
                            var a = item.CV.Split(".").Last();

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <a title=\"Click để tải cv\" class=\"view \"");
                BeginWriteAttribute("href", " href=\"", 7252, "\"", 7284, 2);
                WriteAttributeValue("", 7259, "Home/Dowloadfile/", 7259, 17, true);
#nullable restore
#line 227 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Duyet\Index.cshtml"
WriteAttributeValue("", 7276, item.CV, 7276, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Tải CV</a>\r\n");
#nullable restore
#line 228 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Duyet\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 228 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Duyet\Index.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 234 "C:\Users\PhongNV\Documents\Phong\SSV\QLNV\QLNV\Views\Duyet\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </table>\r\n\r\n\r\n    <script src=\"https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js\"></script>\r\n    <!-- Include all compiled plugins (below), or include individual files as needed -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3fbcdc312e80c5a8abbfd049fd36edc46e17a3325684", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
</html>
<script>
    var ID = 0;
    $('#exampleModal').on('show.bs.modal', function (e) {
        ID = $(e.relatedTarget).data('book-id');
        var filePDF = $(e.relatedTarget).data('pdf');
        console.log(filePDF)
        document.getElementById(""ViewPDF"").style.src = ""~/uploads/"" + filePDF;
    });

    function redPDF(id) {
        var dataPDF=
        var modalPDF = document.getElementById(""ModalPDF"");
        console.log(id)
        console.log(modalPDF);
        console.log(this.getAttribute('data-pdf'));
        string html = `<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                                    <div class=""modal-dialog"" role=""document"">
                                        <div class=""modal-content"">
                                            <div class=""modal-header"">
                                                <h5 class=""modal-title"" id=""exampleModalLabel"">Modal title</h5");
            WriteLiteral(@">
                                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                                    <span aria-hidden=""true"">&times;</span>
                                                </button>
                                            </div>
                                            <div class=""modal-body"">
                                                <embed id=""ViewPDF"" src=""~/uploads/"" class=""w-100"" />
                                            </div>
                                            <div class=""modal-footer"">
                                                <button type=""button"" id=""btn_${id}"" onclick=""loaiungvien()"" class=""btn btn-secondary"" data-dismiss=""modal"">Loại</button>
                                                <button onclick=""duyetungvien()"" type=""button"" class=""btn btn-primary"">Duyệt</button>
                                            </div>
                                    ");
            WriteLiteral(@"    </div>
                                    </div>
                                </div>
                    `;
        modalPDF.innerHTML = html;
    }

    var baseUrl = ""/Duyet/Duyet/"";
    function duyetungvien() {
        fetch(baseUrl + """" + ID + """")
            .then(response => response.json())
            .then(function (data) {
                var obj = JSON.parse(JSON.stringify(data))
                console.log(obj.mes)
                if (obj.mes == ""thanh cong"") {
                    var btnduyet = document.getElementById(""bntduyet_""+ + ID + """");

                    var action = btnduyet.parentElement;
                    var tr = action.parentElement;
                    tr.style.display = 'none';
                    alert(""thanh cong"");
                }
            })
    }

    function loaiungvien() {
        var baseurl =""/Duyet/Loai/""
        fetch(baseurl + """" + ID + """")
            .then(response => response.json())
            .then(function (data) {
");
            WriteLiteral(@"                var obj = JSON.parse(JSON.stringify(data))
                console.log(obj.mes)
                if (obj.mes == ""thanh cong"") {
                    var btnduyet = document.getElementById(""bntduyet_"" + + ID + """");

                    var action = btnduyet.parentElement;
                    var tr = action.parentElement;
                    tr.style.display = 'none';
                    alert(""thanh cong"");
                }
            })
    }


</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QLNV.Viewmodels.DuyetNhanVienViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591