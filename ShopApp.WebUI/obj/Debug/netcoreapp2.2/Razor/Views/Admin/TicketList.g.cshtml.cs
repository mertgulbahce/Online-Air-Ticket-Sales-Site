#pragma checksum "C:\Users\SenolKeskin\Desktop\WebProje\OnlineTicket\ShopApp.WebUI\Views\Admin\TicketList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b4dab879d56144c97b487df15adaf58a6435a93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_TicketList), @"mvc.1.0.view", @"/Views/Admin/TicketList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/TicketList.cshtml", typeof(AspNetCore.Views_Admin_TicketList))]
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
#line 1 "C:\Users\SenolKeskin\Desktop\WebProje\OnlineTicket\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.Entities;

#line default
#line hidden
#line 2 "C:\Users\SenolKeskin\Desktop\WebProje\OnlineTicket\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b4dab879d56144c97b487df15adaf58a6435a93", @"/Views/Admin/TicketList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b06003b703c0369be993c930941e06577d23922", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_TicketList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TicketListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/deleteticket"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\SenolKeskin\Desktop\WebProje\OnlineTicket\ShopApp.WebUI\Views\Admin\TicketList.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(65, 34, true);
            WriteLiteral("\r\n<h1>Admin Tickets</h1>\r\n<hr />\r\n");
            EndContext();
#line 8 "C:\Users\SenolKeskin\Desktop\WebProje\OnlineTicket\ShopApp.WebUI\Views\Admin\TicketList.cshtml"
 if (Model.Tickets.Count() > 0)
{

#line default
#line hidden
            BeginContext(135, 397, true);
            WriteLiteral(@"    <table class=""table table-bordered"">
        <thead>
            <tr>

                <td style=""width:30px;"">Id</td>
                <td style=""width:100px;"">Image</td>
                <td>To</td>
                <td>From</td>
                <td style=""width:12px;"">Price</td>
                <td style=""width:150px;""></td>
            </tr>
        </thead>
        <tbody>

");
            EndContext();
#line 24 "C:\Users\SenolKeskin\Desktop\WebProje\OnlineTicket\ShopApp.WebUI\Views\Admin\TicketList.cshtml"
             foreach (var item in Model.Tickets)
            {

#line default
#line hidden
            BeginContext(597, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(644, 7, false);
#line 27 "C:\Users\SenolKeskin\Desktop\WebProje\OnlineTicket\ShopApp.WebUI\Views\Admin\TicketList.cshtml"
                   Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(651, 57, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(708, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0b4dab879d56144c97b487df15adaf58a6435a936568", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 718, "~/img/", 718, 6, true);
#line 29 "C:\Users\SenolKeskin\Desktop\WebProje\OnlineTicket\ShopApp.WebUI\Views\Admin\TicketList.cshtml"
AddHtmlAttributeValue("", 724, item.ImageUrl, 724, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(753, 53, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>");
            EndContext();
            BeginContext(807, 7, false);
#line 31 "C:\Users\SenolKeskin\Desktop\WebProje\OnlineTicket\ShopApp.WebUI\Views\Admin\TicketList.cshtml"
                   Write(item.To);

#line default
#line hidden
            EndContext();
            BeginContext(814, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(846, 9, false);
#line 32 "C:\Users\SenolKeskin\Desktop\WebProje\OnlineTicket\ShopApp.WebUI\Views\Admin\TicketList.cshtml"
                   Write(item.From);

#line default
#line hidden
            EndContext();
            BeginContext(855, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(887, 10, false);
#line 33 "C:\Users\SenolKeskin\Desktop\WebProje\OnlineTicket\ShopApp.WebUI\Views\Admin\TicketList.cshtml"
                   Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(897, 95, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a class=\"btn btn-primary btn-sm mr-2\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 992, "\"", 1022, 2);
            WriteAttributeValue("", 999, "/admin/tickets/", 999, 15, true);
#line 35 "C:\Users\SenolKeskin\Desktop\WebProje\OnlineTicket\ShopApp.WebUI\Views\Admin\TicketList.cshtml"
WriteAttributeValue("", 1014, item.Id, 1014, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1023, 35, true);
            WriteLiteral(">Edit</a>\r\n                        ");
            EndContext();
            BeginContext(1058, 289, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b4dab879d56144c97b487df15adaf58a6435a9310017", async() => {
                BeginContext(1131, 66, true);
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"ticketId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1197, "\"", 1213, 1);
#line 37 "C:\Users\SenolKeskin\Desktop\WebProje\OnlineTicket\ShopApp.WebUI\Views\Admin\TicketList.cshtml"
WriteAttributeValue("", 1205, item.Id, 1205, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1214, 126, true);
                WriteLiteral(" />\r\n                            <button type=\"submit\" class=\"btn btn-danger btn-sm\">Delete</button>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1347, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 42 "C:\Users\SenolKeskin\Desktop\WebProje\OnlineTicket\ShopApp.WebUI\Views\Admin\TicketList.cshtml"
            }

#line default
#line hidden
            BeginContext(1414, 86, true);
            WriteLiteral("\r\n        </tbody>\r\n        <tr>\r\n            <td></td>\r\n        </tr>\r\n    </table>\r\n");
            EndContext();
#line 49 "C:\Users\SenolKeskin\Desktop\WebProje\OnlineTicket\ShopApp.WebUI\Views\Admin\TicketList.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1512, 80, true);
            WriteLiteral("    <div class=\"alert alert-warning\">\r\n        <h4>No Tickets</h4>\r\n    </div>\r\n");
            EndContext();
#line 55 "C:\Users\SenolKeskin\Desktop\WebProje\OnlineTicket\ShopApp.WebUI\Views\Admin\TicketList.cshtml"
}

#line default
#line hidden
            BeginContext(1595, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TicketListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
