#pragma checksum "C:\Users\bcces\Desktop\Tamamlanan Projeler\UniversityWeb\UniversityWeb\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a9e662c80e969cb1ae0164a97976530613ce3ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\bcces\Desktop\Tamamlanan Projeler\UniversityWeb\UniversityWeb\Views\_ViewImports.cshtml"
using UniversityWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bcces\Desktop\Tamamlanan Projeler\UniversityWeb\UniversityWeb\Views\_ViewImports.cshtml"
using UniversityWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a9e662c80e969cb1ae0164a97976530613ce3ce", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cafb2db96d8510ec3abe9ae7724ef1f3436e49b6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Announcement>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\bcces\Desktop\Tamamlanan Projeler\UniversityWeb\UniversityWeb\Views\Home\Index.cshtml"
  

    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
    <section class=""section main-banner"" id=""top"" data-section=""section1"">
        <video autoplay muted loop id=""bg-video"">
            <source src=""assets/images/course-video.mp4"" type=""video/mp4"" />
        </video>

        <div class=""video-overlay header-text"">
            <div class=""caption"">
                <h6>HOŞGELDİNİZ</h6>
                <h2><em>D</em>eğer<em><br />Ü</em>reten<br />Üniversite</h2>
                <div class=""main-button"">
                    <div class=""scroll-to-section""><a href=""#section4"">Duyurulara Gözat</a></div>
                </div>
            </div>
        </div>
    </section>


");
#nullable restore
#line 25 "C:\Users\bcces\Desktop\Tamamlanan Projeler\UniversityWeb\UniversityWeb\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("AnnouncementList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 63 "C:\Users\bcces\Desktop\Tamamlanan Projeler\UniversityWeb\UniversityWeb\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("/PartialView/Contact.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



    <!--
        
        PartialView'den çektiğimiz için Index'ten Contact
        bölümünü kaldırdık
        
        
        <section class=""section contact"" data-section=""section6"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""section-heading"">
                        <h2>Bizimle iletişime geçin</h2>
                    </div>
                </div>
                <div class=""col-md-6"">-->

                    <!-- Do you need a working HTML contact-form script?

                    Please visit https://templatemo.com/contact page -->

                    <!--<form id=""contact"" action="""" method=""post"">
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <fieldset>
                                    <input name=""name"" type=""text"" class=""form-control"" id=""name"" placeholder=""Ad Soyad"" required="""">
                ");
            WriteLiteral(@"                </fieldset>
                            </div>
                            <div class=""col-md-6"">
                                <fieldset>
                                    <input name=""email"" type=""text"" class=""form-control"" id=""email"" placeholder=""E-mail"" required="""">
                                </fieldset>
                            </div>
                            <div class=""col-md-12"">
                                <fieldset>
                                    <textarea name=""message"" rows=""6"" class=""form-control"" id=""message"" placeholder=""Mesaj..."" required=""""></textarea>
                                </fieldset>
                            </div>
                            <div class=""col-md-12"">
                                <fieldset>
                                    <button type=""submit"" id=""form-submit"" class=""button"">Send Message Now</button>
                                </fieldset>
                            </div>
                      ");
            WriteLiteral(@"  </div>
                    </form>
                </div>
                <div class=""col-md-6"">
                    <div id=""map"">
                        <iframe src=""https://maps.google.com/maps?q=Av.+L%C3%BAcio+Costa,+Rio+de+Janeiro+-+RJ,+Brazil&t=&z=13&ie=UTF8&iwloc=&output=embed"" width=""100%"" height=""422px"" frameborder=""0"" style=""border:0"" allowfullscreen></iframe>
                    </div>
                </div>
            </div>
        </div>
    </section>-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Announcement>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591