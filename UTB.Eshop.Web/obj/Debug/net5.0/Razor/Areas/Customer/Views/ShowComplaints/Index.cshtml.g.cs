#pragma checksum "C:\Users\duris\Desktop\utb.eshop_2021\UTB.Eshop.Web\Areas\Customer\Views\ShowComplaints\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b8ae8f676c57d838ed541960ee9c326b6fbbada"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_ShowComplaints_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/ShowComplaints/Index.cshtml")]
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
#line 1 "C:\Users\duris\Desktop\utb.eshop_2021\UTB.Eshop.Web\Areas\Customer\Views\_ViewImports.cshtml"
using UTB.Eshop.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\duris\Desktop\utb.eshop_2021\UTB.Eshop.Web\Areas\Customer\Views\_ViewImports.cshtml"
using UTB.Eshop.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\duris\Desktop\utb.eshop_2021\UTB.Eshop.Web\Areas\Customer\Views\_ViewImports.cshtml"
using UTB.Eshop.Web.Models.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\duris\Desktop\utb.eshop_2021\UTB.Eshop.Web\Areas\Customer\Views\_ViewImports.cshtml"
using UTB.Eshop.Web.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b8ae8f676c57d838ed541960ee9c326b6fbbada", @"/Areas/Customer/Views/ShowComplaints/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd77ddbd32600c8f1fdc02c8914d8e17016895f7", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_ShowComplaints_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Complain", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ComplainIt", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\duris\Desktop\utb.eshop_2021\UTB.Eshop.Web\Areas\Customer\Views\ShowComplaints\Index.cshtml"
  
    ViewData["Title"] = "My Orders";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>");
#nullable restore
#line 5 "C:\Users\duris\Desktop\utb.eshop_2021\UTB.Eshop.Web\Areas\Customer\Views\ShowComplaints\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n<h3>");
#nullable restore
#line 6 "C:\Users\duris\Desktop\utb.eshop_2021\UTB.Eshop.Web\Areas\Customer\Views\ShowComplaints\Index.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n\n<br />\n\n");
#nullable restore
#line 10 "C:\Users\duris\Desktop\utb.eshop_2021\UTB.Eshop.Web\Areas\Customer\Views\ShowComplaints\Index.cshtml"
  
    if (Model != null && Model != null && Model.Count > 0)
    {
        foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <table style=\"width:100%\" class=\"table table-responsive table-striped table-bordered\">\n                <tr>\n                    <th class=\"col-sm-1\">");
