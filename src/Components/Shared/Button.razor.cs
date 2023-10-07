using Microsoft.AspNetCore.Components;

namespace RandomWorkings.github.io.Components.Shared;

partial class Button : Component
{
    [Parameter]
    public string Text { get; set; } = string.Empty;

    [Parameter]
    public string Href { get; set; } = "/";

    [Parameter]
    public string Target { get; set; } = "_self";

    [Parameter]
    public string TitleAttribute { get; set; } = "Hyperlink to Home";

    [Parameter]
    public string LanguageAttribute { get; set; } = "en-gb";
    
    public Dictionary<string, object> BaseAttributes { get => GenerateBaseAttributes(); }
    public Dictionary<string, object> LinkAttributes { get => GenerateLinkAttributes(); }

    private Dictionary<string, object> GenerateBaseAttributes()
    {
        var attributes = new Dictionary<string, object>
        {
            { "class", $"btn button {Classes}" },
            { "title", TitleAttribute },
            { "lang", LanguageAttribute },
        };

        return attributes;
    }

    private Dictionary<string, object> GenerateLinkAttributes()
    {
        var attributes = new Dictionary<string, object>
        {
            { "class", $"link {Classes}" },
        };

        return attributes;
    }
}