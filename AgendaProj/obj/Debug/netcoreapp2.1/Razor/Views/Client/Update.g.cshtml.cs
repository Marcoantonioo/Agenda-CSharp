#pragma checksum "C:\Projeto- agenda\ProjAgenda\AgendaProj\Views\Client\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f654fdd6c4dd8b42ffa7e99c1a6aefd22e9a773b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_Update), @"mvc.1.0.view", @"/Views/Client/Update.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Client/Update.cshtml", typeof(AspNetCore.Views_Client_Update))]
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
#line 1 "C:\Projeto- agenda\ProjAgenda\AgendaProj\Views\_ViewImports.cshtml"
using AgendaProj;

#line default
#line hidden
#line 2 "C:\Projeto- agenda\ProjAgenda\AgendaProj\Views\_ViewImports.cshtml"
using AgendaProj.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f654fdd6c4dd8b42ffa7e99c1a6aefd22e9a773b", @"/Views/Client/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da0cadb683367e60e655c0d7f9861866db345af2", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AgendaProj.Models.Client>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Update"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 76, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    <h3>Editar Cliente</h3>\r\n\r\n    <br>\r\n\r\n    ");
            EndContext();
            BeginContext(109, 1206, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31db1b9efcc7401a9537a92a7c9ab140", async() => {
                BeginContext(145, 222, true);
                WriteLiteral("\r\n\r\n        <div class=\"col-md-5\">\r\n\r\n        <div class=\"row\">\r\n            <div class=\"form-group col-md-12\">\r\n                <label for=\"id\">Id</label>\r\n                <input class=\"form-control\" type=\"text\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 367, "\"", 384, 1);
#line 16 "C:\Projeto- agenda\ProjAgenda\AgendaProj\Views\Client\Update.cshtml"
WriteAttributeValue("", 375, Model.id, 375, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(385, 241, true);
                WriteLiteral(" readonly>\r\n            </div>\r\n        </div> \r\n\r\n        <div class=\"row\">\r\n            <div class=\"form-group col-md-12\">\r\n                <label for=\"nome\">Nome</label>\r\n                <input class=\"form-control\" type=\"text\" name=\"nome\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 626, "\"", 645, 1);
#line 23 "C:\Projeto- agenda\ProjAgenda\AgendaProj\Views\Client\Update.cshtml"
WriteAttributeValue("", 634, Model.nome, 634, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(646, 239, true);
                WriteLiteral(">\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"form-group col-md-12\">\r\n                <label for=\"telefone\">Telefone</label>\r\n                <input class=\"form-control\" type=\"text\" name=\"fone\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 885, "\"", 904, 1);
#line 30 "C:\Projeto- agenda\ProjAgenda\AgendaProj\Views\Client\Update.cshtml"
WriteAttributeValue("", 893, Model.fone, 893, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(905, 235, true);
                WriteLiteral(">\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"form-group col-md-12\">\r\n                <label for=\"email\">E-mail</label>\r\n                <input class=\"form-control\" type=\"text\" name=\"email\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1140, "\"", 1160, 1);
#line 37 "C:\Projeto- agenda\ProjAgenda\AgendaProj\Views\Client\Update.cshtml"
WriteAttributeValue("", 1148, Model.email, 1148, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1161, 147, true);
                WriteLiteral(">\r\n            </div>\r\n        </div>\r\n\r\n        <input class=\"btn btn-primary\" type=\"submit\" value=\"Salvar Alterações\"/>\r\n\r\n        </div>\r\n\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1315, 10, true);
            WriteLiteral("\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AgendaProj.Models.Client> Html { get; private set; }
    }
}
#pragma warning restore 1591
