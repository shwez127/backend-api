#pragma checksum "C:\Users\shwetha.b\Desktop\thu-aks-deskify\New-Deskify\Deskify_3.1\DeskUI\Views\Employee\GetSeatsByFloorId1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a2c6236eb6eb7677ea2c9f3f5a5e9524fad8e08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_GetSeatsByFloorId1), @"mvc.1.0.view", @"/Views/Employee/GetSeatsByFloorId1.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a2c6236eb6eb7677ea2c9f3f5a5e9524fad8e08", @"/Views/Employee/GetSeatsByFloorId1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d8cdb277b9c163ebed098cdd742e1e39fe3be15", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_GetSeatsByFloorId1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DeskEntity.Model.Room>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "BookingRoom", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetSeatsByFloorId1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("room"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h1>GetSeatsByFloorId1</h1>\r\n\r\n");
#nullable restore
#line 5 "C:\Users\shwetha.b\Desktop\thu-aks-deskify\New-Deskify\Deskify_3.1\DeskUI\Views\Employee\GetSeatsByFloorId1.cshtml"
  
    Layout = "~/Views/Shared/_EmployeeLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a2c6236eb6eb7677ea2c9f3f5a5e9524fad8e085677", async() => {
                WriteLiteral("Booking Room");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a2c6236eb6eb7677ea2c9f3f5a5e9524fad8e087105", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"container\">\r\n        <center>\r\n            <h2 class=\"text-light text-center\">Select Your Room</h2>\r\n            <div class=\" row\">\r\n");
#nullable restore
#line 27 "C:\Users\shwetha.b\Desktop\thu-aks-deskify\New-Deskify\Deskify_3.1\DeskUI\Views\Employee\GetSeatsByFloorId1.cshtml"
                  
                    int c = 0;

                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\shwetha.b\Desktop\thu-aks-deskify\New-Deskify\Deskify_3.1\DeskUI\Views\Employee\GetSeatsByFloorId1.cshtml"
                     foreach (var item in Model)
                    {


                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\shwetha.b\Desktop\thu-aks-deskify\New-Deskify\Deskify_3.1\DeskUI\Views\Employee\GetSeatsByFloorId1.cshtml"
                         if (item.RStatus == false)
                        {



#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"col-2\">\r\n                                <div>\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a2c6236eb6eb7677ea2c9f3f5a5e9524fad8e088546", async() => {
                    WriteLiteral("\r\n                                        Room Num:");
#nullable restore
#line 41 "C:\Users\shwetha.b\Desktop\thu-aks-deskify\New-Deskify\Deskify_3.1\DeskUI\Views\Employee\GetSeatsByFloorId1.cshtml"
                                            Write(item.RoomNumber);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        <svg width=""70"" height=""70"" style=""border-radius:50%"">
                                            <rect x=""5"" y=""5"" rx=""5"" ry=""5"" width=""50"" height=""50""
                                                  style=""fill:green;stroke:black;stroke-width:5;opacity:0.5"" />
                                        </svg>
                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-RoomId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "C:\Users\shwetha.b\Desktop\thu-aks-deskify\New-Deskify\Deskify_3.1\DeskUI\Views\Employee\GetSeatsByFloorId1.cshtml"
                                                                                                       WriteLiteral(item.RoomId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["RoomId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-RoomId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["RoomId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 49 "C:\Users\shwetha.b\Desktop\thu-aks-deskify\New-Deskify\Deskify_3.1\DeskUI\Views\Employee\GetSeatsByFloorId1.cshtml"
                                     if (c == 12)
                                    {
                                        c = 0;

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                        <div class=""row"">
                                            <div class=""col-1"">
                                                <svg width=""400"" height=""50"">
                                                    <rect x=""5"" y=""5"" rx=""5"" ry=""5"" width=""400"" height=""30""
                                                          style=""fill:blue;stroke:black;stroke-width:5;opacity:0.8"" />
                                                </svg>
                                            </div>
                                        </div>
");
#nullable restore
#line 60 "C:\Users\shwetha.b\Desktop\thu-aks-deskify\New-Deskify\Deskify_3.1\DeskUI\Views\Employee\GetSeatsByFloorId1.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n\r\n\r\n                            </div>\r\n");
#nullable restore
#line 66 "C:\Users\shwetha.b\Desktop\thu-aks-deskify\New-Deskify\Deskify_3.1\DeskUI\Views\Employee\GetSeatsByFloorId1.cshtml"

                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div>\r\n\r\n                                Room Num:");
#nullable restore
#line 72 "C:\Users\shwetha.b\Desktop\thu-aks-deskify\New-Deskify\Deskify_3.1\DeskUI\Views\Employee\GetSeatsByFloorId1.cshtml"
                                    Write(item.RoomNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"<svg width=""40"" height=""50"">
                                    <rect x=""5"" y=""5"" rx=""5"" ry=""5"" width=""30"" height=""30""
                                          style=""fill:red;stroke:black;stroke-width:5;opacity:0.5"" />


                                </svg>

                            </div>
");
#nullable restore
#line 80 "C:\Users\shwetha.b\Desktop\thu-aks-deskify\New-Deskify\Deskify_3.1\DeskUI\Views\Employee\GetSeatsByFloorId1.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\shwetha.b\Desktop\thu-aks-deskify\New-Deskify\Deskify_3.1\DeskUI\Views\Employee\GetSeatsByFloorId1.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n            <div>\r\n                <br />\r\n            </div>\r\n        </center>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DeskEntity.Model.Room>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591