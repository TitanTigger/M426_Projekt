#pragma checksum "/Users/ardiandemiri/Desktop/Projects/Programming/C#/M426_Projekt/MVC Solution/M426_Projekt_CW_AD_JL_MB/M426_Projekt_CW_AD_JL_MB/Views/List/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e64b7c39756ed1679808e83e69e8e2b3ecc66f78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_List_Index), @"mvc.1.0.view", @"/Views/List/Index.cshtml")]
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
#line 1 "/Users/ardiandemiri/Desktop/Projects/Programming/C#/M426_Projekt/MVC Solution/M426_Projekt_CW_AD_JL_MB/M426_Projekt_CW_AD_JL_MB/Views/_ViewImports.cshtml"
using M426_Projekt_CW_AD_JL_MB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ardiandemiri/Desktop/Projects/Programming/C#/M426_Projekt/MVC Solution/M426_Projekt_CW_AD_JL_MB/M426_Projekt_CW_AD_JL_MB/Views/_ViewImports.cshtml"
using M426_Projekt_CW_AD_JL_MB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e64b7c39756ed1679808e83e69e8e2b3ecc66f78", @"/Views/List/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffd9c6079c124d92c99ae8b3b557f9299ae31968", @"/Views/_ViewImports.cshtml")]
    public class Views_List_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<M426_Projekt_CW_AD_JL_MB.Models.List.ListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n<div class=\"container\">\n    <div class=\"card m-1\" data-toggle=\"modal\" data-target=\".bd-example-modal-lg\">\n        <div class=\"card-body\">\n            <h5 class=\"card-title\">\n                + Create\n            </h5>\n        </div>\n    </div>\n");
#nullable restore
#line 12 "/Users/ardiandemiri/Desktop/Projects/Programming/C#/M426_Projekt/MVC Solution/M426_Projekt_CW_AD_JL_MB/M426_Projekt_CW_AD_JL_MB/Views/List/Index.cshtml"
     foreach (M426_Projekt_CW_AD_JL_MB.Models.List.ListModel obj in Model.Lists)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card m-1\">\n    <div class=\"card-body\">\n        <h5 class=\"card-title\">\n            ");
#nullable restore
#line 17 "/Users/ardiandemiri/Desktop/Projects/Programming/C#/M426_Projekt/MVC Solution/M426_Projekt_CW_AD_JL_MB/M426_Projekt_CW_AD_JL_MB/Views/List/Index.cshtml"
       Write(obj.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </h5>\n        <button>");
#nullable restore
#line 19 "/Users/ardiandemiri/Desktop/Projects/Programming/C#/M426_Projekt/MVC Solution/M426_Projekt_CW_AD_JL_MB/M426_Projekt_CW_AD_JL_MB/Views/List/Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", "List", new { id = obj.Id }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n        <button>");
#nullable restore
#line 20 "/Users/ardiandemiri/Desktop/Projects/Programming/C#/M426_Projekt/MVC Solution/M426_Projekt_CW_AD_JL_MB/M426_Projekt_CW_AD_JL_MB/Views/List/Index.cshtml"
           Write(Html.ActionLink("Detail", "Index", "ListDetail", new { id = obj.Id }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n    </div>\n</div>");
#nullable restore
#line 22 "/Users/ardiandemiri/Desktop/Projects/Programming/C#/M426_Projekt/MVC Solution/M426_Projekt_CW_AD_JL_MB/M426_Projekt_CW_AD_JL_MB/Views/List/Index.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>


<div class=""modal fade bd-example-modal-lg"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myLargeModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""createModal"">Create new list</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""container"">
");
#nullable restore
#line 37 "/Users/ardiandemiri/Desktop/Projects/Programming/C#/M426_Projekt/MVC Solution/M426_Projekt_CW_AD_JL_MB/M426_Projekt_CW_AD_JL_MB/Views/List/Index.cshtml"
                     using (Html.BeginForm("Create", "List", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""form-group"">
            <div>
                Name: <input class=""span2 col-md-2 form-control"" id=""format"" name=""name"" type=""text"" required>
                <br />
                <input type=""submit"" value=""Update"" class=""btn btn-default"" />
            </div>
        </div>");
#nullable restore
#line 45 "/Users/ardiandemiri/Desktop/Projects/Programming/C#/M426_Projekt/MVC Solution/M426_Projekt_CW_AD_JL_MB/M426_Projekt_CW_AD_JL_MB/Views/List/Index.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<M426_Projekt_CW_AD_JL_MB.Models.List.ListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
