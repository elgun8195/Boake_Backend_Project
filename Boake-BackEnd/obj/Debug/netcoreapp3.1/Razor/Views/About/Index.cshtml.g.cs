#pragma checksum "C:\Users\hp\Desktop\Boake-BackEnd\Boake-BackEnd\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40e8a1f60225f34ce02d9124c99125d1b3bb8333"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
#line 1 "C:\Users\hp\Desktop\Boake-BackEnd\Boake-BackEnd\Views\_ViewImports.cshtml"
using Boake_BackEnd.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Desktop\Boake-BackEnd\Boake-BackEnd\Views\_ViewImports.cshtml"
using Boake_BackEnd.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40e8a1f60225f34ce02d9124c99125d1b3bb8333", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5fd6bb7c7335018762291f9a99db59597b2b892", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<About>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("  text-decoration-none text-white work-sans hover2 t-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\hp\Desktop\Boake-BackEnd\Boake-BackEnd\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--====== Breadcrumb-Area Start ======-->\r\n\r\n<section class=\"breadcrumb-area py-5 py-sm-0\">\r\n    <div class=\" bg-shade text-center py-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40e8a1f60225f34ce02d9124c99125d1b3bb83334504", async() => {
                WriteLiteral("HOME ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <span class="" text-white"">/</span>
        <span class="" text-white work-sans"">ABOUT US</span>
    </div>
</section>

<!--====== Breadcrumb-Area End ======-->
<!--====== Banner-Area Start ======-->
<div class=""banner-area py-5"">
    <div class=""container"">
        <div class=""row align-items-center justify-content-between"">
            <div class=""col-lg-5 col-12 position-relative"">
                <a");
            BeginWriteAttribute("href", " href=\"", 793, "\"", 800, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 828, "\"", 866, 2);
            WriteAttributeValue("", 834, "assets/img/about/", 834, 17, true);
#nullable restore
#line 24 "C:\Users\hp\Desktop\Boake-BackEnd\Boake-BackEnd\Views\About\Index.cshtml"
WriteAttributeValue("", 851, Model.ImageUrl, 851, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"w-100\"");
            BeginWriteAttribute("alt", " alt=\"", 881, "\"", 887, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </a>
                <a class=""text-decoration-none banner-video "" href=""#myModal"" data-toggle=""modal"">
                    <i class=""fas fa-play""></i>
                </a>
            </div>
            <div class=""col-lg-6 col-12 banner-content"">
                <h2 class=""work-sans text-fusion position-relative"">");
#nullable restore
#line 31 "C:\Users\hp\Desktop\Boake-BackEnd\Boake-BackEnd\Views\About\Index.cshtml"
                                                               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <p class=\"work-sans text-white fs-5 pt-4\">\r\n                   ");
#nullable restore
#line 33 "C:\Users\hp\Desktop\Boake-BackEnd\Boake-BackEnd\Views\About\Index.cshtml"
              Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </p>
            </div>
        </div>
    </div>
</div>
<!--====== Banner-Area End ======-->
<!--====== Testimonials-Area Start ======-->
<div class=""testimonial-area py-5"" style=""background: url(assets/img/banner/banner.png);"">
    <div class=""container"">
        <div class=""section-title text-center text-white work-sans py-5"">
            <h2>What Clients Says</h2>
            <p>Contrary to popular belief, Lorem Ipsum is not simply random.</p>
        </div>
        <div class=""row"">
            <div class=""col-lg-10 mx-auto position-relative"">
                <div class=""about-testimonials-slider"">
                    <div class=""single-testimonial text-center "">
                        <img src=""assets/img/testimonial/testimonial2.png"" class=""m-auto """);
            BeginWriteAttribute("alt", " alt=\"", 2157, "\"", 2163, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <p class=""text-white w-75 work-sans py-4 m-auto"">Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat Duis aute irure dolor in reprehenderit.</p>
                        <h5 class=""text-white"">Hester Perkins</h5>
                    </div>
                    <div class=""single-testimonial text-center "">
                        <img src=""assets/img/testimonial/testimonial2.png"" class=""m-auto """);
            BeginWriteAttribute("alt", " alt=\"", 2770, "\"", 2776, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <p class=""text-white w-75 work-sans py-4 m-auto"">Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat Duis aute irure dolor in reprehenderit.</p>
                        <h5 class=""text-white"">Hester Perkins</h5>
                    </div>
                </div>
                <div class=""slick-dots-testimonial ""></div>
            </div>
        </div>
    </div>
</div>
<!--====== Testimonials-Area End ======-->
<!--====== Team-Area Start ======-->
<div class=""team-area py-5"">
    <div class=""container"">
        <div class=""section-title text-center text-white "">
            <h2>Awesome Team</h2>
            <p>Contrary to popular belief, Lorem Ipsum is not simply random.</p>
        </div>
        <div class=""py-5"">
            <div class=""container position-relative olo5"">
           ");
            WriteLiteral(@"     <div class=""row team-slider"">
                    <div class=""card mx-3"">
                        <img class=""card-img-top"" src=""assets/img/team/team1.png"" style=""cursor: pointer;"" alt=""Card image cap"">
                        <div class=""card-body text-center"">
                            <h4 class=""card-title geometric ls-1 fw-normal"">Mr. Mike Banding</h4>
                            <span><em>Manager</em></span>
                        </div>
                        <div class=""team-socials text-center w-100 py-2 bg-white"">
                            <a href=""https://www.facebook.com/"" target=""_blank"" class=""bg-facebook text-decoration-none text-white work-sans hover-facebook t-5 "">
                                <i class=""fa-brands fa-facebook-f""></i>
                            </a>
                            <a href=""https://www.twitter.com/"" target=""_blank"" class=""bg-twitter text-decoration-none text-white work-sans hover-twitter t-5"">
                                <i class=""fa-br");
            WriteLiteral(@"ands fa-twitter""></i>
                            </a>
                            <a href=""https://www.instagram.com/"" target=""_blank"" class=""bg-instagram text-decoration-none text-white work-sans hover-instagram t-5 "">
                                <i class=""fa-brands fa-instagram""></i>
                            </a>
                        </div>
                    </div>
                    <div class=""card mx-3"">
                        <img class=""card-img-top"" src=""assets/img/team/team2.png"" style=""cursor: pointer;"" alt=""Card image cap"">
                        <div class=""card-body text-center"">
                            <h4 class=""card-title geometric ls-1 fw-normal"">Mr. Peter Pan</h4>
                            <span><em>Developer</em></span>
                        </div>
                        <div class=""team-socials text-center w-100 py-2 bg-white"">
                            <a href=""https://www.facebook.com/"" target=""_blank"" class=""bg-facebook text-decoration-none text-");
            WriteLiteral(@"white work-sans hover-facebook t-5 "">
                                <i class=""fa-brands fa-facebook-f""></i>
                            </a>
                            <a href=""https://www.twitter.com/"" target=""_blank"" class=""bg-twitter text-decoration-none text-white work-sans hover-twitter t-5"">
                                <i class=""fa-brands fa-twitter""></i>
                            </a>
                            <a href=""https://www.instagram.com/"" target=""_blank"" class=""bg-instagram text-decoration-none text-white work-sans hover-instagram t-5 "">
                                <i class=""fa-brands fa-instagram""></i>
                            </a>
                        </div>
                    </div>
                    <div class=""card mx-3"">
                        <img class=""card-img-top"" src=""assets/img/team/team3.png"" style=""cursor: pointer;"" alt=""Card image cap"">
                        <div class=""card-body text-center"">
                            <h4 class=""card-t");
            WriteLiteral(@"itle geometric ls-1 fw-normal"">Ms. Sophia</h4>
                            <span><em>Designer</em></span>
                        </div>
                        <div class=""team-socials text-center w-100 py-2 bg-white"">
                            <a href=""https://www.facebook.com/"" target=""_blank"" class=""bg-facebook text-decoration-none text-white work-sans hover-facebook t-5 "">
                                <i class=""fa-brands fa-facebook-f""></i>
                            </a>
                            <a href=""https://www.twitter.com/"" target=""_blank"" class=""bg-twitter text-decoration-none text-white work-sans hover-twitter t-5"">
                                <i class=""fa-brands fa-twitter""></i>
                            </a>
                            <a href=""https://www.instagram.com/"" target=""_blank"" class=""bg-instagram text-decoration-none text-white work-sans hover-instagram t-5 "">
                                <i class=""fa-brands fa-instagram""></i>
                          ");
            WriteLiteral(@"  </a>
                        </div>
                    </div>
                    <div class=""card mx-3"">
                        <img class=""card-img-top"" src=""assets/img/team/team4.png"" style=""cursor: pointer;"" alt=""Card image cap"">
                        <div class=""card-body text-center"">
                            <h4 class=""card-title geometric ls-1 fw-normal"">Mr. John Lee</h4>
                            <span><em>Chairmen</em></span>
                        </div>
                        <div class=""team-socials text-center w-100 py-2 bg-white"">
                            <a href=""https://www.facebook.com/"" target=""_blank"" class=""bg-facebook text-decoration-none text-white work-sans hover-facebook t-5 "">
                                <i class=""fa-brands fa-facebook-f""></i>
                            </a>
                            <a href=""https://www.twitter.com/"" target=""_blank"" class=""bg-twitter text-decoration-none text-white work-sans hover-twitter t-5"">
                  ");
            WriteLiteral(@"              <i class=""fa-brands fa-twitter""></i>
                            </a>
                            <a href=""https://www.instagram.com/"" target=""_blank"" class=""bg-instagram text-decoration-none text-white work-sans hover-instagram t-5 "">
                                <i class=""fa-brands fa-instagram""></i>
                            </a>
                        </div>
                    </div>
                    <div class=""card mx-3"">
                        <img class=""card-img-top"" src=""assets/img/team/team5.png"" style=""cursor: pointer;"" alt=""Card image cap"">
                        <div class=""card-body text-center"">
                            <h4 class=""card-title geometric ls-1 fw-normal"">Mr. Mike Banding</h4>
                            <span><em>Manager</em></span>
                        </div>
                        <div class=""team-socials text-center w-100 py-2 bg-white"">
                            <a href=""https://www.facebook.com/"" target=""_blank"" class=""bg-faceb");
            WriteLiteral(@"ook text-decoration-none text-white work-sans hover-facebook t-5 "">
                                <i class=""fa-brands fa-facebook-f""></i>
                            </a>
                            <a href=""https://www.twitter.com/"" target=""_blank"" class=""bg-twitter text-decoration-none text-white work-sans hover-twitter t-5"">
                                <i class=""fa-brands fa-twitter""></i>
                            </a>
                            <a href=""https://www.instagram.com/"" target=""_blank"" class=""bg-instagram text-decoration-none text-white work-sans hover-instagram t-5 "">
                                <i class=""fa-brands fa-instagram""></i>
                            </a>
                        </div>
                    </div>
                </div>
                <div class=""prev-team hover3 t-5 pa-col "">
                    <i class=""fa-solid fa-chevron-left  work-sans"" style=""cursor: pointer;""></i>
                </div>
                <div class=""next-team hover3 ");
            WriteLiteral("t-5  pa1-col\">\r\n                    <i class=\"fa-solid fa-chevron-right work-sans\" style=\"cursor: pointer;\"></i>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!--====== Team-Area End ======-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<About> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
