#pragma checksum "C:\Users\RANA\source\repos\youaresafe\Views\Profile\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "af4758e58f97f8aa00e28a0dd4eb9fb4cb50e4bae9bfb177c37c32ccde3f87aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Index), @"mvc.1.0.view", @"/Views/Profile/Index.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\RANA\source\repos\youaresafe\Views\_ViewImports.cshtml"
using youaresafe

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\RANA\source\repos\youaresafe\Views\_ViewImports.cshtml"
using youaresafe.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"af4758e58f97f8aa00e28a0dd4eb9fb4cb50e4bae9bfb177c37c32ccde3f87aa", @"/Views/Profile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"893e2fc166331eb91cbb5487fdcfbe8fa1b384ec64a13497efd28190dffae8d4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Profile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Photo>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/styles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\RANA\source\repos\youaresafe\Views\Profile\Index.cshtml"
  
    ViewData["Title"] = "Profilim";
    Layout = null;

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af4758e58f97f8aa00e28a0dd4eb9fb4cb50e4bae9bfb177c37c32ccde3f87aa4494", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>");
                Write(
#nullable restore
#line 13 "C:\Users\RANA\source\repos\youaresafe\Views\Profile\Index.cshtml"
            ViewData["Title"]

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</title>\r\n    <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css\">\r\n    <link rel=\"stylesheet\" href=\"https://cdn.jsdelivr.net/npm/bootstrap-icons/font/bootstrap-icons.css\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "af4758e58f97f8aa00e28a0dd4eb9fb4cb50e4bae9bfb177c37c32ccde3f87aa5407", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n   \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af4758e58f97f8aa00e28a0dd4eb9fb4cb50e4bae9bfb177c37c32ccde3f87aa7321", async() => {
                WriteLiteral("\r\n    <div class=\"row gx-4 gx-lg-5 h-100 align-items-center justify-content-center text-center\">\r\n        <h1 class=\"text-white font-weight-bold\">Now, you are safe.</h1>\r\n        <p>Kullanıcı adı: ");
                Write(
#nullable restore
#line 22 "C:\Users\RANA\source\repos\youaresafe\Views\Profile\Index.cshtml"
                           User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</p>\r\n    </div>\r\n    <div class=\"row-container content\">\r\n");
#nullable restore
#line 25 "C:\Users\RANA\source\repos\youaresafe\Views\Profile\Index.cshtml"
         foreach (var photo in Model)
        {

#line default
#line hidden
#nullable disable

                WriteLiteral("            <div class=\"card\">\r\n                <img");
                BeginWriteAttribute("src", " src=\"", 953, "\"", 974, 1);
                WriteAttributeValue("", 959, 
#nullable restore
#line 28 "C:\Users\RANA\source\repos\youaresafe\Views\Profile\Index.cshtml"
                           photo.PhotoUrl

#line default
#line hidden
#nullable disable
                , 959, 15, false);
                EndWriteAttribute();
                WriteLiteral(" alt=\"Yüklenen Fotoğraf\" class=\"img-thumbnail\" />\r\n                <div class=\"song-recommendation\">\r\n                    <p>");
                Write(
#nullable restore
#line 30 "C:\Users\RANA\source\repos\youaresafe\Views\Profile\Index.cshtml"
                        photo.SongRecommendation

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"calendar-icon\">\r\n                    <i class=\"bi bi-calendar\"></i> ");
                Write(
#nullable restore
#line 33 "C:\Users\RANA\source\repos\youaresafe\Views\Profile\Index.cshtml"
                                                    photo.UploadedAt.ToShortDateString()

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 36 "C:\Users\RANA\source\repos\youaresafe\Views\Profile\Index.cshtml"
        }

#line default
#line hidden
#nullable disable

                WriteLiteral("    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<style>
    .row-container {
        display: flex;
        flex-wrap: wrap;
        justify-content: center;
    }

    .card {
        width: 100px;
        height: 100px;
        margin: 10px;
        display: flex;
        flex-direction: column;
        align-items: center;
    }

    .img-thumbnail {
        width: 75px;
        height: 75px;
        object-fit: cover;
    }

    .song-recommendation {
        text-align: center;
        margin-top: 5px;
    }

    .calendar-icon {
        font-size: 1rem;
        color: #555;
    }

    .body {
        background-image: url('../img/sunsetwalks'); /* Buraya arkaplan fotoğrafınızın URL'sini ekleyin */
        background-size: cover;
        background-position: center;
        background-repeat: no-repeat;
        height: 100vh;
        margin: 0;
        background-color: #212529;
    }

    .content {
        position: relative;
        z-index: 2;
        background: rgba(255, 255, 255, 0.8);
        p");
            WriteLiteral(@"adding: 20px;
        border-radius: 10px;
    }
</style>

<footer class=""bg-dark py-5"">
    <div class=""container px-4 px-lg-5"">
        <div class=""small text-center text-muted"">Copyright &copy; 2024 - You Are Safe.</div>
    </div>
</footer>
</html>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Photo>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
