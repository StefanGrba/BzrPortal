#pragma checksum "C:\Users\Andjelija\source\repos\BZRForumMedia.Server\BZRForumMedia.Server\Views\AdminVrstaPropisa\ListVrstePropisa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3b320f476bbc358d6342f1657193b3a9486da73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminVrstaPropisa_ListVrstePropisa), @"mvc.1.0.view", @"/Views/AdminVrstaPropisa/ListVrstePropisa.cshtml")]
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
#line 1 "C:\Users\Andjelija\source\repos\BZRForumMedia.Server\BZRForumMedia.Server\Views\_ViewImports.cshtml"
using BZRForumMedia.Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Andjelija\source\repos\BZRForumMedia.Server\BZRForumMedia.Server\Views\_ViewImports.cshtml"
using BZRForumMedia.Server.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3b320f476bbc358d6342f1657193b3a9486da73", @"/Views/AdminVrstaPropisa/ListVrstePropisa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87c4f3f4e16ce85164dde0d03fb8df0a461925e9", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminVrstaPropisa_ListVrstePropisa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BZRForumMedia.Server.Models.VrstaPropisa>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateVrstaPropisa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminVrstaPropisa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteVrstaPropisa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Andjelija\source\repos\BZRForumMedia.Server\BZRForumMedia.Server\Views\AdminVrstaPropisa\ListVrstePropisa.cshtml"
  
    ViewData["Title"] = "Lista vrsta propsia";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <h1>Lista Vrsta Propisa</h1>\r\n\r\n    <p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3b320f476bbc358d6342f1657193b3a9486da734622", async() => {
                WriteLiteral("Kreiraj novu vrstu");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </p>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n\r\n                <th>\r\n                    ");
#nullable restore
#line 17 "C:\Users\Andjelija\source\repos\BZRForumMedia.Server\BZRForumMedia.Server\Views\AdminVrstaPropisa\ListVrstePropisa.cshtml"
               Write(Html.DisplayNameFor(model => model.Naziv));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 23 "C:\Users\Andjelija\source\repos\BZRForumMedia.Server\BZRForumMedia.Server\Views\AdminVrstaPropisa\ListVrstePropisa.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 28 "C:\Users\Andjelija\source\repos\BZRForumMedia.Server\BZRForumMedia.Server\Views\AdminVrstaPropisa\ListVrstePropisa.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Naziv));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 31 "C:\Users\Andjelija\source\repos\BZRForumMedia.Server\BZRForumMedia.Server\Views\AdminVrstaPropisa\ListVrstePropisa.cshtml"
                   Write(Html.ActionLink("Izmeni", "EditVrstaPropisa", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3b320f476bbc358d6342f1657193b3a9486da737460", async() => {
                WriteLiteral("Izbriši");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\Andjelija\source\repos\BZRForumMedia.Server\BZRForumMedia.Server\Views\AdminVrstaPropisa\ListVrstePropisa.cshtml"
                                                                                                WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 11, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 972, "return", 972, 6, true);
            AddHtmlAttributeValue(" ", 978, "confirm(\'Da", 979, 12, true);
            AddHtmlAttributeValue(" ", 990, "li", 991, 3, true);
            AddHtmlAttributeValue(" ", 993, "ste", 994, 4, true);
            AddHtmlAttributeValue(" ", 997, "sigurni", 998, 8, true);
            AddHtmlAttributeValue(" ", 1005, "da", 1006, 3, true);
            AddHtmlAttributeValue(" ", 1008, "želite", 1009, 7, true);
            AddHtmlAttributeValue(" ", 1015, "da", 1016, 3, true);
            AddHtmlAttributeValue(" ", 1018, "izbrišete", 1019, 10, true);
#nullable restore
#line 33 "C:\Users\Andjelija\source\repos\BZRForumMedia.Server\BZRForumMedia.Server\Views\AdminVrstaPropisa\ListVrstePropisa.cshtml"
AddHtmlAttributeValue(" ", 1028, item.Naziv, 1029, 11, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1040, "\')", 1040, 2, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 36 "C:\Users\Andjelija\source\repos\BZRForumMedia.Server\BZRForumMedia.Server\Views\AdminVrstaPropisa\ListVrstePropisa.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BZRForumMedia.Server.Models.VrstaPropisa>> Html { get; private set; }
    }
}
#pragma warning restore 1591
