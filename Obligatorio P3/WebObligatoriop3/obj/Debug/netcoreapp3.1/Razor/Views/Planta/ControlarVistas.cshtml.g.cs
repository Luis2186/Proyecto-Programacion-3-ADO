#pragma checksum "C:\Users\lilp_\Desktop\ORT\Programacion 3\ObligatorioP3Resp- 24-04\WebObligatoriop3\Views\Planta\ControlarVistas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d6416ebb807ccea59f340226084158f8ab07a81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Planta_ControlarVistas), @"mvc.1.0.view", @"/Views/Planta/ControlarVistas.cshtml")]
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
#line 1 "C:\Users\lilp_\Desktop\ORT\Programacion 3\ObligatorioP3Resp- 24-04\WebObligatoriop3\Views\_ViewImports.cshtml"
using WebObligatoriop3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lilp_\Desktop\ORT\Programacion 3\ObligatorioP3Resp- 24-04\WebObligatoriop3\Views\_ViewImports.cshtml"
using WebObligatoriop3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d6416ebb807ccea59f340226084158f8ab07a81", @"/Views/Planta/ControlarVistas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"147efde788029b96d996e8ef8ca41739e3604884", @"/Views/_ViewImports.cshtml")]
    public class Views_Planta_ControlarVistas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebObligatoriop3.Models.ViewModelPlanta>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("formulario mt-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h1 class=\"mt-5\"> Criterios De Busqueda </h1>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d6416ebb807ccea59f340226084158f8ab07a814118", async() => {
                WriteLiteral(@"
    <ol class=""list-group list-group-numbered"">
        <li class=""list-group-item d-flex justify-content-between align-items-start list-group-item-primary"">
            
            <div class=""ms-2 me-auto"">
                <div class=""fw-bold my-2 ""><a href=""/Planta/PlantaPorTextoEnNombre"" class=""btn btn-light""> Por Nombre </a></div>
                <svg xmlns=""http://www.w3.org/2000/svg"" width=""25"" height=""25"" fill=""currentColor"" class=""bi bi-search mr-2"" viewBox=""0 0 16 16"">
                    <path d=""M11.742 10.344a6.5 6.5 0 1 0-1.397 1.398h-.001c.03.04.062.078.098.115l3.85 3.85a1 1 0 0 0 1.415-1.414l-3.85-3.85a1.007 1.007 0 0 0-.115-.1zM12 6.5a5.5 5.5 0 1 1-11 0 5.5 5.5 0 0 1 11 0z"" />
                </svg>
                Busque la planta por el nombre científico o alguno de sus nombres vulgares.
                <i class=""bi bi-search""></i>
            </div>
        </li>
        <li class=""list-group-item d-flex justify-content-between align-items-start"">
            <div class=""ms");
                WriteLiteral(@"-2 me-auto"">
                <div class=""fw-bold my-2""> <a href=""/Planta/PlantasPorTipo"" class=""btn btn-secondary""> Por Tipo de Planta </a> </div>
                <svg xmlns=""http://www.w3.org/2000/svg"" width=""25"" height=""25"" fill=""currentColor"" class=""bi bi-search mr-2"" viewBox=""0 0 16 16"">
                    <path d=""M11.742 10.344a6.5 6.5 0 1 0-1.397 1.398h-.001c.03.04.062.078.098.115l3.85 3.85a1 1 0 0 0 1.415-1.414l-3.85-3.85a1.007 1.007 0 0 0-.115-.1zM12 6.5a5.5 5.5 0 1 1-11 0 5.5 5.5 0 0 1 11 0z"" />
                </svg>
                Busque la planta seleccionando un tipo existente y se desplegaran todas las del tipo seleccionado.
            </div>
        </li>
        <li class=""list-group-item d-flex justify-content-between align-items-start list-group-item-primary"">
            <div class=""ms-2 me-auto"">
                <div class=""fw-bold my-2""> <a href=""/Planta/PlantasPorAmbiente"" class=""btn btn-light""> Por Ambiente </a> </div>
                <svg xmlns=""http://www.w3.org/2000/sv");
                WriteLiteral(@"g"" width=""25"" height=""25"" fill=""currentColor"" class=""bi bi-search mr-2"" viewBox=""0 0 16 16"">
                    <path d=""M11.742 10.344a6.5 6.5 0 1 0-1.397 1.398h-.001c.03.04.062.078.098.115l3.85 3.85a1 1 0 0 0 1.415-1.414l-3.85-3.85a1.007 1.007 0 0 0-.115-.1zM12 6.5a5.5 5.5 0 1 1-11 0 5.5 5.5 0 0 1 11 0z"" />
                </svg>
                Busque la planta seleccionando el ambiente al que corresponde y se desplegaran todas las plantas que sean de ese ambiente.
                <i class=""bi bi-search""></i>
            </div>
        </li>
        <li class=""list-group-item d-flex justify-content-between align-items-start"">
            <div class=""ms-2 me-auto"">
                <div class=""fw-bold my-2""> <a href=""/Planta/PlantasPorMayorAltura"" class=""btn btn-secondary""> Por altura mayor o igual</a> </div>
                <svg xmlns=""http://www.w3.org/2000/svg"" width=""25"" height=""25"" fill=""currentColor"" class=""bi bi-search mr-2"" viewBox=""0 0 16 16"">
                    <path d=""M11.742 10.344a");
                WriteLiteral(@"6.5 6.5 0 1 0-1.397 1.398h-.001c.03.04.062.078.098.115l3.85 3.85a1 1 0 0 0 1.415-1.414l-3.85-3.85a1.007 1.007 0 0 0-.115-.1zM12 6.5a5.5 5.5 0 1 1-11 0 5.5 5.5 0 0 1 11 0z"" />
                </svg>
                Busque la planta dada una altura en centímetros, se mostraran las que tengan esa altura o sean mas altas.
                <i class=""bi bi-search""></i>
            </div>
        </li>
        <li class=""list-group-item d-flex justify-content-between align-items-start list-group-item-primary"">
            <div class=""ms-2 me-auto"">
                <div class=""fw-bold my-2""> <a href=""/Planta/PlantasPorMenorAltura"" class=""btn btn-light""> Por altura menor  </a>  </div>
                <svg xmlns=""http://www.w3.org/2000/svg"" width=""25"" height=""25"" fill=""currentColor"" class=""bi bi-search mr-2"" viewBox=""0 0 16 16"">
                    <path d=""M11.742 10.344a6.5 6.5 0 1 0-1.397 1.398h-.001c.03.04.062.078.098.115l3.85 3.85a1 1 0 0 0 1.415-1.414l-3.85-3.85a1.007 1.007 0 0 0-.115-.1zM12 6.5a5.5 5.5 ");
                WriteLiteral(@"0 1 1-11 0 5.5 5.5 0 0 1 11 0z"" />
                </svg>
                Busque la planta dada una altura en centímetros, se mostraran las que tengan esa altura o que sean mas bajas.
                <i class=""bi bi-search""></i>
            </div>
        </li>
        <li class=""list-group-item d-flex justify-content-between align-items-start"">
            <div class=""ms-2 me-auto"">
                <div class=""fw-bold my-2""><a href=""/Planta/ListaDePlantas"" class=""btn btn-secondary""> Mostrar Todas Las plantas </a>  </div>
                <svg xmlns=""http://www.w3.org/2000/svg"" width=""25"" height=""25"" fill=""currentColor"" class=""bi bi-search mr-2"" viewBox=""0 0 16 16"">
                    <path d=""M11.742 10.344a6.5 6.5 0 1 0-1.397 1.398h-.001c.03.04.062.078.098.115l3.85 3.85a1 1 0 0 0 1.415-1.414l-3.85-3.85a1.007 1.007 0 0 0-.115-.1zM12 6.5a5.5 5.5 0 1 1-11 0 5.5 5.5 0 0 1 11 0z"" />
                </svg>
                Se mostraran todas las plantas
                <i class=""bi bi-search""></i>
  ");
                WriteLiteral("          </div>\r\n        </li>\r\n\r\n    </ol>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebObligatoriop3.Models.ViewModelPlanta> Html { get; private set; }
    }
}
#pragma warning restore 1591
