#pragma checksum "C:\Users\Andjelija\source\repos\BZRForumMedia.Server\BZRForumMedia.Server\Views\KorisnikVesti\JednaVest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9067216af80207d986c45a9eec977a6faf8159b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_KorisnikVesti_JednaVest), @"mvc.1.0.view", @"/Views/KorisnikVesti/JednaVest.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9067216af80207d986c45a9eec977a6faf8159b8", @"/Views/KorisnikVesti/JednaVest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87c4f3f4e16ce85164dde0d03fb8df0a461925e9", @"/Views/_ViewImports.cshtml")]
    public class Views_KorisnikVesti_JednaVest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BZRForumMedia.Server.Models.Vest>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<!-- inner page banner -->
<div id=""inner_banner"" class=""section inner_banner_section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""full"">
                    <div class=""title-holder"">
                        <div class=""title-holder-cell text-left"">
                            <h1 class=""page-title"">");
#nullable restore
#line 12 "C:\Users\Andjelija\source\repos\BZRForumMedia.Server\BZRForumMedia.Server\Views\KorisnikVesti\JednaVest.cshtml"
                                              Write(Model.Naslov);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                            <ol class=\"breadcrumb\">\r\n                                <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9067216af80207d986c45a9eec977a6faf8159b84627", async() => {
                WriteLiteral("Pocetna");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                                <li class=""active"">Vesti</li>
                            </ol>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- end inner page banner -->
<!-- section -->
<div class=""section padding_layout_1 blog_grid"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-8 col-md-8 col-sm-12 col-xs-12 pull-right"">
                <div class=""full"">
                    <div class=""blog_section margin_bottom_0"">
                        <div class=""blog_feature_img""> <img class=""img-responsive""");
            BeginWriteAttribute("src", " src=\"", 1256, "\"", 1283, 1);
#nullable restore
#line 32 "C:\Users\Andjelija\source\repos\BZRForumMedia.Server\BZRForumMedia.Server\Views\KorisnikVesti\JednaVest.cshtml"
WriteAttributeValue("", 1262, Model.PutanjaDoSlike, 1262, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1284, "\"", 1303, 1);
#nullable restore
#line 32 "C:\Users\Andjelija\source\repos\BZRForumMedia.Server\BZRForumMedia.Server\Views\KorisnikVesti\JednaVest.cshtml"
WriteAttributeValue("", 1290, Model.Naslov, 1290, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> </div>\r\n                        <div class=\"blog_feature_cantant\">\r\n                            <p class=\"blog_head\">");
#nullable restore
#line 34 "C:\Users\Andjelija\source\repos\BZRForumMedia.Server\BZRForumMedia.Server\Views\KorisnikVesti\JednaVest.cshtml"
                                            Write(Model.Naslov);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            <div class=""post_info"">
                                <ul>
                                    <li><i class=""fa fa-user"" aria-hidden=""true""></i> Marketing</li>
                                    <li><i class=""fa fa-comment"" aria-hidden=""true""></i> 5</li>
                                    <li><i class=""fa fa-calendar"" aria-hidden=""true""></i> ");
#nullable restore
#line 39 "C:\Users\Andjelija\source\repos\BZRForumMedia.Server\BZRForumMedia.Server\Views\KorisnikVesti\JednaVest.cshtml"
                                                                                      Write(Model.DatumObjavljivanja.HasValue? Model.DatumObjavljivanja.Value.ToString("dd/MM/yyyy") : "Podatak ne postoji");

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                </ul>\r\n                            </div>\r\n                            <p>\r\n                               ");
#nullable restore
#line 43 "C:\Users\Andjelija\source\repos\BZRForumMedia.Server\BZRForumMedia.Server\Views\KorisnikVesti\JednaVest.cshtml"
                          Write(Html.Raw(@Model.Tekst));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </p>
                        </div>
                      
                        <div class=""bottom_info margin_bottom_30_all"">
                            <div class=""pull-right"">
                                <div class=""shr"">Share: </div>
                                <div class=""social_icon"">
                                    <ul>
                                        <li class=""fb""><a href=""#""><i class=""fa fa-facebook"" aria-hidden=""true""></i></a></li>
                                        <li class=""twi""><a href=""#""><i class=""fa fa-twitter"" aria-hidden=""true""></i></a></li>
                                        <li class=""gp""><a href=""#""><i class=""fa fa-google-plus"" aria-hidden=""true""></i></a></li>
                                        <li class=""pint""><a href=""#""><i class=""fa fa-pinterest"" aria-hidden=""true""></i></a></li>
                                    </ul>
                                </div>
                            </div>
        ");
            WriteLiteral(@"                </div>



                    </div>

                </div>
            </div>

            <div class=""col-lg-4 col-md-4 col-sm-12 col-xs-12 pull-left"">
                <div class=""side_bar"">
                    <div class=""side_bar_blog"">
                        <h4>Pretraga</h4>
                        <div class=""side_bar_search"">
                            <div class=""input-group stylish-input-group"">
                                <input class=""form-control"" placeholder=""Search"" type=""text"">
                                <span class=""input-group-addon"">
                                    <button type=""submit""><i class=""fa fa-search"" aria-hidden=""true""></i></button>
                                </span>
                            </div>
                        </div>
                    </div>
                    <div class=""side_bar_blog"">
                        <h4>Sažetak</h4>
                        <p>");
#nullable restore
#line 83 "C:\Users\Andjelija\source\repos\BZRForumMedia.Server\BZRForumMedia.Server\Views\KorisnikVesti\JednaVest.cshtml"
                      Write(Html.Raw(@Model.Sazetak));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        \r\n                    </div>\r\n                 \r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BZRForumMedia.Server.Models.Vest> Html { get; private set; }
    }
}
#pragma warning restore 1591
