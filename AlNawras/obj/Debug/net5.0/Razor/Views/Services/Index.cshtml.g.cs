#pragma checksum "C:\Users\ymg12\OneDrive\Desktop\AlNawras\AlNawras\Views\Services\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32d21561bd91af86b0451cf0abcc796a4ac90b6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Services_Index), @"mvc.1.0.view", @"/Views/Services/Index.cshtml")]
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
#line 1 "C:\Users\ymg12\OneDrive\Desktop\AlNawras\AlNawras\Views\_ViewImports.cshtml"
using AlNawras;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ymg12\OneDrive\Desktop\AlNawras\AlNawras\Views\_ViewImports.cshtml"
using AlNawras.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32d21561bd91af86b0451cf0abcc796a4ac90b6a", @"/Views/Services/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"916496eb222ff56391d85f5aab2884b305605ddf", @"/Views/_ViewImports.cshtml")]
    public class Views_Services_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AlNawras.Dtos.ServiceList>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ymg12\OneDrive\Desktop\AlNawras\AlNawras\Views\Services\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Page Header Start -->
<div class=""page-header"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <h2>Our Projects</h2>
            </div>
            <div class=""col-12"">
                <a href=""/Home/Index"">Home</a>
                <a");
            BeginWriteAttribute("href", " href=\"", 396, "\"", 403, 0);
            EndWriteAttribute();
            WriteLiteral(">List Of Projects</a>\r\n                <p>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32d21561bd91af86b0451cf0abcc796a4ac90b6a4149", async() => {
                WriteLiteral("create new");
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
            WriteLiteral(@"
                </p>
            </div>
        </div>
    </div>
</div>


<div id=""content"">

    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""heading"">
                    <h2>
                        Company Overview
                    </h2>
                </div>
                <p class=""lead"">
                    The company has successfully completed more than 900 projects across the country within the last 15 years.

                    Below is a list of Key Projects completed.

                </p>
            </div>
        </div>
        <table class=""table table-hover "">
            <thead class=""thead-dark"">
                <tr style=""background-color: #212529 !important; border-color: #4fbfa8 !important;"">
                    <th style=""        background-color: #212529 !important;
        border-color: #212529 !important;"">
                        Sr.
                    </th>
              ");
            WriteLiteral("      <th style=\"        background-color: #212529 !important;\r\n        border-color: #212529 !important;\">\r\n                        ");
#nullable restore
#line 53 "C:\Users\ymg12\OneDrive\Desktop\AlNawras\AlNawras\Views\Services\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Ref));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th style=\"        background-color: #212529 !important;\r\n        border-color: #212529 !important;\">\r\n                        ");
#nullable restore
#line 57 "C:\Users\ymg12\OneDrive\Desktop\AlNawras\AlNawras\Views\Services\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Contractors));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th style=\"        background-color: #212529 !important;\r\n        border-color: #212529 !important;\">\r\n                        ");
#nullable restore
#line 61 "C:\Users\ymg12\OneDrive\Desktop\AlNawras\AlNawras\Views\Services\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ProjectName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th style=\"        background-color: #212529 !important;\r\n        border-color: #212529 !important;\">\r\n                        ");
#nullable restore
#line 65 "C:\Users\ymg12\OneDrive\Desktop\AlNawras\AlNawras\Views\Services\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Consultant));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th style=\"        background-color: #212529 !important;\r\n        border-color: #212529 !important;\">\r\n                        ");
#nullable restore
#line 69 "C:\Users\ymg12\OneDrive\Desktop\AlNawras\AlNawras\Views\Services\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ContValue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th style=\"        background-color: #212529 !important;\r\n        border-color: #212529 !important;\"></th>\r\n                </tr>\r\n            </thead>\r\n\r\n            <tbody>\r\n");
#nullable restore
#line 77 "C:\Users\ymg12\OneDrive\Desktop\AlNawras\AlNawras\Views\Services\Index.cshtml"
                   int RowNo = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\ymg12\OneDrive\Desktop\AlNawras\AlNawras\Views\Services\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n");
#nullable restore
#line 82 "C:\Users\ymg12\OneDrive\Desktop\AlNawras\AlNawras\Views\Services\Index.cshtml"
                              RowNo++;

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 82 "C:\Users\ymg12\OneDrive\Desktop\AlNawras\AlNawras\Views\Services\Index.cshtml"
                                   Write(RowNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 85 "C:\Users\ymg12\OneDrive\Desktop\AlNawras\AlNawras\Views\Services\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Ref));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 88 "C:\Users\ymg12\OneDrive\Desktop\AlNawras\AlNawras\Views\Services\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Contractors));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\" width: 300px !important;\">\r\n                            ");
#nullable restore
#line 91 "C:\Users\ymg12\OneDrive\Desktop\AlNawras\AlNawras\Views\Services\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ProjectName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 94 "C:\Users\ymg12\OneDrive\Desktop\AlNawras\AlNawras\Views\Services\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Consultant));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 97 "C:\Users\ymg12\OneDrive\Desktop\AlNawras\AlNawras\Views\Services\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ContValue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
            WriteLiteral("                    </tr>\r\n");
#nullable restore
#line 105 "C:\Users\ymg12\OneDrive\Desktop\AlNawras\AlNawras\Views\Services\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
        <div class=""row"">
            <div class=""col-12"">
                <ul class=""pagination justify-content-center"">
                    <li class=""page-item disabled""><a class=""page-link"" href=""#"">Previous</a></li>
                    <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
              
                    <li class=""page-item""><a class=""page-link"" href=""#"">Next</a></li>
                </ul>
            </div>
        </div>

");
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AlNawras.Dtos.ServiceList>> Html { get; private set; }
    }
}
#pragma warning restore 1591