#nullable restore
#line 17 "C:\Users\duris\Desktop\utb.eshop_2021\UTB.Eshop.Web\Areas\Customer\Views\ShowComplaints\Index.cshtml"
                                    Write(nameof(Order.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                    <th class=\"col-sm-2\">");
#nullable restore
#line 18 "C:\Users\duris\Desktop\utb.eshop_2021\UTB.Eshop.Web\Areas\Customer\Views\ShowComplaints\Index.cshtml"
                                    Write(nameof(Order.OrderNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                    <th class=\"col-sm-3\">");
#nullable restore
#line 19 "C:\Users\duris\Desktop\utb.eshop_2021\UTB.Eshop.Web\Areas\Customer\Views\ShowComplaints\Index.cshtml"
                                    Write(nameof(Order.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                    <th class=\"col-sm-3\">");
#nullable restore
#line 20 "C:\Users\duris\Desktop\utb.eshop_2021\UTB.Eshop.Web\Areas\Customer\Views\ShowComplaints\Index.cshtml"
                                    Write(nameof(Order.DateTimeCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                    <th class=\"col-sm-3\">");
#nullable restore
#line 21 "C:\Users\duris\Desktop\utb.eshop_2021\UTB.Eshop.Web\Areas\Customer\Views\ShowComplaints\Index.cshtml"
                                    Write(nameof(Order.User.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                </tr>\n                <tr>\n                    <td class=\"col-sm-1\">");
#nullable restore
#line 24 "C:\Users\duris\Desktop\utb.eshop_2021\UTB.Eshop.Web\Areas\Customer\Views\ShowComplaints\Index.cshtml"
                                    Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td class=\"col-sm-2\">");
#nullable restore
#line 25 "C:\Users\duris\Desktop\utb.eshop_2021\UTB.Eshop.Web\Areas\Customer\Views\ShowComplaints\Index.cshtml"
                                    Write(item.OrderNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td class=\"col-sm-3\">");
#nullable restore
#line 26 "C:\Users\duris\Desktop\utb.eshop_2021\UTB.Eshop.Web\Areas\Customer\Views\ShowComplaints\Index.cshtml"
                                    Write(item.TotalPrice.ToString("C2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td class=\"col-sm-3\">");
#nullable restore
#line 27 "C:\Users\duris\Desktop\utb.eshop_2021\UTB.Eshop.Web\Areas\Customer\Views\ShowComplaints\Index.cshtml"
                                    Write(item.DateTimeCreated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td class=\"col-sm-3\">");
#nullable restore
#line 28 "C:\Users\duris\Desktop\utb.eshop_2021\UTB.Eshop.Web\Areas\Customer\Views\ShowComplaints\Index.cshtml"
                                    Write(item.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n\n\n            </table>\n");
            WriteLiteral("            <details>\n                <summary>Details</summary>\n                <div");
            BeginWriteAttribute("id", " id=\"", 1230, "\"", 1255, 2);
            WriteAttributeValue("", 1235, "order_items_", 1235, 12, true);
#nullable restore
#line 36 "C:\Users\duris\Desktop\utb.eshop_2021\UTB.Eshop.Web\Areas\Customer\Views\ShowComplaints\Index.cshtml"
WriteAttributeValue("", 1247, item.ID, 1247, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    <h4>Order Items</h4>\n                    <table style=\"width:41.667%\" class=\"table table-responsive table-bordered\">\n                        <tr>\n                            <th class=\"col-sm-3\">");
#nullable restore
#line 40 "C:\Users\duris\Desktop\utb.eshop_2021\UTB.Eshop.Web\Areas\Customer\Views\ShowComplaints\Index.cshtml"
                                            Write(nameof(Product.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                            <th class=\"col-sm-1\">");
#nullable restore
#line 41 "C:\Users\duris\Desktop\utb.eshop_2021\UTB.Eshop.Web\Areas\Customer\Views\ShowComplaints\Index.cshtml"
                                            Write(nameof(OrderItem.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                            <th class=\"col-sm-1\">");
#nullable restore
#line 42 "C:\Users\duris\Desktop\utb.eshop_2021\UTB.Eshop.Web\Areas\Customer\Views\ShowComplaints\Index.cshtml"
                                            Write(nameof(OrderItem.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                        </tr>\n\n");
#nullable restore
#line 45 "C:\Users\duris\Desktop\utb.eshop_2021\UTB.Eshop.Web\Areas\Customer\Views\ShowComplaints\Index.cshtml"
                          
                            foreach (var itemOrderItems in item.OrderItems)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\n                                    <td class=\"col-sm-3\">");
#nullable restore
#line 49 "C:\Users\duris\Desktop\utb.eshop_2021\UTB.Eshop.Web\Areas\Customer\Views\ShowComplaints\Index.cshtml"
                                                    Write(itemOrderItems.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td class=\"col-sm-1\">");
#nullable restore
#line 50 "C:\Users\duris\Desktop\utb.eshop_2021\UTB.Eshop.Web\Areas\Customer\Views\ShowComplaints\Index.cshtml"
                                                    Write(itemOrderItems.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td class=\"col-sm-1\">");
#nullable restore
#line 51 "C:\Users\duris\Desktop\utb.eshop_2021\UTB.Eshop.Web\Areas\Customer\Views\ShowComplaints\Index.cshtml"
                                                    Write(itemOrderItems.Price.ToString("C2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n                                    <td>\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b8ae8f676c57d838ed541960ee9c326b6fbbada13245", async() => {
                WriteLiteral("\n                                           Create complain\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-name", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\duris\Desktop\utb.eshop_2021\UTB.Eshop.Web\Areas\Customer\Views\ShowComplaints\Index.cshtml"
                                                                                                 WriteLiteral(itemOrderItems.Product.Name);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-name", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\Users\duris\Desktop\utb.eshop_2021\UTB.Eshop.Web\Areas\Customer\Views\ShowComplaints\Index.cshtml"
                                                    WriteLiteral(itemOrderItems.Product.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\Users\duris\Desktop\utb.eshop_2021\UTB.Eshop.Web\Areas\Customer\Views\ShowComplaints\Index.cshtml"
                                                                                                       WriteLiteral(itemOrderItems.Order.OrderNumber);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["OrderNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-OrderNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["OrderNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                    </td> \n                                </tr>\n");
#nullable restore
#line 60 "C:\Users\duris\Desktop\utb.eshop_2021\UTB.Eshop.Web\Areas\Customer\Views\ShowComplaints\Index.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </table>\n                </div>\n            </details>\n            <br />\n            <br />\n            <br />\n");
#nullable restore
#line 69 "C:\Users\duris\Desktop\utb.eshop_2021\UTB.Eshop.Web\Areas\Customer\Views\ShowComplaints\Index.cshtml"
        }
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>Orders are empty!</h2>\n");
#nullable restore
#line 74 "C:\Users\duris\Desktop\utb.eshop_2021\UTB.Eshop.Web\Areas\Customer\Views\ShowComplaints\Index.cshtml"
               
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
