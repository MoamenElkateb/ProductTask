#pragma checksum "F:\SmartTechTask\ConsumingProductAPI\ConsumAPiProduct\Views\Product\ViewProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28f67bfc2073d4a057802cf7f0b7002460ddca9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ViewProduct), @"mvc.1.0.view", @"/Views/Product/ViewProduct.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/ViewProduct.cshtml", typeof(AspNetCore.Views_Product_ViewProduct))]
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
#line 1 "F:\SmartTechTask\ConsumingProductAPI\ConsumAPiProduct\Views\_ViewImports.cshtml"
using ConsumAPiProduct;

#line default
#line hidden
#line 2 "F:\SmartTechTask\ConsumingProductAPI\ConsumAPiProduct\Views\_ViewImports.cshtml"
using ConsumAPiProduct.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28f67bfc2073d4a057802cf7f0b7002460ddca9d", @"/Views/Product/ViewProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d547e64361f764e7228f61631da05d6ad3f786d", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ViewProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConsumAPiProduct.Models.ProductModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\SmartTechTask\ConsumingProductAPI\ConsumAPiProduct\Views\Product\ViewProduct.cshtml"
  
    ViewData["Title"] = "ViewProduct";

#line default
#line hidden
            BeginContext(94, 234, true);
            WriteLiteral("<style>\r\n    /*.row {\r\n         height:10%;\r\n    }*/\r\n</style>\r\n<h2 style=\"text-align:center\">View Product</h2>\r\n<br />\r\n<br />\r\n<div class=\"card\" style=\"width: 50rem;  white-space: nowrap; margin:auto\">\r\n    <img class=\"card-img-top\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 328, "\"", 346, 1);
#line 15 "F:\SmartTechTask\ConsumingProductAPI\ConsumAPiProduct\Views\Product\ViewProduct.cshtml"
WriteAttributeValue("", 334, Model.Photo, 334, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(347, 53, true);
            WriteLiteral(" alt=\"Card image cap\">\r\n    <div class=\"card-body\">\r\n");
            EndContext();
            BeginContext(502, 137, true);
            WriteLiteral("        <label class=\"col-lg-7 control-label text-bold \">Product Name</label>\r\n\r\n        <label class=\"col-lg-4 control-label card-text\">");
            EndContext();
            BeginContext(640, 17, false);
#line 20 "F:\SmartTechTask\ConsumingProductAPI\ConsumAPiProduct\Views\Product\ViewProduct.cshtml"
                                                   Write(Model.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(657, 145, true);
            WriteLiteral("</label>\r\n        <label class=\"col-lg-7 control-label text-bold \">Product ID</label>\r\n\r\n        <label class=\"col-lg-4 control-label card-text\">");
            EndContext();
            BeginContext(803, 15, false);
#line 23 "F:\SmartTechTask\ConsumingProductAPI\ConsumAPiProduct\Views\Product\ViewProduct.cshtml"
                                                   Write(Model.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(818, 150, true);
            WriteLiteral("</label>\r\n\r\n        <label class=\"col-lg-7 control-label text-bold \">Product Price</label>\r\n\r\n        <label class=\"col-lg-4 control-label card-text\">");
            EndContext();
            BeginContext(969, 11, false);
#line 27 "F:\SmartTechTask\ConsumingProductAPI\ConsumAPiProduct\Views\Product\ViewProduct.cshtml"
                                                   Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(980, 136, true);
            WriteLiteral("</label>\r\n        <label class=\"col-lg-7 control-label text-bold \">Last Updated</label>\r\n        <label class=\" col-lg-4 control-label\">");
            EndContext();
            BeginContext(1117, 17, false);
#line 29 "F:\SmartTechTask\ConsumingProductAPI\ConsumAPiProduct\Views\Product\ViewProduct.cshtml"
                                          Write(Model.LastUpdated);

#line default
#line hidden
            EndContext();
            BeginContext(1134, 43, true);
            WriteLiteral("</label>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1177, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2f1cca97cdc4e3fb83428cbbb4239be", async() => {
                BeginContext(1199, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1215, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConsumAPiProduct.Models.ProductModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
