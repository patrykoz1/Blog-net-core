#pragma checksum "C:\Users\patryk\source\repos\Blog\Views\Dashboard\AddArticle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "725f047fc904b97093699db5d7b64ef98ed3c619"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_AddArticle), @"mvc.1.0.view", @"/Views/Dashboard/AddArticle.cshtml")]
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
#line 1 "C:\Users\patryk\source\repos\Blog\Views\_ViewImports.cshtml"
using Blog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\patryk\source\repos\Blog\Views\_ViewImports.cshtml"
using Blog.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\patryk\source\repos\Blog\Views\Dashboard\AddArticle.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"725f047fc904b97093699db5d7b64ef98ed3c619", @"/Views/Dashboard/AddArticle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60de8826b8954e9153bb5ddebbd8520bddd0a921", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_AddArticle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blog.ViewModels.ArticleVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\patryk\source\repos\Blog\Views\Dashboard\AddArticle.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ADD ARTICLE!!</h1>\r\n");
#nullable restore
#line 9 "C:\Users\patryk\source\repos\Blog\Views\Dashboard\AddArticle.cshtml"
 if (SignInManager.IsSignedIn(User))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 13 "C:\Users\patryk\source\repos\Blog\Views\Dashboard\AddArticle.cshtml"
             using (Html.BeginForm("Create", "Article"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col\">\r\n                    <div>Title</div>\r\n                    ");
#nullable restore
#line 16 "C:\Users\patryk\source\repos\Blog\Views\Dashboard\AddArticle.cshtml"
               Write(Html.TextBoxFor(x => x.Title, new { style = "width: 15em;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"w-100\"></div>\r\n                <div class=\"col\">\r\n                    <div>Content</div>\r\n                    ");
#nullable restore
#line 21 "C:\Users\patryk\source\repos\Blog\Views\Dashboard\AddArticle.cshtml"
               Write(Html.TextBoxFor(x => x.Content, new { style = "width: 30em; height:17em;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"w-100\"></div>\r\n                </div>\r\n                <div class=\"col\">\r\n                    <div>Category Id</div>\r\n                    ");
#nullable restore
#line 26 "C:\Users\patryk\source\repos\Blog\Views\Dashboard\AddArticle.cshtml"
               Write(Html.TextBoxFor(x => x.CategoryId, new { style = "width: 1em;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"w-100\"></div>\r\n                <br />\r\n                <div class=\"col\">\r\n                    <input type=\"submit\" class=\"btn btn-primary btn-sm\" value=\"Click\" />\r\n                </div>\r\n");
#nullable restore
#line 33 "C:\Users\patryk\source\repos\Blog\Views\Dashboard\AddArticle.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n");
#nullable restore
#line 36 "C:\Users\patryk\source\repos\Blog\Views\Dashboard\AddArticle.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blog.ViewModels.ArticleVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
