#pragma checksum "C:\Users\weissc14\source\repos\M426_Projekt\MVC Solution\M426_Projekt_Core\Views\List\ListDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6077bbb29ab1268720f8e778ca8801901308311e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_List_ListDetails), @"mvc.1.0.view", @"/Views/List/ListDetails.cshtml")]
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
#line 1 "C:\Users\weissc14\source\repos\M426_Projekt\MVC Solution\M426_Projekt_Core\Views\_ViewImports.cshtml"
using M426_Projekt_Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\weissc14\source\repos\M426_Projekt\MVC Solution\M426_Projekt_Core\Views\_ViewImports.cshtml"
using M426_Projekt_Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\weissc14\source\repos\M426_Projekt\MVC Solution\M426_Projekt_Core\Views\List\ListDetails.cshtml"
using M426_Projekt_Core.Models.Task;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6077bbb29ab1268720f8e778ca8801901308311e", @"/Views/List/ListDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95c4385575b29142670e9c5b4d4f2fb8932bf4e2", @"/Views/_ViewImports.cshtml")]
    public class Views_List_ListDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>My Lists</h1>\r\n<div class=\"List\">\r\n");
#nullable restore
#line 4 "C:\Users\weissc14\source\repos\M426_Projekt\MVC Solution\M426_Projekt_Core\Views\List\ListDetails.cshtml"
     foreach (TaskModel task in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"ListItem\">\r\n            <p>");
#nullable restore
#line 7 "C:\Users\weissc14\source\repos\M426_Projekt\MVC Solution\M426_Projekt_Core\Views\List\ListDetails.cshtml"
          Write(Html.DisplayFor(modelItem => task.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n");
#nullable restore
#line 9 "C:\Users\weissc14\source\repos\M426_Projekt\MVC Solution\M426_Projekt_Core\Views\List\ListDetails.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
