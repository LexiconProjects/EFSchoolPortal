#pragma checksum "F:\Lexicon offline Projects\EFSchoolPortal\EFSchoolPortal\Views\Teachers\RegisterTeacher.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1773832058ce0493aa11382a7f60e031cc190cf0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teachers_RegisterTeacher), @"mvc.1.0.view", @"/Views/Teachers/RegisterTeacher.cshtml")]
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
#line 1 "F:\Lexicon offline Projects\EFSchoolPortal\EFSchoolPortal\Views\_ViewImports.cshtml"
using EFSchoolPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "F:\Lexicon offline Projects\EFSchoolPortal\EFSchoolPortal\Views\Teachers\RegisterTeacher.cshtml"
using EFSchoolPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1773832058ce0493aa11382a7f60e031cc190cf0", @"/Views/Teachers/RegisterTeacher.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd642232ac4bf06f6f8daf835a9a2faf03a979c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Teachers_RegisterTeacher : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EFSchoolPortal.Models.Teacher>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<h1 class=\"text-center\">Here you can register to become a teacher!</h1>\r\n<br />\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <div class=\"form-gorup form-horizontal\">\r\n");
#nullable restore
#line 19 "F:\Lexicon offline Projects\EFSchoolPortal\EFSchoolPortal\Views\Teachers\RegisterTeacher.cshtml"
                 using (Html.BeginForm("RegisterTeacher", "Teachers", 1))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n                    <div class=\"form-gorup\">\r\n                        ");
#nullable restore
#line 23 "F:\Lexicon offline Projects\EFSchoolPortal\EFSchoolPortal\Views\Teachers\RegisterTeacher.cshtml"
                   Write(Html.Label("Fname", "First Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 24 "F:\Lexicon offline Projects\EFSchoolPortal\EFSchoolPortal\Views\Teachers\RegisterTeacher.cshtml"
                   Write(Html.TextBoxFor(x => x.Fname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-gorup\">\r\n                        ");
#nullable restore
#line 27 "F:\Lexicon offline Projects\EFSchoolPortal\EFSchoolPortal\Views\Teachers\RegisterTeacher.cshtml"
                   Write(Html.Label("Lname", "Last Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 28 "F:\Lexicon offline Projects\EFSchoolPortal\EFSchoolPortal\Views\Teachers\RegisterTeacher.cshtml"
                   Write(Html.TextBoxFor(x => x.Lname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-gorup\">\r\n                        ");
#nullable restore
#line 31 "F:\Lexicon offline Projects\EFSchoolPortal\EFSchoolPortal\Views\Teachers\RegisterTeacher.cshtml"
                   Write(Html.Label("Email"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 32 "F:\Lexicon offline Projects\EFSchoolPortal\EFSchoolPortal\Views\Teachers\RegisterTeacher.cshtml"
                   Write(Html.TextBoxFor(x => x.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-gorup\">\r\n                        ");
#nullable restore
#line 35 "F:\Lexicon offline Projects\EFSchoolPortal\EFSchoolPortal\Views\Teachers\RegisterTeacher.cshtml"
                   Write(Html.Label("CourseId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <select name=\"courseId\" id=\"CourseId\">\r\n");
#nullable restore
#line 37 "F:\Lexicon offline Projects\EFSchoolPortal\EFSchoolPortal\Views\Teachers\RegisterTeacher.cshtml"
                             foreach(var opt in ViewBag.CoursesDL as List<SelectListItem>)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1773832058ce0493aa11382a7f60e031cc190cf06546", async() => {
#nullable restore
#line 39 "F:\Lexicon offline Projects\EFSchoolPortal\EFSchoolPortal\Views\Teachers\RegisterTeacher.cshtml"
                                                    Write(opt.Text);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "F:\Lexicon offline Projects\EFSchoolPortal\EFSchoolPortal\Views\Teachers\RegisterTeacher.cshtml"
                                  WriteLiteral(opt.Value);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 40 "F:\Lexicon offline Projects\EFSchoolPortal\EFSchoolPortal\Views\Teachers\RegisterTeacher.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </select>\r\n                    </div>\r\n\r\n");
            WriteLiteral("                    \r\n\r\n                    <div>\r\n                        <input type=\"submit\" value=\"Register\" />\r\n                    </div>\r\n\r\n                    </div>\r\n");
#nullable restore
#line 73 "F:\Lexicon offline Projects\EFSchoolPortal\EFSchoolPortal\Views\Teachers\RegisterTeacher.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                
        <div class=""col"">
            <h1>List of active courses:</h1>
            <div id=""no-more-tables"">
                <table class=""col-md-12 table-bordered table-striped table-condensed cf"">
                    <thead class=""cf"">
                        <tr>
                            <th>
                                ID
                            </th>
                            <th>
                                Acronym
                            </th>
                            <th>
                                Topic Name
                            </th>

                        </tr>

                    </thead>
                    <tbody>
");
#nullable restore
#line 96 "F:\Lexicon offline Projects\EFSchoolPortal\EFSchoolPortal\Views\Teachers\RegisterTeacher.cshtml"
                         foreach (var item in ViewBag.CoursesList as List<Course>)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td data-title=\"Course Id\">\r\n                                    ");
#nullable restore
#line 100 "F:\Lexicon offline Projects\EFSchoolPortal\EFSchoolPortal\Views\Teachers\RegisterTeacher.cshtml"
                               Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n\r\n                                <td data-title=\"Acronym\">\r\n                                    ");
#nullable restore
#line 104 "F:\Lexicon offline Projects\EFSchoolPortal\EFSchoolPortal\Views\Teachers\RegisterTeacher.cshtml"
                               Write(item.Acronym);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td data-title=\"Topic\">\r\n                                    ");
#nullable restore
#line 107 "F:\Lexicon offline Projects\EFSchoolPortal\EFSchoolPortal\Views\Teachers\RegisterTeacher.cshtml"
                               Write(item.Topic);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 111 "F:\Lexicon offline Projects\EFSchoolPortal\EFSchoolPortal\Views\Teachers\RegisterTeacher.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n</div>\r\n</div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EFSchoolPortal.Models.Teacher> Html { get; private set; }
    }
}
#pragma warning restore 1591
