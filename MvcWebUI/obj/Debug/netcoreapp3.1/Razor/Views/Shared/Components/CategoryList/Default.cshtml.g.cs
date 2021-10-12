#pragma checksum "D:\ASPNetCoreEngin\ASPNetCoreNorthwindProject\MvcWebUI\Views\Shared\Components\CategoryList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e88da8b0dba0b42afc616e098c59b820cb08a59c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
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
#line 1 "D:\ASPNetCoreEngin\ASPNetCoreNorthwindProject\MvcWebUI\Views\_ViewImports.cshtml"
using MvcWebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASPNetCoreEngin\ASPNetCoreNorthwindProject\MvcWebUI\Views\_ViewImports.cshtml"
using MvcWebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e88da8b0dba0b42afc616e098c59b820cb08a59c", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e90fbe64bce36a3ccac09ea850cf7cd992ce84ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CategoryList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h1>Categories</h1>\r\n<div class=\"list-group\">\r\n");
#nullable restore
#line 6 "D:\ASPNetCoreEngin\ASPNetCoreNorthwindProject\MvcWebUI\Views\Shared\Components\CategoryList\Default.cshtml"
      
        var allItemsCss = "list-group-item";
        if (Model.CurrentCategory==0)
        {
            allItemsCss += " active";
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a href=\"/product/index\"");
            BeginWriteAttribute("class", " class=\"", 267, "\"", 287, 1);
#nullable restore
#line 12 "D:\ASPNetCoreEngin\ASPNetCoreNorthwindProject\MvcWebUI\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 275, allItemsCss, 275, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Tum Urunler</a>\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 16 "D:\ASPNetCoreEngin\ASPNetCoreNorthwindProject\MvcWebUI\Views\Shared\Components\CategoryList\Default.cshtml"
     foreach (var category in Model.Categories)
    {
        var css = "list-group-item";
        if (category.CategoryId == Model.CurrentCategory)
        {
            css += " active";
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 533, "\"", 584, 2);
            WriteAttributeValue("", 540, "/product/index?category=", 540, 24, true);
#nullable restore
#line 23 "D:\ASPNetCoreEngin\ASPNetCoreNorthwindProject\MvcWebUI\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 564, category.CategoryId, 564, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 585, "\"", 597, 1);
#nullable restore
#line 23 "D:\ASPNetCoreEngin\ASPNetCoreNorthwindProject\MvcWebUI\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 593, css, 593, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 23 "D:\ASPNetCoreEngin\ASPNetCoreNorthwindProject\MvcWebUI\Views\Shared\Components\CategoryList\Default.cshtml"
                                                                       Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 24 "D:\ASPNetCoreEngin\ASPNetCoreNorthwindProject\MvcWebUI\Views\Shared\Components\CategoryList\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
