#pragma checksum "/Users/ben/Desktop/Dojo_assignments/C#/Dojo_Survey/Views/Home/Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca49abc0728b3768b7dbcb081e955a78bc44b3f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyApp.Namespace.Home.Views_Home_Result), @"mvc.1.0.view", @"/Views/Home/Result.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Result.cshtml", typeof(MyApp.Namespace.Home.Views_Home_Result))]
namespace MyApp.Namespace.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 3 "/Users/ben/Desktop/Dojo_assignments/C#/Dojo_Survey/Views/_ViewImports.cshtml"
using Dojo_Survey.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca49abc0728b3768b7dbcb081e955a78bc44b3f5", @"/Views/Home/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0260a8074dfcf655466b2832093e673cdf5263dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ninja>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(43, 34, true);
            WriteLiteral("\n<!DOCTYPE html>\n<html lang=\"en\">\n");
            EndContext();
            BeginContext(77, 366, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca49abc0728b3768b7dbcb081e955a78bc44b3f53286", async() => {
                BeginContext(83, 353, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
    <title>Submitted Info</title>
");
                EndContext();
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
            EndContext();
            BeginContext(443, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(444, 1310, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca49abc0728b3768b7dbcb081e955a78bc44b3f54811", async() => {
                BeginContext(450, 309, true);
                WriteLiteral(@"
    <div class=""container mt-4 p-4 border border-dark"">
        <h3 class=""mb-4""><u>Submitted Info</u></h3>
            <div class=""form-group d-flex justify-content-start"">
                <label class=""col-6"" for=""Name"">Name:</label>
                <output class=""col-6"" type=""text"" name=""Name"" id=""Name"">");
                EndContext();
                BeginContext(760, 10, false);
#line 17 "/Users/ben/Desktop/Dojo_assignments/C#/Dojo_Survey/Views/Home/Result.cshtml"
                                                                   Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(770, 250, true);
                WriteLiteral("</output>\n            </div>\n            <div class=\"form-group d-flex justify-content-start\">\n                <label class=\"col-6\" for=\"Location\">Dojo Location:</label>\n                <output class=\"col-6\" type=\"text\" name=\"Location\" id=\"Location\">");
                EndContext();
                BeginContext(1021, 14, false);
#line 21 "/Users/ben/Desktop/Dojo_assignments/C#/Dojo_Survey/Views/Home/Result.cshtml"
                                                                           Write(Model.Location);

#line default
#line hidden
                EndContext();
                BeginContext(1035, 253, true);
                WriteLiteral("</output>\n            </div>\n            <div class=\"form-group d-flex justify-content-start\">\n                <label class=\"col-6\" for=\"Language\">Favorite Language</label>\n                <output class=\"col-6\" type=\"text\" name=\"Location\" id=\"Language\">");
                EndContext();
                BeginContext(1289, 14, false);
#line 25 "/Users/ben/Desktop/Dojo_assignments/C#/Dojo_Survey/Views/Home/Result.cshtml"
                                                                           Write(Model.Language);

#line default
#line hidden
                EndContext();
                BeginContext(1303, 240, true);
                WriteLiteral("</output>\n            </div>\n            <div class=\"form-group d-flex justify-content-start\">\n                <label class=\"col-6\" for=\"Comment\">Comment</label>\n                <output class=\"col-6\" type=\"text\" name=\"Comment\" id=\"Comment\">");
                EndContext();
                BeginContext(1544, 13, false);
#line 29 "/Users/ben/Desktop/Dojo_assignments/C#/Dojo_Survey/Views/Home/Result.cshtml"
                                                                         Write(Model.Comment);

#line default
#line hidden
                EndContext();
                BeginContext(1557, 190, true);
                WriteLiteral("</output>\n            </div>\n            <div class=\"form-group d-flex justify-content-end\">\n                <a href=\"/\" class=\"btn btn-primary\">Go Back</a>\n            </div>\n    </div>   \n");
                EndContext();
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
            EndContext();
            BeginContext(1754, 8, true);
            WriteLiteral("\n</html>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ninja> Html { get; private set; }
    }
}
#pragma warning restore 1591
