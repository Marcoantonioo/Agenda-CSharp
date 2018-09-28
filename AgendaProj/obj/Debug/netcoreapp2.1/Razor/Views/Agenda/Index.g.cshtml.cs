#pragma checksum "C:\Projeto- agenda\ProjAgenda\AgendaProj\Views\Agenda\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a68c219a9d3ae952bb8e6e708b79f8b65c4e667"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Agenda_Index), @"mvc.1.0.view", @"/Views/Agenda/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Agenda/Index.cshtml", typeof(AspNetCore.Views_Agenda_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a68c219a9d3ae952bb8e6e708b79f8b65c4e667", @"/Views/Agenda/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da0cadb683367e60e655c0d7f9861866db345af2", @"/Views/_ViewImports.cshtml")]
    public class Views_Agenda_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AgendaProj.Models.Agenda>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 1965, true);
            WriteLiteral(@"    <br>
	<nav class=""navbar navbar-default"">
		<div class=""container-fluid"">
			<div class=""navbar-header"">
				<button type=""button"" class=""navbar-toggle collapsed"" data-toggle=""collapse"" data-target=""#navbar"" aria-expanded=""false"" aria-controls=""navbar"">
					<span class=""sr-only"">Toggle navigation</span>
					<span class=""icon-bar""></span>
					<span class=""icon-bar""></span>
					<span class=""icon-bar""></span>
				</button>
				<a class=""navbar-brand"" href=""Agenda/Create"" class=""btn btn-primary"">Novo Chamado</a></a>
			</div>
			
			<div id=""navbar"" class=""navbar-collapse collapse"">
				<ul class=""nav navbar-nav"">
					
					<li class=""dropdown"">
						<a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-expanded=""false"">
							Ações <span class=""caret""></span>
						</a>
						<ul class=""dropdown-menu"" role=""menu"">
							<li>
								<a href=""Agenda/Create"">Novo Chamado</a>
								<a href=""Client/Create"">Novo Cliente</a>
							</li>
						</ul>
					");
            WriteLiteral(@"</li>
					<li class=""dropdown"">
						<a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-expanded=""false"">
							Listagem <span class=""caret""></span>
						</a>
						<ul class=""dropdown-menu"" role=""menu"">
							<li>
								<a href=""#"">Listar Chamados</a>
								<a href=""/client"">Listar Clientes</a>
							</li>
						</ul>
					</li>
					
				</ul>
			</div>
		</div>
	</nav>
				<h3 class=""panel-title text-center"">Chamadas Cadastradas</h3>
			
			
			<div class=""panel-body"">
				<div class=""table-responsive"">
					<table class=""table table-striped table-hover"">
						<thead>
							<tr>
								<th>Chamado</th>
								<th>Nome do Cliente</th>
								<th>Data</th>
								<th>Inicio do Chamado</th>
								<th>Término do Chamado</th>
								<th>Situacão</th>
								<th colspan=""3"">Duração</th>
								
								
							</tr>
						</thead>

						<tbody>
");
            EndContext();
#line 66 "C:\Projeto- agenda\ProjAgenda\AgendaProj\Views\Agenda\Index.cshtml"
                             foreach(var item in Model)
                         {

#line default
#line hidden
            BeginContext(2096, 26, true);
            WriteLiteral("\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t<td>#");
            EndContext();
            BeginContext(2123, 7, false);
#line 69 "C:\Projeto- agenda\ProjAgenda\AgendaProj\Views\Agenda\Index.cshtml"
                                Write(item.id);

#line default
#line hidden
            EndContext();
            BeginContext(2130, 19, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(2150, 16, false);
#line 70 "C:\Projeto- agenda\ProjAgenda\AgendaProj\Views\Agenda\Index.cshtml"
                               Write(item.client.nome);

#line default
#line hidden
            EndContext();
            BeginContext(2166, 19, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(2186, 32, false);
#line 71 "C:\Projeto- agenda\ProjAgenda\AgendaProj\Views\Agenda\Index.cshtml"
                               Write(item.data.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2218, 19, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(2238, 15, false);
#line 72 "C:\Projeto- agenda\ProjAgenda\AgendaProj\Views\Agenda\Index.cshtml"
                               Write(item.horaInicio);

#line default
#line hidden
            EndContext();
            BeginContext(2253, 19, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(2273, 12, false);
#line 73 "C:\Projeto- agenda\ProjAgenda\AgendaProj\Views\Agenda\Index.cshtml"
                               Write(item.horaFim);

#line default
#line hidden
            EndContext();
            BeginContext(2285, 19, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(2305, 12, false);
#line 74 "C:\Projeto- agenda\ProjAgenda\AgendaProj\Views\Agenda\Index.cshtml"
                               Write(item.sit.sit);

#line default
#line hidden
            EndContext();
            BeginContext(2317, 19, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(2337, 12, false);
#line 75 "C:\Projeto- agenda\ProjAgenda\AgendaProj\Views\Agenda\Index.cshtml"
                               Write(item.duracao);

#line default
#line hidden
            EndContext();
            BeginContext(2349, 95, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td></td>\r\n\t\t\t\t\t\t\t\t\r\n                                \r\n\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2444, "\"", 2471, 2);
            WriteAttributeValue("", 2451, "agenda/Edit/", 2451, 12, true);
#line 80 "C:\Projeto- agenda\ProjAgenda\AgendaProj\Views\Agenda\Index.cshtml"
WriteAttributeValue("", 2463, item.id, 2463, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2472, 143, true);
            WriteLiteral(" class=\"btn btn-info col-md-6\">\r\n\t\t\t\t\t\t\t\t\t\t<span class=\"glyphicon glyphicon-edit\" aria-hidden=\"true\"></span> Editar\r\n\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t\t<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2615, "\"", 2644, 2);
            WriteAttributeValue("", 2622, "agenda/Delete/", 2622, 14, true);
#line 83 "C:\Projeto- agenda\ProjAgenda\AgendaProj\Views\Agenda\Index.cshtml"
WriteAttributeValue("", 2636, item.id, 2636, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2645, 165, true);
            WriteLiteral(" class=\"btn btn-danger col-md-6\">\r\n\t\t\t\t\t\t\t\t\t\t<span class=\"glyphicon glyphicon-trash\" aria-hidden=\"true\"></span> Excluir\r\n\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t</tr>\r\n");
            EndContext();
#line 88 "C:\Projeto- agenda\ProjAgenda\AgendaProj\Views\Agenda\Index.cshtml"
                         } 

#line default
#line hidden
            BeginContext(2839, 28, true);
            WriteLiteral("</tbody></table></div></div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AgendaProj.Models.Agenda>> Html { get; private set; }
    }
}
#pragma warning restore 1591
