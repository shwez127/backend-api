#pragma checksum "C:\Users\shwetha.b\Desktop\thu-aks-deskify\New-Deskify\Deskify_3.1\DeskUI\Views\Employee\GetSeatsByFloorId.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "314ee17949cf8edccea797a531aab6b07c8a0215"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_GetSeatsByFloorId), @"mvc.1.0.view", @"/Views/Employee/GetSeatsByFloorId.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"314ee17949cf8edccea797a531aab6b07c8a0215", @"/Views/Employee/GetSeatsByFloorId.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d8cdb277b9c163ebed098cdd742e1e39fe3be15", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_GetSeatsByFloorId : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DeskEntity.Model.Seat>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/seat-green.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:50px;width:50px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("myfunction()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetSeatsByFloorId", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration:none;color:black"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/seat-red.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:40px;width:40px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mx-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background:-webkit-linear-gradient(left, #fff, #000)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\shwetha.b\Desktop\thu-aks-deskify\New-Deskify\Deskify_3.1\DeskUI\Views\Employee\GetSeatsByFloorId.cshtml"
  
    Layout = "~/Views/Shared/_EmployeeLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "314ee17949cf8edccea797a531aab6b07c8a02157431", async() => {
                WriteLiteral(@"
    <section class=""vh-70 gradient-custom"">
        <div class=""container-fluid py-5 h-100"">
            <div class=""row justify-content-center align-items-center h-100"">
                <div class=""col-12 col-lg-9 col-xl-7"">
                    <div class=""card shadow-2-strong card-registration"" style=""border-radius: 15px;"">
                        <div class=""card-body p-4 p-md-5"">
                            <span class=""mb-4 pb-2 pb-md-0 mb-md-5 "">
                                <h3 style=""margin-bottom:20px"">
                                    Seat Booking
");
#nullable restore
#line 130 "C:\Users\shwetha.b\Desktop\thu-aks-deskify\New-Deskify\Deskify_3.1\DeskUI\Views\Employee\GetSeatsByFloorId.cshtml"
                                     foreach(var item1 in Model)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <div style=\"width:300px;border-radius:20px;background-color:silver;margin-left:415px;font-size:20px;padding:6px\" class=\"d-inline\">");
#nullable restore
#line 132 "C:\Users\shwetha.b\Desktop\thu-aks-deskify\New-Deskify\Deskify_3.1\DeskUI\Views\Employee\GetSeatsByFloorId.cshtml"
                                                                                                                                                                     Write(item1.Floor.FloorName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 133 "C:\Users\shwetha.b\Desktop\thu-aks-deskify\New-Deskify\Deskify_3.1\DeskUI\Views\Employee\GetSeatsByFloorId.cshtml"
                                        break;
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </h3>\r\n                            </span>\r\n                            <div class=\"row row-cols-md-12 row-cols-sm-4 row-cols-4\">\r\n");
#nullable restore
#line 138 "C:\Users\shwetha.b\Desktop\thu-aks-deskify\New-Deskify\Deskify_3.1\DeskUI\Views\Employee\GetSeatsByFloorId.cshtml"
                                  
                                    int c = 0;
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 140 "C:\Users\shwetha.b\Desktop\thu-aks-deskify\New-Deskify\Deskify_3.1\DeskUI\Views\Employee\GetSeatsByFloorId.cshtml"
                                     foreach (var item in Model)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 142 "C:\Users\shwetha.b\Desktop\thu-aks-deskify\New-Deskify\Deskify_3.1\DeskUI\Views\Employee\GetSeatsByFloorId.cshtml"
                                         if (item.Status == false)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <div class=\"col-1 col-sm-1 col-md-1  p-2 mb-3\">\r\n                                                <div>\r\n                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "314ee17949cf8edccea797a531aab6b07c8a021510930", async() => {
                    WriteLiteral("\r\n                                                        \r\n                                                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "314ee17949cf8edccea797a531aab6b07c8a021511306", async() => {
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
                    WriteLiteral("</img>\r\n                                                        <center >");
#nullable restore
#line 149 "C:\Users\shwetha.b\Desktop\thu-aks-deskify\New-Deskify\Deskify_3.1\DeskUI\Views\Employee\GetSeatsByFloorId.cshtml"
                                                            Write(item.SeatNumber);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</center>\r\n                                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-SeatId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 146 "C:\Users\shwetha.b\Desktop\thu-aks-deskify\New-Deskify\Deskify_3.1\DeskUI\Views\Employee\GetSeatsByFloorId.cshtml"
                                                                                                                                             WriteLiteral(item.SeatId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["SeatId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-SeatId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["SeatId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 151 "C:\Users\shwetha.b\Desktop\thu-aks-deskify\New-Deskify\Deskify_3.1\DeskUI\Views\Employee\GetSeatsByFloorId.cshtml"
                                                     if (c == 12)
                                                    {
                                                        c = 0;

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                        <div class=""row"">                                                        
                                                            <div class=""col-1"">
                                                                <svg width=""400"" height=""50"">
                                                                    <rect x=""5"" y=""5"" rx=""5"" ry=""5"" width=""400"" height=""30""
                                                                          style=""fill:blue;stroke:black;stroke-width:5;opacity:0.8"" />
                                                                </svg>
                                                            </div>
                                                        </div>
");
#nullable restore
#line 162 "C:\Users\shwetha.b\Desktop\thu-aks-deskify\New-Deskify\Deskify_3.1\DeskUI\Views\Employee\GetSeatsByFloorId.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                </div>\r\n                                            </div>\r\n");
#nullable restore
#line 165 "C:\Users\shwetha.b\Desktop\thu-aks-deskify\New-Deskify\Deskify_3.1\DeskUI\Views\Employee\GetSeatsByFloorId.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <div class=\"col-1 col-sm-1 col-md-1 p-2\">\r\n                                                <a style=\"pointer-events:none;text-decoration:none\">\r\n                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "314ee17949cf8edccea797a531aab6b07c8a021517748", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</img>\r\n                                                        <center>");
#nullable restore
#line 171 "C:\Users\shwetha.b\Desktop\thu-aks-deskify\New-Deskify\Deskify_3.1\DeskUI\Views\Employee\GetSeatsByFloorId.cshtml"
                                                           Write(item.SeatNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</center>\r\n                                                    </a>\r\n                                                </div>\r\n");
#nullable restore
#line 174 "C:\Users\shwetha.b\Desktop\thu-aks-deskify\New-Deskify\Deskify_3.1\DeskUI\Views\Employee\GetSeatsByFloorId.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 174 "C:\Users\shwetha.b\Desktop\thu-aks-deskify\New-Deskify\Deskify_3.1\DeskUI\Views\Employee\GetSeatsByFloorId.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </div>\r\n                            <div class=\"row text-center\">\r\n                                <div class=\"card col-2 offset-10 p-2 shadow-lg\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "314ee17949cf8edccea797a531aab6b07c8a021520214", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</img>\r\n                                    <span class=\"font-weight-bold mb-3\">Vacant</span>\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "314ee17949cf8edccea797a531aab6b07c8a021521609", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</img>
                                    <span class=""font-weight-bold"">Occupied</span>
                               </div>
                            </div>
                        </div>
                    </div>
                  </div>
            </div>
         </div>
</section>
    <script>
        function myfunction() {
            alert(""Are you sure you want to book this seat?"");
        }
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DeskEntity.Model.Seat>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591