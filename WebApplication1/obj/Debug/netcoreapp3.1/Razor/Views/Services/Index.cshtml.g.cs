#pragma checksum "C:\Users\Abdulla Rahimli\Desktop\Code Academy\Programming 24.01.2022 -\Group P 225\BackEnd\Home Tasks\Eterna\WebApplication1\Views\Services\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b4d9c68ccb695aa388c0327594b5ae30ea7b943"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Services_Index), @"mvc.1.0.view", @"/Views/Services/Index.cshtml")]
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
#line 2 "C:\Users\Abdulla Rahimli\Desktop\Code Academy\Programming 24.01.2022 -\Group P 225\BackEnd\Home Tasks\Eterna\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Abdulla Rahimli\Desktop\Code Academy\Programming 24.01.2022 -\Group P 225\BackEnd\Home Tasks\Eterna\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b4d9c68ccb695aa388c0327594b5ae30ea7b943", @"/Views/Services/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d84b04bdf0e5ab555df43e3b8fe96c988c5c501", @"/Views/_ViewImports.cshtml")]
    public class Views_Services_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Service>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Abdulla Rahimli\Desktop\Code Academy\Programming 24.01.2022 -\Group P 225\BackEnd\Home Tasks\Eterna\WebApplication1\Views\Services\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- ======= Breadcrumbs ======= -->
<section id=""breadcrumbs"" class=""breadcrumbs"">
    <div class=""container"">

        <ol>
            <li><a href=""index.html"">Home</a></li>
            <li>Services</li>
        </ol>
        <h2>Services</h2>

    </div>
</section><!-- End Breadcrumbs -->
<!-- ======= Services Section ======= -->
<section id=""services"" class=""services"">
    <div class=""container"">

        <div class=""row"">

");
#nullable restore
#line 24 "C:\Users\Abdulla Rahimli\Desktop\Code Academy\Programming 24.01.2022 -\Group P 225\BackEnd\Home Tasks\Eterna\WebApplication1\Views\Services\Index.cshtml"
             foreach (Service service in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-6 d-flex align-items-stretch mt-4 mt-md-0\">\r\n                    <div class=\"icon-box\">\r\n                        <div class=\"icon\">");
#nullable restore
#line 28 "C:\Users\Abdulla Rahimli\Desktop\Code Academy\Programming 24.01.2022 -\Group P 225\BackEnd\Home Tasks\Eterna\WebApplication1\Views\Services\Index.cshtml"
                                     Write(Html.Raw(service.Icon));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <h4><a");
            BeginWriteAttribute("href", " href=\"", 816, "\"", 823, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 29 "C:\Users\Abdulla Rahimli\Desktop\Code Academy\Programming 24.01.2022 -\Group P 225\BackEnd\Home Tasks\Eterna\WebApplication1\Views\Services\Index.cshtml"
                                  Write(service.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                        <p>");
#nullable restore
#line 30 "C:\Users\Abdulla Rahimli\Desktop\Code Academy\Programming 24.01.2022 -\Group P 225\BackEnd\Home Tasks\Eterna\WebApplication1\Views\Services\Index.cshtml"
                      Write(service.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 33 "C:\Users\Abdulla Rahimli\Desktop\Code Academy\Programming 24.01.2022 -\Group P 225\BackEnd\Home Tasks\Eterna\WebApplication1\Views\Services\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


        </div>

    </div>
</section><!-- End Services Section -->
<!-- ======= Our Skills Section ======= -->
<section id=""skills"" class=""skills"">
    <div class=""container"">

        <div class=""section-title"">
            <h2>Our Skills</h2>
            <p>Magnam dolores commodi suscipit. Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit sint consectetur velit. Quisquam quos quisquam cupiditate. Et nemo qui impedit suscipit alias ea. Quia fugiat sit in iste officiis commodi quidem hic quas.</p>
        </div>

        <div class=""row"">
            <div class=""col-lg-6"">
                <img src=""assets/img/skills-img.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 1655, "\"", 1661, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            </div>
            <div class=""col-lg-6 pt-4 pt-lg-0 content"">
                <h3>Voluptatem dignissimos provident quasi corporis voluptates</h3>
                <p class=""fst-italic"">
                    Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt direna past reda
                </p>

                <div class=""skills-content"">

                    <div class=""progress"">
                        <span class=""skill"">HTML <i class=""val"">100%</i></span>
                        <div class=""progress-bar-wrap"">
                            <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""100"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                        </div>
                    </div>

                    <div class=""progress"">
                        <span class=""skill"">CSS <i class=""val"">90%</i></span>
                        <div class=""progress-bar-wrap"">
                            <div class=""progress-bar"" ro");
            WriteLiteral(@"le=""progressbar"" aria-valuenow=""90"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                        </div>
                    </div>

                    <div class=""progress"">
                        <span class=""skill"">JavaScript <i class=""val"">75%</i></span>
                        <div class=""progress-bar-wrap"">
                            <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""75"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                        </div>
                    </div>

                    <div class=""progress"">
                        <span class=""skill"">Photoshop <i class=""val"">55%</i></span>
                        <div class=""progress-bar-wrap"">
                            <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""55"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                        </div>
                    </div>

                </div>

            </div>
        </div>

    </div>
</section><!-- End Our Skills S");
            WriteLiteral("ection -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Service>> Html { get; private set; }
    }
}
#pragma warning restore 1591