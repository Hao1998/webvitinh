#pragma checksum "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Cart\PayPalCheckOut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a7e493b42c25639dc54f899443e21c9f907eaf8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_PayPalCheckOut), @"mvc.1.0.view", @"/Views/Cart/PayPalCheckOut.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/PayPalCheckOut.cshtml", typeof(AspNetCore.Views_Cart_PayPalCheckOut))]
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
#line 1 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\_ViewImports.cshtml"
using webvitinh;

#line default
#line hidden
#line 2 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\_ViewImports.cshtml"
using webvitinh.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a7e493b42c25639dc54f899443e21c9f907eaf8", @"/Views/Cart/PayPalCheckOut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c0e9901c95d01e438f2a6ec526ade9ddfb89b41", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_PayPalCheckOut : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<webvitinh.Models.CartItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("https://www.sandbox.paypal.com/cgi-bin/webscr"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Cart\PayPalCheckOut.cshtml"
  
    ViewBag.Title = "Payment Paypal";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(133, 33, true);
            WriteLiteral("\r\n<div class=\"content\">\r\n        ");
            EndContext();
            BeginContext(166, 1069, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0051c3050b444ffa9328389d7b12de1a", async() => {
                BeginContext(227, 301, true);
                WriteLiteral(@"
            <input type=""hidden"" name=""cmd"" value=""_cart"" />
            <input type=""hidden"" name=""upload"" value=""1"" />
            <input type=""hidden"" name=""return"" value=""http://localhost:44371/get-paypal"" />
            <input type=""hidden"" name=""business"" value=""tonynetn142@gmail.com"" />
");
                EndContext();
#line 13 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Cart\PayPalCheckOut.cshtml"
             for (int i = 0; i < Model.Count; i++)
            {

#line default
#line hidden
                BeginContext(595, 32, true);
                WriteLiteral("            <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 627, "\"", 666, 1);
#line 15 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Cart\PayPalCheckOut.cshtml"
WriteAttributeValue("", 634, Url.Content("item_name_"+(i+1)), 634, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 667, "\"", 697, 1);
#line 15 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Cart\PayPalCheckOut.cshtml"
WriteAttributeValue("", 675, Model[i].Product.Name, 675, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(698, 37, true);
                WriteLiteral(" />\r\n            <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 735, "\"", 776, 1);
#line 16 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Cart\PayPalCheckOut.cshtml"
WriteAttributeValue("", 742, Url.Content("item_number_"+(i+1)), 742, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 777, "\"", 805, 1);
#line 16 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Cart\PayPalCheckOut.cshtml"
WriteAttributeValue("", 785, Model[i].Product.Id, 785, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(806, 37, true);
                WriteLiteral(" />\r\n            <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 843, "\"", 879, 1);
#line 17 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Cart\PayPalCheckOut.cshtml"
WriteAttributeValue("", 850, Url.Content("amount_"+(i+1)), 850, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 880, "\"", 919, 1);
#line 17 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Cart\PayPalCheckOut.cshtml"
WriteAttributeValue("", 888, Model[i].Product.Price/22500, 888, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(920, 37, true);
                WriteLiteral(" />\r\n            <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 957, "\"", 999, 1);
#line 18 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Cart\PayPalCheckOut.cshtml"
WriteAttributeValue("", 964, Url.Content("quantity_" + (i + 1)), 964, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1000, "\"", 1026, 1);
#line 18 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Cart\PayPalCheckOut.cshtml"
WriteAttributeValue("", 1008, Model[i].Quantity, 1008, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1027, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
#line 19 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Cart\PayPalCheckOut.cshtml"
            }

#line default
#line hidden
                BeginContext(1047, 181, true);
                WriteLiteral("            <br />\r\n            <div class=\"col-md-12\">\r\n                <input type=\"submit\" value=\"Checkout Now\" class=\"btn btn-primary col-md-12\" />\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1235, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<webvitinh.Models.CartItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
