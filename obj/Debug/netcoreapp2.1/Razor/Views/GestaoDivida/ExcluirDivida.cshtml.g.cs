#pragma checksum "C:\Project\ConrtroleDividas\ConrtroleDividas\Views\GestaoDivida\ExcluirDivida.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39d57aabbf8e985807fcdc61e3c9a017bc789f33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GestaoDivida_ExcluirDivida), @"mvc.1.0.view", @"/Views/GestaoDivida/ExcluirDivida.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/GestaoDivida/ExcluirDivida.cshtml", typeof(AspNetCore.Views_GestaoDivida_ExcluirDivida))]
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
#line 1 "C:\Project\ConrtroleDividas\ConrtroleDividas\Views\_ViewImports.cshtml"
using ConrtroleDividas;

#line default
#line hidden
#line 2 "C:\Project\ConrtroleDividas\ConrtroleDividas\Views\_ViewImports.cshtml"
using ConrtroleDividas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39d57aabbf8e985807fcdc61e3c9a017bc789f33", @"/Views/GestaoDivida/ExcluirDivida.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a919f5ae9617fd35f2778f2614cf7ffe03271a6b", @"/Views/_ViewImports.cshtml")]
    public class Views_GestaoDivida_ExcluirDivida : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConrtroleDividas.Models.Dividas>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Web.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListarDividas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExcluirDivida", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Project\ConrtroleDividas\ConrtroleDividas\Views\GestaoDivida\ExcluirDivida.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(69, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(98, 818, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d702371fd56b4ee4969da89f310951f3", async() => {
                BeginContext(104, 67, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n\r\n    ");
                EndContext();
                BeginContext(171, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4d060de506b14dab969f9bfbcae6e17b", async() => {
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
                EndContext();
                BeginContext(217, 692, true);
                WriteLiteral(@"


    <!-- Latest compiled and minified CSS -->
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"">

    <!-- jQuery library -->
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>

    <!-- Popper JS -->
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js""></script>

    <!-- Latest compiled JavaScript -->
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js""></script>

    <!--Awesome Icons-->>
    <script src=""https://kit.fontawesome.com/a89251772b.js""></script>


    <title>Excluir divida</title>
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
            BeginContext(916, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(918, 2626, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e4734b1f33e4879bdd4dfffb86e5831", async() => {
                BeginContext(924, 53, true);
                WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n    <div class=\"sidenav\">\r\n\r\n\r\n        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 977, "\"", 1030, 1);
#line 43 "C:\Project\ConrtroleDividas\ConrtroleDividas\Views\GestaoDivida\ExcluirDivida.cshtml"
WriteAttributeValue("", 984, Url.Action("CadastrarDivida", "GestaoDivida"), 984, 46, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1031, 104, true);
                WriteLiteral(">\r\n            <i style=\'font-size:100px\' class=\"far fa-address-book\"></i>\r\n\r\n        </a>\r\n\r\n        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1135, "\"", 1186, 1);
#line 48 "C:\Project\ConrtroleDividas\ConrtroleDividas\Views\GestaoDivida\ExcluirDivida.cshtml"
WriteAttributeValue("", 1142, Url.Action("ListarDividas", "GestaoDivida"), 1142, 44, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1187, 96, true);
                WriteLiteral(">\r\n            <i style=\'font-size:100px\' class=\"fas fa-list\"></i>\r\n\r\n        </a>\r\n\r\n        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1283, "\"", 1334, 1);
#line 53 "C:\Project\ConrtroleDividas\ConrtroleDividas\Views\GestaoDivida\ExcluirDivida.cshtml"
WriteAttributeValue("", 1290, Url.Action("DetalheDivida", "GestaoDivida"), 1290, 44, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1335, 183, true);
                WriteLiteral(">\r\n            <i style=\'font-size:100px\' class=\"fas fa-wallet\"></i>\r\n\r\n        </a>\r\n\r\n    </div>\r\n\r\n\r\n    <div class=\"content02\">\r\n\r\n\r\n        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(1519, 22, false);
#line 65 "C:\Project\ConrtroleDividas\ConrtroleDividas\Views\GestaoDivida\ExcluirDivida.cshtml"
       Write(Html.Label("ID", "ID"));

#line default
#line hidden
                EndContext();
                BeginContext(1541, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1556, 79, false);
#line 66 "C:\Project\ConrtroleDividas\ConrtroleDividas\Views\GestaoDivida\ExcluirDivida.cshtml"
       Write(Html.TextBoxFor(m => m.id, new { @class = "form-control", @disabled = "true" }));

#line default
#line hidden
                EndContext();
                BeginContext(1635, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1650, 72, false);
#line 67 "C:\Project\ConrtroleDividas\ConrtroleDividas\Views\GestaoDivida\ExcluirDivida.cshtml"
       Write(Html.ValidationMessageFor(m => m.id, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(1722, 70, true);
                WriteLiteral("\r\n\r\n        </div>\r\n\r\n\r\n        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(1793, 26, false);
#line 73 "C:\Project\ConrtroleDividas\ConrtroleDividas\Views\GestaoDivida\ExcluirDivida.cshtml"
       Write(Html.Label("Nome", "Nome"));

#line default
#line hidden
                EndContext();
                BeginContext(1819, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1834, 81, false);
#line 74 "C:\Project\ConrtroleDividas\ConrtroleDividas\Views\GestaoDivida\ExcluirDivida.cshtml"
       Write(Html.TextBoxFor(m => m.Nome, new { @class = "form-control", @disabled = "true" }));

#line default
#line hidden
                EndContext();
                BeginContext(1915, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1930, 74, false);
#line 75 "C:\Project\ConrtroleDividas\ConrtroleDividas\Views\GestaoDivida\ExcluirDivida.cshtml"
       Write(Html.ValidationMessageFor(m => m.Nome, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(2004, 68, true);
                WriteLiteral("\r\n        </div>\r\n\r\n\r\n        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(2073, 43, false);
#line 80 "C:\Project\ConrtroleDividas\ConrtroleDividas\Views\GestaoDivida\ExcluirDivida.cshtml"
       Write(Html.Label("ValorProduto", "Valor Produto"));

#line default
#line hidden
                EndContext();
                BeginContext(2116, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(2131, 89, false);
#line 81 "C:\Project\ConrtroleDividas\ConrtroleDividas\Views\GestaoDivida\ExcluirDivida.cshtml"
       Write(Html.TextBoxFor(m => m.ValorProduto, new { @class = "form-control", @disabled = "true" }));

#line default
#line hidden
                EndContext();
                BeginContext(2220, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(2235, 82, false);
#line 82 "C:\Project\ConrtroleDividas\ConrtroleDividas\Views\GestaoDivida\ExcluirDivida.cshtml"
       Write(Html.ValidationMessageFor(m => m.ValorProduto, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(2317, 66, true);
                WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(2384, 58, false);
#line 86 "C:\Project\ConrtroleDividas\ConrtroleDividas\Views\GestaoDivida\ExcluirDivida.cshtml"
       Write(Html.Label("QuantidadeProdutos", "Quantidade de Produtos"));

#line default
#line hidden
                EndContext();
                BeginContext(2442, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(2457, 88, false);
#line 87 "C:\Project\ConrtroleDividas\ConrtroleDividas\Views\GestaoDivida\ExcluirDivida.cshtml"
       Write(Html.TextBoxFor(m => m.QtdeProduto, new { @class = "form-control", @disabled = "true" }));

#line default
#line hidden
                EndContext();
                BeginContext(2545, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(2560, 81, false);
#line 88 "C:\Project\ConrtroleDividas\ConrtroleDividas\Views\GestaoDivida\ExcluirDivida.cshtml"
       Write(Html.ValidationMessageFor(m => m.QtdeProduto, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(2641, 66, true);
                WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(2708, 54, false);
#line 92 "C:\Project\ConrtroleDividas\ConrtroleDividas\Views\GestaoDivida\ExcluirDivida.cshtml"
       Write(Html.Label("DescricaoProduto", "Descricao do Produto"));

#line default
#line hidden
                EndContext();
                BeginContext(2762, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(2777, 93, false);
#line 93 "C:\Project\ConrtroleDividas\ConrtroleDividas\Views\GestaoDivida\ExcluirDivida.cshtml"
       Write(Html.TextBoxFor(m => m.DescricaoProduto, new { @class = "form-control", @disabled = "true" }));

#line default
#line hidden
                EndContext();
                BeginContext(2870, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(2885, 86, false);
#line 94 "C:\Project\ConrtroleDividas\ConrtroleDividas\Views\GestaoDivida\ExcluirDivida.cshtml"
       Write(Html.ValidationMessageFor(m => m.DescricaoProduto, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(2971, 68, true);
                WriteLiteral("\r\n        </div>\r\n\r\n\r\n        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(3040, 41, false);
#line 99 "C:\Project\ConrtroleDividas\ConrtroleDividas\Views\GestaoDivida\ExcluirDivida.cshtml"
       Write(Html.Label("ValorDivida", "Valor Divida"));

#line default
#line hidden
                EndContext();
                BeginContext(3081, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(3096, 88, false);
#line 100 "C:\Project\ConrtroleDividas\ConrtroleDividas\Views\GestaoDivida\ExcluirDivida.cshtml"
       Write(Html.TextBoxFor(m => m.ValorDivida, new { @class = "form-control", @disabled = "true" }));

#line default
#line hidden
                EndContext();
                BeginContext(3184, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(3199, 81, false);
#line 101 "C:\Project\ConrtroleDividas\ConrtroleDividas\Views\GestaoDivida\ExcluirDivida.cshtml"
       Write(Html.ValidationMessageFor(m => m.ValorDivida, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(3280, 38, true);
                WriteLiteral("\r\n        </div>\r\n\r\n\r\n    \r\n\r\n\r\n\r\n    ");
                EndContext();
                BeginContext(3318, 205, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12b9613a96a34a73bed52e1783d748c2", async() => {
                    BeginContext(3351, 85, true);
                    WriteLiteral("\r\n        <input type=\"submit\" value=\"Excluir\" class=\"btn btn-primary\" /> |\r\n        ");
                    EndContext();
                    BeginContext(3436, 74, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89058e5d0d7e42a680d4c83c405ed434", async() => {
                        BeginContext(3490, 16, true);
                        WriteLiteral("Retornar a lista");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(3510, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3523, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
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
            BeginContext(3544, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConrtroleDividas.Models.Dividas> Html { get; private set; }
    }
}
#pragma warning restore 1591
