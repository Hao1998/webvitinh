#pragma checksum "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Areas\Admin\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88c3f6d71311f5cb1b6a89ea6f2e3a25323e5fd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/User/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/User/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_User_Index))]
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
#line 1 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Areas\Admin\Views\_ViewImports.cshtml"
using webvitinh.Areas.Admin;

#line default
#line hidden
#line 2 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Areas\Admin\Views\_ViewImports.cshtml"
using webvitinh.Areas.Admin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88c3f6d71311f5cb1b6a89ea6f2e3a25323e5fd0", @"/Areas/Admin/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c330a7985887ff74e7fa83f85c24ebfc4df7420", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Model.User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("include", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/Admin/Scripts/jqGrid/grid.locale-en.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/Admin/Scripts/jqGrid/jquery.jqGrid.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Areas\Admin\Views\User\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(116, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("header", async() => {
                BeginContext(133, 15, true);
                WriteLiteral("\n    Test user\n");
                EndContext();
            }
            );
            BeginContext(150, 3563, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("Environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2c2c41031d648b8a26cef7df64d36f4", async() => {
                BeginContext(185, 3514, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $(""#jqGrid"").jqGrid({
                url: ""GetData"",
                // we set the changes to be made at client side using predefined word clientArray
                datatype: ""json"",
                shrinkToFit: false,
                colModel: [
                    { label: 'name', name: 'name', editable: true },
                    { key: true, label: 'id', name: 'id', editable: true },
                    { label: 'username', name: 'username', editable: true },
                    { label: 'password', name: 'password', editable: true },
                    { label: 'email', name: 'email', editable: true },
                    { label: 'address', name: 'address', editable: true },
                    { label: 'status', name: 'status', editable: true },
                ],
                loadonce: true,
                viewrecords: true,
                width: 780,
                height: 350,
                rowNum: 15,
                row");
                WriteLiteral(@"List: [10, 15, 20, 30, 50],
                pager: ""#jqGridPager""
            });
            $('#jqGrid').navGrid('#jqGridPager',
                // the buttons to appear on the toolbar of the grid
                { edit: true, add: true, del: true, search: true, refresh: false, view: false, position: ""left"", cloneToTop: false },
                // options for the Edit Dialog
                {
                    editCaption: ""The Edit Dialog"",
                    url: 'EditUserJson',
                    afterSubmit: function () {
                        $(this).jqGrid(""setGridParam"", { datatype: 'json' });
                        return [true];
                    },
                    beforeSubmit: function (postdata, form, oper) {
                        if (confirm('Are you sure you want to update this row?')) {
                            return [true, ''];
                        } else {
                            return [false, 'You can not submit!'];
                        }
                    }");
                WriteLiteral(@",
                    closeAfterEdit: true,
                    errorTextFormat: function (data) {
                        return 'Error: ' + data.responseText
                    }
                },
                // options for the Add Dialog
                {
                    url: ""AddUserJson"",
                    afterSubmit: function () {
                        $(this).jqGrid(""setGridParam"", {
                            datatype: 'json'
                        });
                        return [true];
                    },
                    closeAfterAdd: true,
                },
                // options for the Delete Dailog
                {
                    url: ""DeleteUserJson"",
                    beforeSubmit: function (postdata, form, oper) {
                        if (confirm('Are you wanna delete?')) {

                            return [true, ''];
                        } else {
                            return [false, 'You can not delete!'];
                        }
    ");
                WriteLiteral(@"                },
                    afterSubmit: function () {
                        $(this).jqGrid(""setGridParam"", {
                            datatype: 'json'
                        });
                        return [true];
                    },
                    errorTextFormat: function (data) {
                        return 'Error: ' + data.responseText
                    }
                });
        });
    </script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Include = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3713, 3, true);
            WriteLiteral("\n\n\n");
            EndContext();
            DefineSection("jsFooter", async() => {
                BeginContext(3734, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(3739, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8ee55a6cddd486bb7fac529bdde69e2", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3809, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(3814, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ea0aac09383449c95269606c9752cc1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3883, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            BeginContext(3886, 131, true);
            WriteLiteral("\n<table id=\"jqGrid\" align=\"center\"></table>\n<div id=\"jqGridPager\"></div>\n<!--<input id=\"btn\" type=\"button\" value=\"Load data\" />-->\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Model.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
