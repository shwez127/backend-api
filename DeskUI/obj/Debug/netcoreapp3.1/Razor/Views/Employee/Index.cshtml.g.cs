#pragma checksum "C:\Users\shwetha.b\Desktop\thu-aks-deskify\New-Deskify\Deskify_3.1\DeskUI\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbec8b76d7d233a94f3345bcd707c159b1266c76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
#line 1 "C:\Users\shwetha.b\Desktop\thu-aks-deskify\New-Deskify\Deskify_3.1\DeskUI\Views\_ViewImports.cshtml"
using DeskUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\shwetha.b\Desktop\thu-aks-deskify\New-Deskify\Deskify_3.1\DeskUI\Views\_ViewImports.cshtml"
using DeskUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbec8b76d7d233a94f3345bcd707c159b1266c76", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d8cdb277b9c163ebed098cdd742e1e39fe3be15", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DeskEntity.Model.Employee>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark btn-lg me-3 mt-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BookingSeat", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size:x-large"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark btn-lg mt-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BookingRoom", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\shwetha.b\Desktop\thu-aks-deskify\New-Deskify\Deskify_3.1\DeskUI\Views\Employee\Index.cshtml"
  
    Layout = "~/Views/Shared/_EmployeeLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbec8b76d7d233a94f3345bcd707c159b1266c765811", async() => {
                WriteLiteral(@"
  <meta charset=""utf-8"" />
  <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"" />
  <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"" />
  <meta name=""description"" content=""Responsive Admin &amp; Dashboard Template based on Bootstrap 5"" />
  <meta name=""author"" content=""AdminKit"" />
  <link href=""css/site1.css"" rel=""stylesheet"" />
  <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha2/dist/css/bootstrap.min.css"" rel=""stylesheet""
    integrity=""sha384-aFq/bzH65dt+w6FI2ooMVUpc+21e0SRygnTpmBvdBgSdnuTN7QbdgL+OapgHtvPp"" crossorigin=""anonymous"" />
  <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha2/dist/js/bootstrap.bundle.min.js""
    integrity=""sha384-qKXV1j0HvMUeCBQ+QVp7JcfGl760yU08IQ+GpUo5hlbpg51QRiuqHAJz8+BrxE/N""
    crossorigin=""anonymous""></script>
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbec8b76d7d233a94f3345bcd707c159b1266c767651", async() => {
                WriteLiteral(@"
<div>
  <div class=""modal fade"" id=""approved"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" id=""myModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel""
      aria-hidden=""true"">
      <div class=""modal-content"">
        <div class=""modal-header"">
          <h1 class=""modal-title fs-5"" id=""exampleModalLabel"">Approved</h1>
          <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
        </div>
        <div class=""modal-body"">
          Approved
        </div>
        <div class=""modal-footer"">
          <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Close</button>

        </div>
      </div>
    </div>
  </div>

  <div class=""modal fade"" id=""pending"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" id=""myModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel""
      a");
                WriteLiteral(@"ria-hidden=""true"">
      <div class=""modal-content"">
        <div class=""modal-header"">
          <h1 class=""modal-title fs-5"" id=""exampleModalLabel"">Pending</h1>
          <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
        </div>
        <div class=""modal-body"">
          Pending
        </div>
        <div class=""modal-footer"">
          <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Close</button>

        </div>
      </div>
    </div>
  </div>

  <div class=""modal fade"" id=""rejected"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" id=""myModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel""
      aria-hidden=""true"">
      <div class=""modal-content"">
        <div class=""modal-header"">
          <h1 class=""modal-title fs-5"" id=""exampleModalLabel"">Rejected</h1>
          <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" ar");
                WriteLiteral(@"ia-label=""Close""></button>
        </div>
        <div class=""modal-body"">
          Rejected
        </div>
        <div class=""modal-footer"">
          <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Close</button>

        </div>
      </div>
    </div>
  </div>

  <div class=""card-div"">
    <div class=""card p-2 mt-4"">

      <div class=""card-title text-center"">Hi, ");
#nullable restore
#line 87 "C:\Users\shwetha.b\Desktop\thu-aks-deskify\New-Deskify\Deskify_3.1\DeskUI\Views\Employee\Index.cshtml"
                                         Write(Model.EmployeeName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" !\r\n        <br>\r\n                    <div class=\"card-title text-center\"> Today, ");
#nullable restore
#line 89 "C:\Users\shwetha.b\Desktop\thu-aks-deskify\New-Deskify\Deskify_3.1\DeskUI\Views\Employee\Index.cshtml"
                                                           Write(DateTime.Now.ToString("dddd, dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>
      </div>
    </div>
  </div>

  <div class=""message mb-4"">
                <div class=""row row1 card-div mt-5 me-xl-5"" >
                    <button type=""button"" data-bs-toggle=""modal"" data-bs-target=""#approved""
                            class=""card-button bg-transparent  middle-row mx-sm-4 mx-md-4 mx-xxl-5"">
                        <div class=""middle-row shadow p-3 mx-md-4 mx-xxl-5"">
                        <img src=""https://cdn-icons-png.flaticon.com/128/8888/8888205.png""");
                BeginWriteAttribute("alt", " alt=\"", 4106, "\"", 4112, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""innerimage"" style=""width:50px;height:50px;margin-bottom:10px;"" />
                        <h3 class=""mb-0 font-weight-bold"">1</h3>
                        <span class=""text-uppercase "" style=""font-family:Arial"">Approved</span>
                        </div>
                    </button>


                    <button type=""button"" data-bs-toggle=""modal"" data-bs-target=""#pending""
                            class=""card-button bg-transparent middle-row mx-sm-4 mx-md-4 mx-xxl-5"">
                        <div class=""middle-row shadow p-3 mx-md-4 mx-xxl-5"">
                        <img src=""https://cdn-icons-png.flaticon.com/128/7887/7887122.png""");
                BeginWriteAttribute("alt", " alt=\"", 4779, "\"", 4785, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""innerimage"" style=""width:50px;height:50px;margin-bottom:10px;"" /><br />
                        <h3 class=""mb-0 font-weight-bold"">0</h3>
                        <span class=""text-uppercase "" style=""font-family:Arial"">Pending</span>
                        </div>
                    </button>


                    <button type=""button"" data-bs-toggle=""modal"" data-bs-target=""#rejected""
                            class=""card-button bg-transparent middle-row mx-sm-4 mx-md-4 mx-xxl-5"">
                        <div class=""middle-row shadow p-3 mx-md-4 mx-xxl-5"">
                        <img src=""https://cdn-icons-png.flaticon.com/128/5978/5978441.png""");
                BeginWriteAttribute("alt", " alt=\"", 5458, "\"", 5464, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""innerimage"" style=""width:50px;height:50px;margin-bottom: 10px;""/><br />
                        <h3 class=""mb-0 font-weight-bold"">0</h3>
                        <span class="" text-uppercase"" style=""font-family:Arial"">Rejected</span>
                        </div>
                    </button>
                </div>

</div>
        <center class=""justify-content-center"">
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbec8b76d7d233a94f3345bcd707c159b1266c7614054", async() => {
                    WriteLiteral("Book a Seat");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbec8b76d7d233a94f3345bcd707c159b1266c7615679", async() => {
                    WriteLiteral("Book a Room");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n       </center>\r\n</div>\r\n    \r\n");
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
            WriteLiteral("\r\n\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DeskEntity.Model.Employee> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
