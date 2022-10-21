using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Fiap.Aula04.Web.TagHelpers
{
    //<botao texto="Editar">
    //<button type="submit" class="btn btn-success">Editar</button>
    public class BotaoTagHelper : TagHelper
    {
        public string? Texto { get; set; }
        public string? Class { get; set; } = "btn btn-success";

        //Definir a tag HTML final 
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //Definir o nome da tag HTML
            output.TagName = "button";
            //Configurar atributos da tag
            output.Attributes.SetAttribute("class", Class);
            output.Attributes.SetAttribute("type", "submit");
            //Definir o conteúdo da tag
            output.Content.SetContent(Texto);
        }
    }
}
