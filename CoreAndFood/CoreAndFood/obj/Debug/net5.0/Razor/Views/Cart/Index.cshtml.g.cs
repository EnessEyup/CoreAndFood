#pragma checksum "C:\Users\enes.eyupoglu\source\repos\CoreAndFood\CoreAndFood\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9878dfb29be9e197889d74f30908284d15ec8199"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9878dfb29be9e197889d74f30908284d15ec8199", @"/Views/Cart/Index.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreAndFood.Data.Models.Cart>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\enes.eyupoglu\source\repos\CoreAndFood\CoreAndFood\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>Your Shopping Cart</h2>\r\n\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <th>Food</th>\r\n            <th>Quantity</th>\r\n            <th>Actions</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 20 "C:\Users\enes.eyupoglu\source\repos\CoreAndFood\CoreAndFood\Views\Cart\Index.cshtml"
         foreach (var item in Model.CartItems)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\enes.eyupoglu\source\repos\CoreAndFood\CoreAndFood\Views\Cart\Index.cshtml"
               Write(item.Food.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\enes.eyupoglu\source\repos\CoreAndFood\CoreAndFood\Views\Cart\Index.cshtml"
               Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <form asp-action=\"RemoveFromCart\" method=\"post\">\r\n                        <input type=\"hidden\" name=\"cartItemId\"");
            BeginWriteAttribute("value", " value=\"", 642, "\"", 666, 1);
#nullable restore
#line 27 "C:\Users\enes.eyupoglu\source\repos\CoreAndFood\CoreAndFood\Views\Cart\Index.cshtml"
WriteAttributeValue("", 650, item.CartItemId, 650, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <button type=\"submit\">Remove</button>\r\n                    </form>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 32 "C:\Users\enes.eyupoglu\source\repos\CoreAndFood\CoreAndFood\Views\Cart\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<h3>Add Food to Cart</h3>\r\n<form asp-action=\"AddToCart\" method=\"post\">\r\n    <select name=\"foodId\">\r\n");
#nullable restore
#line 39 "C:\Users\enes.eyupoglu\source\repos\CoreAndFood\CoreAndFood\Views\Cart\Index.cshtml"
         foreach (var food in ViewBag.Foods)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <option");
            BeginWriteAttribute("value", " value=\"", 1019, "\"", 1039, 1);
#nullable restore
#line 41 "C:\Users\enes.eyupoglu\source\repos\CoreAndFood\CoreAndFood\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1027, food.FoodID, 1027, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 41 "C:\Users\enes.eyupoglu\source\repos\CoreAndFood\CoreAndFood\Views\Cart\Index.cshtml"
                                    Write(food.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 42 "C:\Users\enes.eyupoglu\source\repos\CoreAndFood\CoreAndFood\Views\Cart\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </select>\r\n    <input type=\"number\" name=\"quantity\" value=\"1\" />\r\n    <button type=\"submit\">Add to Cart</button>\r\n</form>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreAndFood.Data.Models.Cart> Html { get; private set; }
    }
}
#pragma warning restore 1591
