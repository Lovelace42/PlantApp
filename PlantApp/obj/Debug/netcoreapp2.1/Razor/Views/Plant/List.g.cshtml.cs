#pragma checksum "C:\Projects\Plants\PlantApp\Views\Plant\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a0b0d7d7f986b3638d1b204f5c81b00b46630d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Plant_List), @"mvc.1.0.view", @"/Views/Plant/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Plant/List.cshtml", typeof(AspNetCore.Views_Plant_List))]
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
#line 1 "C:\Projects\Plants\PlantApp\Views\_ViewImports.cshtml"
using PlantApp.Models;

#line default
#line hidden
#line 2 "C:\Projects\Plants\PlantApp\Views\_ViewImports.cshtml"
using PlantApp.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a0b0d7d7f986b3638d1b204f5c81b00b46630d3", @"/Views/Plant/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"487e429056e07092a7ac72dc87755ae13de19f53", @"/Views/_ViewImports.cshtml")]
    public class Views_Plant_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PlantsListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Projects\Plants\PlantApp\Views\Plant\List.cshtml"
 foreach (var plant in Model.Plants)
{

#line default
#line hidden
            BeginContext(73, 95, true);
            WriteLiteral("    <div class=\"col-sm-4 col-lg-4 col-md-4\">\r\n        <div class=\"thumbnail\">\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 168, "\"", 189, 1);
#line 8 "C:\Projects\Plants\PlantApp\Views\Plant\List.cshtml"
WriteAttributeValue("", 174, plant.ImageUrl, 174, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(190, 90, true);
            WriteLiteral(" alt=\"\">\r\n            <div class=\"caption\">\r\n                <h3>\r\n                    <a>");
            EndContext();
            BeginContext(281, 16, false);
#line 11 "C:\Projects\Plants\PlantApp\Views\Plant\List.cshtml"
                  Write(plant.CommonName);

#line default
#line hidden
            EndContext();
            BeginContext(297, 49, true);
            WriteLiteral("</a>\r\n                </h3>\r\n                <h4>");
            EndContext();
            BeginContext(347, 15, false);
#line 13 "C:\Projects\Plants\PlantApp\Views\Plant\List.cshtml"
               Write(plant.LatinName);

#line default
#line hidden
            EndContext();
            BeginContext(362, 26, true);
            WriteLiteral("</h4>\r\n                <p>");
            EndContext();
            BeginContext(389, 17, false);
#line 14 "C:\Projects\Plants\PlantApp\Views\Plant\List.cshtml"
              Write(plant.Description);

#line default
#line hidden
            EndContext();
            BeginContext(406, 54, true);
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 18 "C:\Projects\Plants\PlantApp\Views\Plant\List.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlantsListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
