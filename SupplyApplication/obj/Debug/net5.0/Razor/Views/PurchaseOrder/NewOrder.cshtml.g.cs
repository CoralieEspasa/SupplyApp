#pragma checksum "C:\Users\Coralie Espasa\Pro\Projects\SupplyApp\SupplyApplication\Views\PurchaseOrder\NewOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6c1d455341ddc5ab21c25d101b99dff5925d892"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PurchaseOrder_NewOrder), @"mvc.1.0.view", @"/Views/PurchaseOrder/NewOrder.cshtml")]
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
#line 1 "C:\Users\Coralie Espasa\Pro\Projects\SupplyApp\SupplyApplication\Views\_ViewImports.cshtml"
using SupplyApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Coralie Espasa\Pro\Projects\SupplyApp\SupplyApplication\Views\_ViewImports.cshtml"
using SupplyApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6c1d455341ddc5ab21c25d101b99dff5925d892", @"/Views/PurchaseOrder/NewOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f2197762885a7748b8795eca24f4f98f3ff1347", @"/Views/_ViewImports.cshtml")]
    public class Views_PurchaseOrder_NewOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Supplier>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("NewOrder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Coralie Espasa\Pro\Projects\SupplyApp\SupplyApplication\Views\PurchaseOrder\NewOrder.cshtml"
  
    ViewData["Title"] = "NewOrder";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6c1d455341ddc5ab21c25d101b99dff5925d8924337", async() => {
                WriteLiteral("\r\n            <div class=\"form-group mt-3\">\r\n                <label for=\"Quantity\">ItemReference</label>\r\n                <input type=\"text\" name=\"ItemReference\" id=\"Id\" class=\"form-control rounded\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 410, "\"", 424, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n            <div class=\"form-group mt-3\">\r\n                <label for=\"Quantity\">ItemName</label>\r\n                <input type=\"text\" name=\"ItemName\" id=\"Id\" class=\"form-control rounded\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 634, "\"", 648, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n            <div class=\"form-group mt-3\">\r\n                <label for=\"Quantity\">Quantity</label>\r\n                <input type=\"text\" name=\"Quantity\" id=\"Id\" class=\"form-control rounded\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 858, "\"", 872, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n            <div class=\"form-group mt-3\">\r\n                <label for=\"UnitPrice\">Unit Price</label>\r\n                <input type=\"text\" name=\"UnitPrice\" id=\"UnitPrice\" class=\"form-control rounded\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1093, "\"", 1107, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n            <div class=\"form-group mt-3\">\r\n                <label for=\"Remise\">Discount</label>\r\n                <input type=\"text\" name=\"Remise\" id=\"Remise\" class=\"form-control rounded\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1317, "\"", 1331, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n            <div class=\"form-group mt-3\">\r\n                <label for=\"DeliveryTime\">Delivery Time</label>\r\n                <input type=\"text\" name=\"DeliveryTime\" id=\"DeliveryTime\" class=\"form-control rounded\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1564, "\"", 1578, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n\r\n            <button type=\"submit\" class=\"btn btn-primary\">Add</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Supplier> Html { get; private set; }
    }
}
#pragma warning restore 1591
